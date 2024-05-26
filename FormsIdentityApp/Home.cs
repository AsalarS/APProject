using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFormApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            lblUserID.Text = Global.User.Id;
            lblUserName.Text = Global.User.UserName;
            lblUserEmail.Text = Global.User.Email;
            lblRole.Text = Global.RoleName;

            //var alltech = Global.AllTechnicicans;
            //var alladmins = Global.AllAdmins;
            //var allmanagers = Global.AllManagers;
            //var allusers = Global.AllUsers;

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //clear out everything in Global class
            Global.User = null;
            Global.RoleName = null;
            Global.AllAdmins = null;
            Global.AllManagers = null;
            Global.AllUsers = null;

            this.Hide();

            Login login = new Login();
            login.Show();

            //alternatively you can use the method of passing the form object for cleaner approach


        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
