using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking_Garage_Management_System
{
    public partial class Welcome : Form
    {
        Controller controller;
        public Welcome()
        {
            InitializeComponent();
            controller = new Controller();
        }
        //opens the login form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Login frmLogin = new Login(controller);
            frmLogin.ShowDialog();
            Show();
        }
        //opens the registration form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            Register frmRegister = new Register(controller);
            frmRegister.ShowDialog();
            Show();
        }
    }
}
