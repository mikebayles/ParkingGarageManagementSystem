using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingGarageManagementSystem.Models
{
    public class Vehicle
    {
        private int _vehicleId;
        private string _make;
        private string _model;
        private string _year;
        private string _color;
        private string _license;
        private User _user;

        public int VehicleID
        {
            get { return _vehicleId; }
            set { _vehicleId = value; }
        }

        public string Make 
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string License
        {
            get { return _license; }
            set { _license = value; }
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Year, Make, Model);
        }
        public static class Vehicle_Column
        {
            public static string Vehicle_ID = "VEHICLE_ID";
            public static string User_ID = User.UserColumn.Username;
            public static string Make = "MAKE";
            public static string Model = "MODEL";
            public static string Year = "YEAR";
            public static string Color = "COLOR";
            public static string License = "LICENSE";
        }
    }
}
