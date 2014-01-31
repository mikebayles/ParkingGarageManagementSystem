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
using ParkingGarageManagementSystem.Main;

namespace ParkingGarageManagementSystem
{
    public partial class MainForm : Form
    {
        Controller controller;
        public MainForm(Controller c)
        {
            InitializeComponent();
            controller = c;
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create the vehicle form
            VehicleForm frmVehicle = new VehicleForm(controller);
            frmVehicle.ShowDialog();
            //refresh if there were changes made
            garageGrid1.RefreshSpots();
        }


        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new reservation form
            NewReservationForm frmReservation = new NewReservationForm(controller);
            frmReservation.ShowDialog();
            //refresh if there were changes made
            garageGrid1.RefreshSpots();
        }

        private void manageMyReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create manage reservation form
            ManageReservation frmReservation = new ManageReservation(controller);
            frmReservation.ShowDialog();
            //refresh if there were changes made
            garageGrid1.RefreshSpots();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //only the Admin people can use the admin dropdown
            adminToolStripMenuItem.Visible = controller.CurrentlyLoggedInUser.Role == User.RoleTypes.Admin;
        }

        private void viewStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create stats on menu item click
            controller.CreateStats();
        }

        private void generateBillsForMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create bills for this months
            //ideally used at the end of the month
            controller.CreateBillsForMonth();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close
            Close();
        }

    }
}
