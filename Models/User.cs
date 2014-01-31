using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingGarageManagementSystem
{
    public class User
    {
        private string _username;
        private string _password;
        private string _role;
        private string _first;
        private string _last;
        private string _phone;
        private string _email;
        private string _credit;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string First
        {
            get { return _first; }
            set { _first = value; }
        }

        public string Last
        {
            get { return _last; }
            set { _last = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }            
        }

        public string CreditCardNumber
        {
            get { return _credit; }
            set { _credit = value; }
        }

        public override string ToString()
        {
            return string.Format("Name : {0} {1}\nPassword : {2}\nEmail Address: {3}",
                _first,_last,_password,_email);
        }
        public class RoleTypes
        {
            public static string User = "USER";
            public static string Admin = "ADMIN";
        }

        public class UserColumn
        {
            public static string Username = "USER_ID";
            public static string Password = "PASSWORD";
            public static string Role = "ROLE";
            public static string First = "FIRST";
            public static string Last = "LAST";
            public static string Phone = "PHONE";
            public static string Email = "EMAIL";
            public static string CreditCard = "CREDIT";
        }
    }
}
