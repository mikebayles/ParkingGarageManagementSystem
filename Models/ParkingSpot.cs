using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingGarageManagementSystem.Models
{
    public class ParkingSpot
    {
        private string _spotId;
        private int _floor;
        private string _section;
        private string _status;

        //Parking Spot Sections
        public readonly static string Jefferson = "JEFFERSON";
        public readonly static string Lincoln = "LINCOLN";
        public readonly static string Washington = "WASHINGTON";
        //Parking Spot Statuses
        public readonly static string Available = "AVAILABLE";
        public readonly static string Occupied = "OCCUPIED";
        public readonly static string Reserved = "RESERVED";

        public string SpotId
        {
            get { return _spotId; }
            set { _spotId = value; }
        }

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public override string ToString()
        {
            return string.Format("Spot ID : {0} Section : {1} Floor {2}", SpotId, Section, Floor);
        }

        public class ParkingSpotColumn
        {
            public static string SpotId = "SPOT_ID";
            public static string Floor = "FLOOR";
            public static string Section = "SECTION";
            public static string Status = "STATUS";
        }
    }
}
