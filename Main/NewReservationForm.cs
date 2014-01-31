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
    public partial class NewReservationForm : Form
    {
        Controller controller;
        public NewReservationForm(Controller c)
        {
            InitializeComponent();
            controller = c;
        }

        private void NewReservationForm_Load(object sender, EventArgs e)
        {
            //initialize combobox with vehicles only by this user
            cboVehicle.DataSource = controller.GetVehiclesForUser();
            cboVehicle.ValueMember = Vehicle.Vehicle_Column.Vehicle_ID;
            cboVehicle.DisplayMember = "Vehicle_Information";
            //set date time formats
            dtpStart.CustomFormat = "MMMM dd, yyyy hh:mm";
            dtpEnd.CustomFormat = "MMMM dd, yyyy hh:mm";
            //I need the SpotID column, but the user doesn't need to see it
            dgvSpots.Columns[ParkingSpot.ParkingSpotColumn.SpotId].Visible = false;
        }
        //search for spots between a date range
        private void btnSearch_Click(object sender, EventArgs e)
        {

            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;
            //validate start/end dates
            if (start.CompareTo(end) >= 0)
            {
                lblStatus.Text = "Arrival Date/Time must come before Departure Date/Time";
                return;
            }
            //very complex sql query that i couldn't do with linq
            DataTable spots = controller.FindAvailableSpotsBetweenDates(dtpStart.Value, dtpEnd.Value);
            dgvSpots.DataSource = spots;

            int numberOfSpots = spots.Rows.Count;
            lblStatus.Text = numberOfSpots == 0? "No Spots Found" : numberOfSpots + " Spots Found";
            //only display the following controls if there were spots
            lblVehicle.Visible = numberOfSpots > 0 ? true : false;
            cboVehicle.Visible = numberOfSpots > 0 ? true : false;
            btnSubmit.Visible = numberOfSpots > 0 ? true : false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //must select 1 and only 1 row
            if (dgvSpots.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must select 1 row");
                return;
            }
            
            if (cboVehicle.Items.Count == 0)
            {
                MessageBox.Show("You cannot create a reservation if you have no registered vehicles");
                return;
            }
            string spotID = dgvSpots.SelectedRows[0].Cells[ParkingSpot.ParkingSpotColumn.SpotId].Value.ToString();
            Reservation r = controller.CreateNewReservation(dtpStart.Value, dtpEnd.Value, Convert.ToInt32(cboVehicle.SelectedValue), spotID);
            //creates reservation and sends email
            Mailer.SendReservationConfirmation(r);
            MessageBox.Show("Reservation created! Check your email for more details");
            Close();
        }

    }
}
