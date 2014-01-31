using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ParkingGarageManagementSystem;

namespace Parking_Garage_Management_System
{
    public partial class Login : Form
    {
        Controller controller;
        //submitClickCount used to track number of incorrect login attempts
        int submitClickCount = 0;
        public Login(Controller c)
        {
            InitializeComponent();
            controller = c;
        }

        //shows and hides the password field by toggling the PasswordChar field of the textbox
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //toggle the password char
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool success = controller.CheckLogin(txtUsername.Text, txtPassword.Text);
            lblStatus.Text = success ? "Login Successful!" : "Login Failed. Please Try Again";
            submitClickCount++;

            if (success)
            {
                //reset number of failed attempts
                submitClickCount = 0;
                controller.CurrentlyLoggedInUser = controller.GetUser(txtUsername.Text);
                Hide();
                MainForm frmMain = new MainForm(controller);
                frmMain.ShowDialog();
                Close();
            }

            //if the user tried 3 times to login
            //ask if they'd like a email to give them their password
            if (submitClickCount >= 3)
            {
                //prompt for email
                string email = Microsoft.VisualBasic.Interaction.InputBox("Forgot Password? Enter your email address below to get a reminder email");
                //if email isn't blank
                if (email.Length > 0)
                {
                    //if the address was not found
                    if (!Mailer.SendForgotPassEmail(email, controller))         
                        MessageBox.Show("Email address not found");
                    Close();
                }
            }
        }
    }
}
