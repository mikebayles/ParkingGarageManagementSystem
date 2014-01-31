using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking_Garage_Management_System;
using ParkingGarageManagementSystem.Models;

namespace ParkingGarageManagementSystem.Main
{
    public partial class ManageReservation : Form
    {
        Controller controller;
        public ManageReservation(Controller c)
        {
            InitializeComponent();
            controller = c;
        }


        private void ManageReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingGarageDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.FillByUser(this.parkingGarageDataSet.Reservation,controller.CurrentlyLoggedInUser.Username);

            foreach (DataGridViewRow row in dgvReservation.Rows)
            {
                //if status is complete or cancelled
                //don't allow user to edit
                string status = row.Cells[Reservation.ReservationColumn.Status].Value.ToString();
                if ( status == Reservation.Complete || status == Reservation.Cancel)
                    row.ReadOnly = true;
            }
        }

        private void reservationBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationBindingSource.EndEdit();
            //if there are dirty values
            //we must update the List<Reservation>
            if(parkingGarageDataSet.HasChanges())
            {
                DataSet changes = parkingGarageDataSet.GetChanges(DataRowState.Modified);                
                if (changes != null)
                {
                    //iterate through all of the dirty reservations
                    foreach(DataRow row in changes.Tables["Reservation"].Rows)
                    {
                        //get all the fields
                        int id = row.Field<int>(Reservation.ReservationColumn.ReservationID);
                        string status = row.Field<string>(Reservation.ReservationColumn.Status);
                        DateTime start = Controller.DatabaseNullHelper(row.Field<DateTime?>(Reservation.ReservationColumn.StartTime));
                        DateTime end = Controller.DatabaseNullHelper(row.Field<DateTime?>(Reservation.ReservationColumn.EndTime));
                        DateTime arrival = Controller.DatabaseNullHelper(row.Field<DateTime?>(Reservation.ReservationColumn.Arrival));
                        DateTime departure = Controller.DatabaseNullHelper(row.Field<DateTime?>(Reservation.ReservationColumn.Departure));
                        //set all the fields
                        Reservation updater = controller.AllReservations.Where(a => a.ReservationID == id).Single();
                        updater.Status = status;
                        updater.Start = start;
                        updater.End = end;
                        updater.Arrival = arrival;
                        updater.Departure = departure;
                    }
                 
                    
                }

                
            }
            //save to DB
            this.tableAdapterManager.UpdateAll(this.parkingGarageDataSet);

        }
        //returns true if orig is between start and end
        private bool Between(DateTime orig, DateTime start, DateTime end)
        {
            return start <= orig && orig <= end;
        }
        private void reservationDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            lblStatus.Text = "";
            //don't validate if the user clicked on the blank row or the row is already read only
            if (e.RowIndex == dgvReservation.Rows.Count - 1 || dgvReservation[e.ColumnIndex,e.RowIndex].ReadOnly)
                return;
            //if the user was in the start time column
            if (e.ColumnIndex == dgvReservation.Columns[Reservation.ReservationColumn.StartTime].Index)
            {               
                DateTime newStart;
                if(!DateTime.TryParse(e.FormattedValue.ToString(),out newStart))
                {
                    MessageBox.Show("Invalid Start Date/Time");
                }
                string SpotID = dgvReservation[Reservation.ReservationColumn.SpotID,e.RowIndex].Value.ToString();
                int reservationID = Convert.ToInt32(dgvReservation[Reservation.ReservationColumn.ReservationID, e.RowIndex].Value);
                //if the new start date is before now
                if (newStart < DateTime.Now)
                {                    
                    dgvReservation.CancelEdit();
                    e.Cancel = true;
                    lblStatus.Text = "You cannot set the start time before the current time";
                }
                //if there are any other reservations with this spot that is already taken
                //I had to include the a.ReservationID != reservationID so it doesn't count itself
                else if (controller.AllReservations.Any(a => a.ReservationID != reservationID && a.ParkingSpot.SpotId == SpotID && Between(newStart,a.Start,a.End)))
                {
                    dgvReservation.CancelEdit();
                    e.Cancel = true;
                    lblStatus.Text = "This spot is taken at your desired new start time";
                }
            }
            //if the user was in the end time cell
            else if (e.ColumnIndex == dgvReservation.Columns[Reservation.ReservationColumn.EndTime].Index)
            {
                DateTime newEnd;
                if(!DateTime.TryParse(e.FormattedValue.ToString(),out newEnd))
                {
                    MessageBox.Show("Invalid Start Date/Time");
                }
                string SpotID = dgvReservation[Reservation.ReservationColumn.SpotID, e.RowIndex].Value.ToString();
                int reservationID = Convert.ToInt32(dgvReservation[Reservation.ReservationColumn.ReservationID, e.RowIndex].Value);

                //if there are any other reservations with this spot that is already taken
                //I had to include the a.ReservationID != reservationID so it doesn't count itself
                if (controller.AllReservations.AsEnumerable().Any(a => a.ReservationID != reservationID && a.ParkingSpot.SpotId == SpotID && Between(newEnd, a.Start,a.End)))
                {
                    dgvReservation.CancelEdit();
                    e.Cancel = true;
                    lblStatus.Text = "This spot is taken at your desired new end time";
                }
            }
            //the save button is only enabled if there is no error message
            reservationBindingNavigatorSaveItem.Enabled = lblStatus.Text.Length == 0;
        }

        private void dgvReservation_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //don't do anything for the last blank row
            if (e.RowIndex == dgvReservation.Rows.Count - 1)
                return;

            //get the row
            var row = dgvReservation.Rows[e.RowIndex];
            string status = row.Cells[Reservation.ReservationColumn.Status].Value.ToString();
            //conditionally set the color of row based off Reservation.Status
            if (status == Reservation.Active)
                row.DefaultCellStyle.BackColor = Color.PeachPuff;
            else if (status == Reservation.Cancel)
                row.DefaultCellStyle.BackColor = Color.LimeGreen;
            else if (status == Reservation.Complete)
                row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            else if (status == Reservation.Future)
                row.DefaultCellStyle.BackColor = Color.Cyan;
        }
        //used to let users arrive to their spots(check in)
        private void btnArrive_Click(object sender, EventArgs e)
        {
            //you can only check in for 1 reservation at a time
            if (dgvReservation.SelectedRows.Count != 1)
            {
                lblStatus.Text = "Select 1 row to check in for";
                return;
            }

            var row = dgvReservation.SelectedRows[0];
            DateTime start = DateTime.Parse(row.Cells[Reservation.ReservationColumn.StartTime].Value.ToString());
            DateTime end = DateTime.Parse(row.Cells[Reservation.ReservationColumn.EndTime].Value.ToString());

            DateTime now = DateTime.Now;
            DateTime checkIn;
            //a form of error catching. Can't have null DateTime
            DateTime.TryParse(row.Cells[Reservation.ReservationColumn.Arrival].Value.ToString(),out checkIn);

            //I often use DateTime.MinValue to represent a null DB value
            //can't check into a reservation you already did
            if (checkIn != null && checkIn!= DateTime.MinValue)
                lblStatus.Text = "You already checked into this reservation";  
            //if the reservation is completely in the past
            else if (now > start && now > end)
            {
                lblStatus.Text = "This reservation is old";
            }
            //you can't check into a reservation in the future
            else if (now < start)
            {
                lblStatus.Text = "You cannot check into this reservation yet";
            }
            //valid check in
            else if (Between(now, start, end))
            {
                row.Cells[Reservation.ReservationColumn.Arrival].Value = DateTime.Now;
                row.Cells[Reservation.ReservationColumn.Status].Value = Reservation.Active;
                //save
                reservationBindingNavigatorSaveItem.PerformClick();
                Close();
            }
        }
        //the user checkouts or departs from their spot
        private void btnDepart_Click(object sender, EventArgs e)
        {
            //you can only check out of 1 reservation at a time
            if (dgvReservation.SelectedRows.Count != 1)
            {
                lblStatus.Text = "Select 1 row to check out for";
                return;
            }

            var row = dgvReservation.SelectedRows[0];
            DateTime start = DateTime.Parse(row.Cells[Reservation.ReservationColumn.StartTime].Value.ToString());
            DateTime end = DateTime.Parse(row.Cells[Reservation.ReservationColumn.EndTime].Value.ToString());

            DateTime now = DateTime.Now;
            DateTime checkOut;
            DateTime.TryParse(row.Cells[Reservation.ReservationColumn.Departure].Value.ToString(), out checkOut);

            DateTime checkIn;
            DateTime.TryParse(row.Cells[Reservation.ReservationColumn.Arrival].Value.ToString(), out checkIn);

            //I often use DateTime.MinValue to represent a null DB value
            //can't check into a reservation you already did
            if (checkOut != null && checkOut!= DateTime.MinValue)
                lblStatus.Text = "You already checked out of this reservation";
            //can't checkout before checkin
            if (checkIn == null || checkIn == DateTime.MinValue)
                lblStatus.Text = "You cannot checkout if you haven't checked in";
            //if the reservation is completely in the past
            else if (now > start && now > end)
            {
                lblStatus.Text = "This reservation is old";
            }
            //can't checkout of a future reservation
            else if (now < start)
            {
                lblStatus.Text = "You cannot check out this reservation yet";
            }
            //valid checkout
            else if (Between(now, start, end))
            {
                row.Cells[Reservation.ReservationColumn.Departure].Value = DateTime.Now;
                row.Cells[Reservation.ReservationColumn.Status].Value = Reservation.Complete;
                //save
                reservationBindingNavigatorSaveItem.PerformClick();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //you can only cancel 1 reservation at a time
            if (dgvReservation.SelectedRows.Count != 1)
            {
                lblStatus.Text = "Select 1 row to cancel";
                return;
            }

            DateTime now = DateTime.Now;
            
            var row = dgvReservation.SelectedRows[0];

            


            string status = row.Cells[Reservation.ReservationColumn.Status].Value.ToString();
            //can't cancel an already cancelled reservation
            if (status == Reservation.Cancel)
                lblStatus.Text = "Reservation already cancelled";
            //cannot cancel a completed reservation
            else if (status == Reservation.Complete)
                lblStatus.Text = "You cannot cancel a completed reservation";
            //don't cancel active reservation, check out instead
            //TODO: possibly run checkout for user
            else if (status == Reservation.Active)
                lblStatus.Text = "You cannot cancel an active reservation. Check out instead";
            //valid cancel
            else if (status == Reservation.Future)
            {
                //can only cancel if 24 hours in advanced
                if (now.AddDays(1) > DateTime.Parse(row.Cells[Reservation.ReservationColumn.StartTime].Value.ToString()))
                {
                    lblStatus.Text = "You cannot cancel a reservation 24 hours prior to your start time";
                    return;
                }

                //updated date values
                row.Cells[Reservation.ReservationColumn.Status].Value = Reservation.Cancel;
                row.Cells[Reservation.ReservationColumn.Arrival].Value = now;
                row.Cells[Reservation.ReservationColumn.Departure].Value = now;
                //save
                reservationBindingNavigatorSaveItem.PerformClick();
                Close();
            }
            
        }
        //close form
        private void btnClose_Click(object sender, EventArgs e)
        {            
            Close();
        }

    }
}
