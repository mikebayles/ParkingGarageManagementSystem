using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking_Garage_Management_System;
using ParkingGarageManagementSystem.Models;

namespace ParkingGarageManagementSystem.Main
{
    public partial class GarageGrid : UserControl
    {
        private int _floor;
        private Controller controller;        

        //property used to increase/decrease floor
        public int Floor
        {
            get { return _floor; }
            set
            {
                if(value <1)
                    _floor = 1;
                else if(value >3)
                    _floor = 3;
                else
                    _floor = value;
            }
        }
        public GarageGrid()
        {
            InitializeComponent();
            controller = new Controller();
        }
        //colors each button(parking spot) according to its status
        private void ColorButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    //find the corresponding spot and button based off spot id and button's tag
                    ParkingSpot spot = controller.AllParkingSpots.Where(a => a.SpotId == c.Tag.ToString()).Single();
                    //display corresponding color per status
                    if (spot.Status == ParkingSpot.Available)
                        c.BackColor = Color.Green;
                    else if (spot.Status == ParkingSpot.Occupied)
                        c.BackColor = Color.Red;
                    else if (spot.Status == ParkingSpot.Reserved)
                        c.BackColor = Color.Yellow;               
                }
            }
        }
        private void GarageGrid_Load(object sender, EventArgs e)
        {
            //set the floor to 1 by default
            Floor = 1; 
            //color all the buttons for correct status
            ColorButtons();
            ChangeAllButtons();
        }

        public void RefreshSpots()
        {
            //update data
            controller.UpdateAllData();
            ChangeAllButtons();
            ColorButtons();
        }
        private void lblFloorUp_Click(object sender, EventArgs e)
        {
            //change the label and change the tag for each button
            Floor++;
            lblFloorUp.Visible = Floor == 3 ? false : true;
            lblFloorDown.Visible = Floor == 1 ? false : true;
            ChangeAllButtons();
            ColorButtons();
        }
        private void ChangeTagFloor(Control c, int newFloor)
        {
            //increases/decreases floor value on each button'ss tag
            lblFloor.Text = Floor.ToString();
            string oldTag = c.Tag.ToString();
            string AllExceptFloor = oldTag.Substring(1);
            string newTag = newFloor + AllExceptFloor;
            c.Tag = newTag;
            c.Text = newTag;

        }
        private void lblFloorDown_Click(object sender, EventArgs e)
        {
            //change the label and change the tag for each button
            Floor--;
            lblFloorDown.Visible = Floor == 1 ? false : true;
            lblFloorUp.Visible = Floor == 3 ? false : true;
            ChangeAllButtons();
            ColorButtons();
        }

        private void ChangeAllButtons()
        {
            //iterates through all buttons 
            //and changes the cloor via tag property
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    ChangeTagFloor(c, Floor);
                }
            }
        }
    }
}
