using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking_Garage_Management_System;

namespace ParkingGarageManagementSystem.Models
{
    //allows user to see and edit their vehicle data
    public partial class VehicleForm : Form
    {
        Controller controller;
        public VehicleForm(Controller c)
        {
            InitializeComponent();
            
            controller = c;
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            //we must update the controller's AllVehicles List<Vehicle>
            if (parkingGarageDataSet.HasChanges())
            {
                DataSet changes = parkingGarageDataSet.GetChanges(DataRowState.Modified);
                if (changes != null)
                {
                    foreach (DataRow row in changes.Tables["Vehicle"].Rows)
                    {
                        //get all the fields
                        int id = row.Field<int>(Vehicle.Vehicle_Column.Vehicle_ID);
                        string make = row.Field<string>(Vehicle.Vehicle_Column.Make);
                        string model = row.Field<string>(Vehicle.Vehicle_Column.Model);
                        string year = row.Field<string>(Vehicle.Vehicle_Column.Year);
                        string color = row.Field<string>(Vehicle.Vehicle_Column.Color);
                        string license = row.Field<string>(Vehicle.Vehicle_Column.License);
                        //set all the fields
                        Vehicle updater = controller.AllVehicles.Where(a => a.VehicleID == id).Single();
                        updater.Make = make;
                        updater.Model = model;
                        updater.Year = year;
                        updater.Color = color;
                        updater.License = license;
                    }
                }

                DataSet additions = parkingGarageDataSet.GetChanges(DataRowState.Added);
                if (additions != null)
                {
                    foreach (DataRow row in additions.Tables["Vehicle"].Rows)
                    {
                        //get all the fields
                        string make = row.Field<string>(Vehicle.Vehicle_Column.Make);
                        string model = row.Field<string>(Vehicle.Vehicle_Column.Model);
                        string year = row.Field<string>(Vehicle.Vehicle_Column.Year);
                        string color = row.Field<string>(Vehicle.Vehicle_Column.Color);
                        string license = row.Field<string>(Vehicle.Vehicle_Column.License);
                        //set all the fields
                        Vehicle newVehicle = new Vehicle
                        {
                            VehicleID = controller.getNextVehicleID(),
                            Make = make,
                            Model = model,
                            Year = year,
                            Color = color,
                            License = license,
                            User = controller.CurrentlyLoggedInUser
                        };

                        controller.AllVehicles.Add(newVehicle);
                    }
                }

                DataSet delete = parkingGarageDataSet.GetChanges(DataRowState.Deleted);
                if (delete != null)
                {
                    foreach (DataRow row in delete.Tables["Vehicle"].Rows)
                    {
                        //get all the fields
                        int id = row.Field<int>(Vehicle.Vehicle_Column.Vehicle_ID);
                        Vehicle toBeDeleted = controller.AllVehicles.Where(a=> a.VehicleID == id).Single();
                        controller.AllVehicles.Remove(toBeDeleted);
                    }
                }


            }
            //save DB
            this.tableAdapterManager.UpdateAll(this.parkingGarageDataSet);

        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingGarageDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.FillForUser(this.parkingGarageDataSet.Vehicle,controller.CurrentlyLoggedInUser.Username);
            //user can't add vehicles for other users
            vehicleDataGridView.Columns[Vehicle.Vehicle_Column.User_ID].ReadOnly = true;
        }

        private void vehicleDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //set default value of user to the currently logged in one
            e.Row.Cells[Vehicle.Vehicle_Column.User_ID].Value = controller.CurrentlyLoggedInUser.Username;
        }
    }
}
