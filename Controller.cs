using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ParkingGarageManagementSystem;
using System.Net.Mail;
using System.Net;
using ParkingGarageManagementSystem.Models;
namespace Parking_Garage_Management_System
{
    /*NOTE: I started the project using very database heavy query methods and updates and inserts
     * after some class discussion, it was advised to use more Linq querying
     * I switched about halfway through project to Linq
     * but my implmentation was not completed.
     * I started using more Linq and Lambda expressions.
     * All datagridview are binded to db objects not C# objects
     */ 
    public class Controller
    {
        User _currentlyLoggedInUser;

        public List<User> AllUsers;
        public List<Vehicle> AllVehicles;
        public List<ParkingSpot> AllParkingSpots;
        public List<Reservation> AllReservations;

        public Controller()
        {
            
            AllUsers = null;
            AllVehicles = null;
            AllParkingSpots = null;
            AllReservations = null;
            //Initialize the Lists with DB values
            UpdateAllData();
        }
        public void UpdateAllData()
        {
            InitializeUsers();
            InitializeVehicles();
            InitializeParkingSpots();
            InitializeReservations();
            UpdateParkingSpots(DateTime.Now);
        }
        //HUGE!
        //This holds the currently logged in user which is used very frequently
        public User CurrentlyLoggedInUser
        {
            get { return _currentlyLoggedInUser; }
            set
            {
                if (value != null)
                    _currentlyLoggedInUser = value;
            }
        }
        private void InitializeUsers()
        {
            //gets all of the users from the DB
            //then creates strongly typed lists of Users
            string query = "select * from dbo.[User]";
            DataTable table = DatabaseHandler.GetTable(query);
            //use lambda expression to create a new User for each DB record
            AllUsers= table.AsEnumerable().Select(a => new User
            {
                Username = a.Field<string>(User.UserColumn.Username),
                Password = a.Field<string>(User.UserColumn.Password),
                Role = a.Field<string>(User.UserColumn.Role),
                First = a.Field<string>(User.UserColumn.First),
                Last = a.Field<string>(User.UserColumn.Last),
                Phone = a.Field<string>(User.UserColumn.Phone),
                Email = a.Field<string>(User.UserColumn.Email),
                CreditCardNumber = a.Field<string>(User.UserColumn.CreditCard)
            }).ToList<User>();
        }
        private void InitializeVehicles()
        {
            //gets all vehicles from DB
            //and creates a strongly typed list of Vehicle type
            string query = "select * from dbo.[Vehicle]";
            DataTable table = DatabaseHandler.GetTable(query);
            //user lambda to create new Vehicle objects for each DB record
            AllVehicles = table.AsEnumerable().Select(a=> new Vehicle
            {
                VehicleID = a.Field<int>(Vehicle.Vehicle_Column.Vehicle_ID),
                Make = a.Field<string>(Vehicle.Vehicle_Column.Make),
                Model = a.Field<string>(Vehicle.Vehicle_Column.Model),
                Year = a.Field<string>(Vehicle.Vehicle_Column.Year),
                Color = a.Field<string>(Vehicle.Vehicle_Column.Color),
                License = a.Field<string>(Vehicle.Vehicle_Column.License),
                User = AllUsers.Where(b=> b.Username == a.Field<string>(User.UserColumn.Username)).Select(b=> b).Single()
            }).ToList<Vehicle>();
            
        }
        private void InitializeParkingSpots()
        {
            //get all of the parking spots
            //and fill strongly typed List<ParkingSpot> with ParkingSpot objects
            string query = "select * from dbo.[Parking_Spot]";
            DataTable table = DatabaseHandler.GetTable(query);
            //use lambda to create a new ParkingSpot object for each DB record
            AllParkingSpots = table.AsEnumerable().Select(a => new ParkingSpot
            {
                SpotId = a.Field<string>(ParkingSpot.ParkingSpotColumn.SpotId),
                Floor = a.Field<int>(ParkingSpot.ParkingSpotColumn.Floor),
                Section = a.Field<string>(ParkingSpot.ParkingSpotColumn.Section),
                Status = a.Field<string>(ParkingSpot.ParkingSpotColumn.Status)//CalculateStatus(a)
            }).ToList<ParkingSpot>();
        }
        //we must update the parkingspot list to show the correct status
        //based off a given time
        private void UpdateParkingSpots(DateTime time)
        {
            //iterate through all reservations
            foreach(Reservation r in AllReservations)
            {
                //find the spot that is in the reservation
                ParkingSpot spot = AllParkingSpots.Where(a => a == r.ParkingSpot && Between(time,r.Start,r.End)).SingleOrDefault();
                if (spot == null)
                    continue;
                //unforunately, we can't use anything but hardcoded stuff in the switch
                //switch the status and update the parking spot
                switch (r.Status)
                {
                    case "CANCEL":
                    case "COMPLETE" :
                    case "FUTURE" :
                        spot.Status = ParkingSpot.Available;
                        break;
                    case "ACTIVE" :
                        if(r.Arrival == DateTime.MinValue)
                            spot.Status = ParkingSpot.Reserved;
                        else
                            spot.Status = ParkingSpot.Occupied;
                        break;
                    
                }
            }

        }
        private void InitializeReservations()
        {
            //get allreservations
            //then we are going to add an object to the List<Reservation>
            string query = "select * from dbo.[Reservation]";
            DataTable table = DatabaseHandler.GetTable(query);
            //Create a new reservation for each Reservation using lambda
            AllReservations = table.AsEnumerable().Select(a => new Reservation
            {
                ReservationID = a.Field<int>(Reservation.ReservationColumn.ReservationID),
                Start = a.Field<DateTime>(Reservation.ReservationColumn.StartTime),
                End = a.Field<DateTime>(Reservation.ReservationColumn.EndTime),
                //search the users for the corresponding user
                User = AllUsers.Where(b => b.Username == a.Field<string>(User.UserColumn.Username)).Select(b => b).Single(),
                //search the vehicles for the corresponding vehicle
                Vehicle = AllVehicles.Where(b => b.VehicleID == a.Field<int>(Vehicle.Vehicle_Column.Vehicle_ID)).Select(b => b).Single(),
                //search the parking spots for the corresponding spot
                ParkingSpot = AllParkingSpots.Where(b => b.SpotId == a.Field<string>(ParkingSpot.ParkingSpotColumn.SpotId)).Select(b => b).Single(),
                Arrival = DatabaseNullHelper(a.Field<DateTime?>(Reservation.ReservationColumn.Arrival)),
                Departure = DatabaseNullHelper(a.Field<DateTime?>(Reservation.ReservationColumn.Departure)),
                Status = a.Field<string>(Reservation.ReservationColumn.Status)
            }).ToList<Reservation>();
        }
        public static DateTime DatabaseNullHelper(DateTime? date)
        {
            return date == null ? DateTime.MinValue : date.Value;
        }
        public static bool DateNotNull(DateTime dt)
        {
            return dt != DateTime.MinValue;
        }
        //gets a user for a specific username
        public User GetUser(string username)
        {
            DataTable users = DatabaseHandler.GetTable(string.Format("select * from dbo.[User] where USER_ID = '{0}'", username));
            User newUser = new User
            {
                Username = users.Rows[0][User.UserColumn.Username].ToString(),
                Password = users.Rows[0][User.UserColumn.Password].ToString(),
                Role = users.Rows[0][User.UserColumn.Role].ToString(),
                First = users.Rows[0][User.UserColumn.First].ToString(),
                Last = users.Rows[0][User.UserColumn.Last].ToString(),
                Phone = users.Rows[0][User.UserColumn.Phone].ToString(),
                Email = users.Rows[0][User.UserColumn.Email].ToString(),
                CreditCardNumber = users.Rows[0][User.UserColumn.CreditCard].ToString()
            };

            return newUser;
        }
        //validates a user based off username and password
        public bool CheckLogin(string user, string pass)
        {
            DataTable users = DatabaseHandler.GetTable(string.Format("select * from dbo.[User] where USER_ID = '{0}' AND PASSWORD = '{1}'",user,pass));
            return users.Rows.Count == 1;
        }
        //checks to see if a username exists
        public bool CheckUsernameExists(string username)
        {
            DataTable user = DatabaseHandler.GetTable(string.Format("select * from dbo.[User] where USER_ID = '{0}'",username));
            return user.Rows.Count == 1;
        }
        //creates a new user based off values
        public User CreateNewUser(string username, string password, string first, string last,
            string phone, string email, string credit)
        {
            string query = string.Format("insert into dbo.[User] VALUES('{0}','{1}','{8}','{2}','{3}','{4}','{5}','{6}','{7}')",
                username, password, first, last, phone, email, credit,DateTime.Now,User.RoleTypes.User);

            DatabaseHandler.ExecuteNonQuery(query);
            User newUser = new User
            {
                Username = username,
                Password = password,
                Role = User.RoleTypes.User,
                First = first,
                Last = last,
                Phone = phone,
                Email = email,
                CreditCardNumber = credit
            };
            //sends an email welcoming the new user
            Mailer.SendRegistrationConfirmation(newUser);
            return newUser;
        }
        //gets the password for a given email
        public string GetPassword(string email)
        {
            DataTable password = DatabaseHandler.GetTable(string.Format("select PASSWORD from dbo.[User] where EMAIL ='{0}'",email));
            if (password.Rows.Count > 0)
            {
                //return the first password result
                return password.Rows[0][User.UserColumn.Password].ToString();
            }
            return "";
        }
        //gets all reservations for the logged in user
        public DataTable GetReservations()
        {
            DataTable reservations =  DatabaseHandler.GetTable(
                "SELECT  Reservation.RESERVATION_ID as ID, Reservation.START_TIME, Reservation.END_TIME, Vehicle.MAKE, Vehicle.MODEL, Vehicle.YEAR " +
                "FROM    Parking_Spot INNER JOIN " +
                         "Reservation ON Parking_Spot.SPOT_ID = Reservation.SPOT_ID INNER JOIN " +
                         "[User] ON Reservation.USER_ID = [User].USER_ID INNER JOIN " +
                         "Vehicle ON Reservation.VEHICLE_ID = Vehicle.VEHICLE_ID AND [User].USER_ID = Vehicle.USER_ID " +
                "WHERE   ([User].USER_ID = '" + CurrentlyLoggedInUser.Username +"')");
         
            return reservations;
        }
        //gets vehicles for the logged in user
        public DataTable GetVehiclesForUser()
        {
            string query = string.Format("select YEAR + ' ' + MAKE + ' ' + MODEL AS Vehicle_Information, VEHICLE_ID from VEHICLE where USER_ID = '{0}'", CurrentlyLoggedInUser.Username);
            return DatabaseHandler.GetTable(query);
        }
        //very complex query
        //finds available parking spots between two dates
        public DataTable FindAvailableSpotsBetweenDates(DateTime start, DateTime end)
        {
            string query = string.Format(
                "SELECT SPOT_ID,FLOOR, SECTION, STATUS " +
                    "FROM Parking_Spot " +
                    "WHERE        (NOT EXISTS " +
                    "(SELECT START_TIME, END_TIME, SPOT_ID " +
                        "FROM Reservation " +
                        "WHERE ((START_TIME BETWEEN CONVERT(DATETIME, '{0}', 102) AND CONVERT(DATETIME, '{1}', 102)) OR " +
                               "(END_TIME BETWEEN CONVERT(DATETIME, '{0}', 102) AND CONVERT(DATETIME, '{1}', 102))) AND " +
                               "(Parking_Spot.SPOT_ID = SPOT_ID)))",start,end);

            return DatabaseHandler.GetTable(query);
        }
        //returns true if orig is between start and end
        private bool Between(DateTime orig, DateTime start, DateTime end)
        {
            return start <= orig && orig <= end;
        }
        //gets the next reservation id
        private int getNextReservationID()
        {
            return AllReservations.OrderByDescending(a => a.ReservationID).First().ReservationID + 1;
        }
        public int getNextVehicleID()
        {
            return AllVehicles.OrderByDescending(a => a.VehicleID).First().VehicleID + 1;
        }
        //creates a new reservation object and inserts a reservation into the DB
        public Reservation CreateNewReservation(DateTime start, DateTime end, int vehicle, string spot)
        {
            string status =  DateTime.Now <= end ? Reservation.Active : Reservation.Future;
            string query = string.Format("insert into dbo.[Reservation](START_TIME,END_TIME,USER_ID,VEHICLE_ID,SPOT_ID, STATUS) VALUES( " +
                "'{0}','{1}','{2}',{3},'{4}','{5}')", start, end, CurrentlyLoggedInUser.Username, vehicle, spot,status);

            DatabaseHandler.ExecuteNonQuery(query);
            Reservation newReservation = new Reservation
            {
                ReservationID = getNextReservationID(),
                Start = start,
                End = end,
                User = CurrentlyLoggedInUser,
                //use lambda to find the correct vehicle object
                Vehicle = AllVehicles.Where(a => a.VehicleID == vehicle).Select(a => a).Single(),
                //use lambda to find the correct parking spot
                ParkingSpot = AllParkingSpots.Where(a => a.SpotId == spot).Select(a => a).Single(),
                Status = status
            };
            //add the new reservation
            AllReservations.Add(newReservation);
            return newReservation;
        }
        //creates and mails bills for all users
        public void CreateBillsForMonth()
        {
            DateTime now = DateTime.Now;
            //group reservations by user
            var reservationGroupedByUser = 
                from reservation in AllReservations
                where reservation.Start.Month == now.Month
                && reservation.Start < now
                group reservation by reservation.User into g
                select g;
            //foreach user create a new Bill
            foreach (var result in reservationGroupedByUser)
            {
                Bill newBill = new Bill();
                newBill.User = result.Key;
                newBill.Reservations = new List<Reservation>();

                foreach (var reservation in result)
                {
                    newBill.Reservations.Add(reservation);
                }
                //calculate the amount and produce the HTML
                newBill.CalculateAmount();
                Mailer.SendBill(newBill);

            }          
        }
        //creates some basic stats
        //uses a lot of html to format
        public void CreateStats()
        {
            int totalUsers = AllUsers.Count;
            var usersGroupedByRole =
                from user in AllUsers
                group user by user.Role into g
                select g;

            int totalSpots = AllParkingSpots.Count;
            var spotsGroupedByStatus =
                from spot in AllParkingSpots
                group spot by spot.Status into g
                select g;

            int totalVehicles = AllVehicles.Count;
            var vehiclesGroupedByYear =
                from vehicle in AllVehicles
                group vehicle by vehicle.Year into g
                select g;
            var vehiclesGroupedByColor =
                from vehicle in AllVehicles
                group vehicle by vehicle.Color into g
                select g;

            int totalReservations = AllReservations.Count;
            var reservationsGroupedByStatus =
                from reservation in AllReservations
                group reservation by reservation.Status into g
                select g;
            var averageHours = AllReservations.Average(a => (a.End - a.Start).TotalHours);
            var averageStayHours = AllReservations.Where(a => DateNotNull(a.Arrival) && DateNotNull(a.Departure)).
                Average(a => (a.Departure - a.Arrival).TotalHours);
            //create html
            string html = string.Format(
                "<div>" +
                    "<h1>Parking Garage Statistics</h1>" +
	                "<p>Total users : {0}</p>" +
                    "<p>Users by Role</p>" +
                    "<ul>",totalUsers);
            foreach(var group in usersGroupedByRole)
            {
                html+=string.Format("<li>{0} : {1}</li>",group.Key,group.Count());
            }
                    html+=string.Format(
                    "</ul>" +
                    "<p>Total Parking Spots : {0}</p>" +
                    "<p>Parking Spots by Status</p>" +
                    "<ul>",totalSpots);
            foreach(var group in spotsGroupedByStatus)
            {
                html+=string.Format("<li>{0} : {1}</li>",group.Key,group.Count());
            }

                html+=string.Format(
                    "</ul>" +
                    "<p>Total Vehicles : {0}</p>" +
                    "<p>Vehicles by Year</p>" +
                    "<ul>",totalVehicles);

            foreach(var group in vehiclesGroupedByYear)
            {
                html+=string.Format("<li>{0} : {1}</li>",group.Key,group.Count());
            }

            html+=
                "</ul>" + 
                "<p>Vehicles by Color</p>" +
                "<ul>";
            foreach(var group in vehiclesGroupedByColor)
            {
                html+=string.Format("<li>{0} : {1}</li>",group.Key,group.Count());
            }

            html += string.Format(
                    "</ul>" +
                    "<p>Total Reservations : {0}</p>" +
                    "<p>Reservations by Status</p>" +
                    "<ul>", totalReservations);

            foreach (var group in reservationsGroupedByStatus)
            {
                html += string.Format("<li>{0} : {1}</li>", group.Key, group.Count());
            }

            html += string.Format(
                    "</ul>" +
                    "<p>Average duration of reservation (hours) : {0}</p>" +
                    "<p>Average duration of stay (hours) : {1}</p>"
                    , averageHours, averageStayHours);

            html += "</div>";
            //send the statistics to the logged in user using all of that html
            Mailer.SendStatistics(CurrentlyLoggedInUser.Email, html);
        }
    }
}
