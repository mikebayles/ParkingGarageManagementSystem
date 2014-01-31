using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingGarageManagementSystem.Models
{
    public class Bill
    {
        //declare constants
        const double HourlyRate = 0.75;
        const double TaxRate = 0.075;
        const double PenaltyFee = 25.00;

        private double _amount;
        private User _user;
        private List<Reservation> _reservations;
        private string _text;
        private int _id;

        //create some HTML for the email message
        private void CreateText()
        {
            _text = string.Format(
                "<div style=\"width:500px; margin: 0 auto 0 auto\">" +
                    "<div style=\"text-align:center\"> " +
                         "<h1>Parking Garage Reservation</h1>" +
                         "<p>*************************************</p>" +
                     "</div>" +

                "<br /><br />" +
                "<p>Name : {2}</p>" +
                "<p>Email : {3}</p>" +
                "<p>Phone : {4}</p>" +
                "<p>Credit Card Number: {5}</p>" +
                 "<p>Bill Number: {0}</p>" +
                 "<p style=\"border-bottom:dotted 2px black\">{1}</p>" +
                 "<p>Reservations :<p>" +
                 "<ol style=\"border-bottom:dotted 2px black;\">"
                 , ID, DateTime.Now, User.First + " " + User.Last,
                 User.Email, User.Phone, User.CreditCardNumber);
        }
        public int ID
        {
            get{return _id;}
            set{_id = value;}
        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public User User
        {
            get{ return _user; }
            set{ _user = value;}           
        }
        //holds all reservations that this user created
        public List<Reservation> Reservations
        {
            get{ return _reservations; }
            set { _reservations = value; }
        }
        //HTML for email message
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public void CalculateAmount()
        {
            //only create the HTML if there are reservations
            if (Reservations.Count > 0)
                CreateText();
            //iterate through all of the reservations
            //create an li element for each reservation
            foreach (var res in Reservations)
            {
                if (res.Status != Reservation.Cancel)
                {
                    //duration of reservation
                    double hours = (res.End - res.Start).TotalHours;
                    double resAmount = hours * Bill.HourlyRate;
                    //update the amount
                    Amount += resAmount;

                    //append some html showing information regarding the reservation, spot, and amount
                    Text += string.Format("<li style=\"font-size:9px;\">Reservation  : {0}<p>Spot : {1}<p> <p style=\"float:right;font-size:12px;font-weight:bold;\">Amount : {2:C}</p</li>",
                        res.ToString(), res.ParkingSpot.ToString(), resAmount);
                    
                }
                //reservation cancelled
                else
                {
                    Text += string.Format("<li style=\"font-size:9px;text-decoration:line-through\">Reservation  : {0} Amount 0",
                            res.ToString());
                }
            }
            double subtotal = Amount;
            double taxes = subtotal * TaxRate;
            Amount = (subtotal + taxes);
            Text+= string.Format(
                    "</ol>"+
                    "<p stlyle=\"font-size:13px;\">Subtotal : <span style=\"float:right;\">{0:C}</span></p>" + 
                    "<p stlyle=\"font-size:13px;\">Taxes : <span style=\"float:right;\">{1:C}</span></p>" +
                    "<p stlyle=\"font-size:14px;\">Total : <span style=\"float:right;\">{2:C}</span></p>" +
                "</div>",subtotal,taxes,Amount);
        }
    }
}
