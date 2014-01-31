using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParkingGarageManagementSystem;

namespace Parking_Garage_Management_System
{
    public partial class Register : Form
    {
        Controller controller;
        public Register(Controller c)
        {
            InitializeComponent();
            controller = c;
            
        }
#region Field Validation
        private void txtUsername_Validated(object sender, EventArgs e)
        {
            picLoad.Visible = true;
            btnRegister.Enabled = false;
            //Check if the user name already exists
            if (controller.CheckUsernameExists(txtUsername.Text))
            {
                lblUsername.Text = string.Format("Please choose another username.\n{0} is already taken", txtUsername.Text);
                txtUsername.Focus();
            }

            //The column is varchar(25). we cannot go over
            else if (txtUsername.Text.Length > 25)
            {
                lblUsername.Text = "Your username is too long. \n25 characters or less are allowed.";
                txtUsername.Focus();
            }
            //else username valid
            else
            {
                lblUsername.Text = "Username valid.";
                btnRegister.Enabled = true;
            }
            picLoad.Visible = false;
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            //The column is varchar(25). we cannot go over
            if (txtPassword.Text.Length > 25)
            {
                lblPassword.Text = "Your password is too long. \n25 characters or less are allowed.";
                txtPassword.Focus();
            }
            //blank password
            else if (txtPassword.Text.Length == 0)
            {
                lblPassword.Text = "You must provide a password.";
                txtPassword.Focus();
            }
            //valid password
            else
            {
                lblPassword.Text = "Password valid.";
                btnRegister.Enabled = true;
            }
        }

        private void txtFirst_Validated(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            //The column is varchar(10). we cannot go over
            if (txtFirst.Text.Length > 10)
            {
                lblFirst.Text = "Your First Name is too long. \n10 characters or less are allowed.";
                txtFirst.Focus();
            }
            //blank first name
            else if (txtFirst.Text.Length == 0)
            {
                lblFirst.Text = "You must provide a first name.";
                txtFirst.Focus();
            }
            //valid first name
            else
            {
                lblFirst.Text = "First Name valid.";
                btnRegister.Enabled = true;
            }
        }

        private void txtLast_Validated(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            //The column is varchar(10). we cannot go over
            if (txtLast.Text.Length > 10)
            {
                lblLast.Text = "Your Last Name is too long. \n10 characters or less are allowed.";
                txtLast.Focus();
            }
            //blank last name
            else if (txtLast.Text.Length == 0)
            {
                lblLast.Text = "You must provide a last name";
                txtLast.Focus();
            }
            //valid last name
            else
            {
                lblLast.Text = "Last Name valid.";
                btnRegister.Enabled = true;
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            //The column is char(10). we must have 10 characters
            if (txtPhone.Text.Length != 10)
            {
                lblPhone.Text = "Phone number must be\n 10 characters exactly.";
                txtPhone.Focus();
            }
            //valid phone number
            else
            {
                lblPhone.Text = "Phone Number valid.";
                btnRegister.Enabled = true;
            }
        }
        private void txtEmail_Validated(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            string email = txtEmail.Text;
            //valid if contains @ and .
            if (!email.Contains("@") && !email.Contains("."))
            {
                lblEmail.Text = "Not a valid email address";
                txtEmail.Focus();
            }
            //valid email
            else
            {
                lblEmail.Text = "Email Address valid.";
                btnRegister.Enabled = true;
            }
        }

        private void txtCredit_Validated(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            //The column is char(16). we must have 16 characters
            if (txtCredit.Text.Length != 16)
            {
                lblCredit.Text = "Credit card number must be\n 16 characters exactly.";
                txtCredit.Focus();
            }
            //valid credit card number
            else
            {
                lblCredit.Text = "Credit card number valid.";
                btnRegister.Enabled = true;
            }
        }
#endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //display loading screen
            picLoad.Visible = true;
            //create new user with the textbox values
            controller.CurrentlyLoggedInUser = controller.CreateNewUser(txtUsername.Text, txtPassword.Text, txtFirst.Text, 
                txtLast.Text, txtPhone.Text, txtEmail.Text, txtCredit.Text);
            //hide the loading screen
            picLoad.Visible = false;
            MessageBox.Show("Registration Complete!");
            
            Hide();
            //open the main form
            MainForm frmMain = new MainForm(controller);
            frmMain.ShowDialog();
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //toggle the password char
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }


    }
}
