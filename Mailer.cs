using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Parking_Garage_Management_System;
using ParkingGarageManagementSystem.Models;

namespace ParkingGarageManagementSystem
{
    //this classes sends emails to users
    class Mailer
    {
        //sent when a new user is created
        public static void SendRegistrationConfirmation(User newUser)
        {
            MailMessage message = new MailMessage();
            message.To.Add(newUser.Email);
            message.Subject = string.Format("Welcome {0} {1}!", newUser.First, newUser.Last);
            message.IsBodyHtml = true;
            message.Body = "<p>Thanks for joining the world leader in Parking Management!</p><p>You <b>won't</b> be sorry!</p>";
            message.From = new MailAddress("parkinggaragemanagementsystem@gmail.com");
            Send(message);
        }
        //sent when a user forgot his/her password
        public static bool SendForgotPassEmail(string ToEmail, Controller c)
        {
            string password = c.GetPassword(ToEmail);
            if(password.Length == 0)
                return false;

            MailMessage message = new MailMessage();
            message.To.Add(ToEmail);
            message.Subject = "Parking Garage Password Recovery";
            message.Body = string.Format("Here is your password: {0}",password);
            message.From = new MailAddress("parkinggaragemanagementsystem@gmail.com");
            Send(message);
            return true;
        }
        //sent when a new reservation is made
        public static void SendReservationConfirmation(Reservation r)
        {
            MailMessage message = new MailMessage();
            message.To.Add(r.User.Email);
            message.Subject = "Parking Garage Reservation Confirmation";
            message.IsBodyHtml = true;
            message.From = new MailAddress("parkinggaragemanagementsystem@gmail.com"); 
            message.Body = string.Format(
                "<p>Dear {0} {1},</p>" +
                "<p>You recently created a reservation. Here are the details:</p>" +
                "<ul>" +
                    "<li>ID Number : {2}</li>" +
                    "<li>Start Date and Time : {3}</li>" +
                    "<li>End Date and Time : {4}</li>" +
                    "<li>Vehicle Information : {5}</li>" +
                    "<li>Parking Spot Information : {6}</li>" +
                "</ul>" +

                "<p>Thanks for your business</p>", r.User.First, r.User.Last, r.ReservationID, r.Start, r.End, r.Vehicle.ToString(), r.ParkingSpot.SpotId);
            Send(message);
        }
        //sends a bill using the bill's html
        public static void SendBill(Bill b)
        {
            MailMessage message = new MailMessage();
            message.To.Add(b.User.Email);
            message.Subject = "Parking Garage Bill";
            message.IsBodyHtml = true;
            message.From = new MailAddress("parkinggaragemanagementsystem@gmail.com");

            message.Body = b.Text;
            Send(message);

        }
        //sends stats 
        public static void SendStatistics(string email, string body)
        {
            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.Subject = "Parking Garage Statistics";
            message.IsBodyHtml = true;
            message.From = new MailAddress("parkinggaragemanagementsystem@gmail.com");

            message.Body = body;
            Send(message);
        }
        //sends a message from the Gmail account I created
        private static void Send(MailMessage msg)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("parkinggaragemanagementsystem@gmail.com", ParkingGarageManagementSystem.Properties.Settings.Default.GmailPassword)
            };
            smtp.Send(msg);
        }
    }
}
