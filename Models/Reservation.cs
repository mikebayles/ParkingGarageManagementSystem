using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingGarageManagementSystem.Models
{
    public class Reservation
    {
        private int _reservationID;
        private DateTime _start;
        private DateTime _end;
        private User _user;
        private Vehicle _vehicle;
        private ParkingSpot _parkingSpot;
        private DateTime _arrival;
        private DateTime _departure;
        private string _status;

        //Reservation Statues
        public readonly static string Complete = "COMPLETE";
        public readonly static string Active = "ACTIVE";
        public readonly static string Cancel = "CANCEL";
        public readonly static string Future = "FUTURE";

        public int ReservationID
        {
            get { return _reservationID; }
            set { _reservationID = value; }
        }

        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public Vehicle Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }

        public ParkingSpot ParkingSpot
        {
            get { return _parkingSpot; }
            set { _parkingSpot = value; }
        }

        public DateTime Arrival
        {
            get { return _arrival; }
            set { _arrival = value; }
        }

        public DateTime Departure
        {
            get { return _departure; }
            set { _departure = value; }
        }

        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Start: {1} End {2}",ReservationID,Start.ToString("f"),End.ToString("f"));
        }

        public class ReservationColumn
        {
            public static string ReservationID = "RESERVATION_ID";
            public static string StartTime = "START_TIME";
            public static string EndTime = "END_TIME";
            public static string UserID = User.UserColumn.Username;
            public static string VehicleID = Vehicle.Vehicle_Column.Vehicle_ID;
            public static string SpotID = ParkingSpot.ParkingSpotColumn.SpotId;
            public static string Arrival = "ARRIVAL";
            public static string Departure = "DEPARTURE";
            public static string Status = "STATUS";
        }
    }
}
