using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using adminApp;
using HomeCareObjects.Model;
using Microsoft.EntityFrameworkCore;
namespace AdminApp
{
    public partial class Login : Form
    {
        private IServiceProvider serviceProvider;
        HomeCareDBContext Context;

        public Login()
        {
            InitializeComponent();
            Context = new HomeCareDBContext();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            //this comment below is for debugging purposes

            /*this.Hide();
            dashboard dashboard = new dashboard();
            dashboard.Show();*/

            var signInResults = await VerifyUserNamePassword(txtUserName.Text, txtPassword.Text);
            if (signInResults == true) //if user is verified
            {
                //do something.. i.e. navigate to next forms
                dashboard dashboard = new dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Error. The username or password are not correct");
            }
        }
        
        public async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            try
            {
                using (var context = new HomeCareDBContext())
                {
                    var user = await context.Users
                        .Where(u => u.Username == userName && u.Password == password) // Again, consider hashing passwords
                        .FirstOrDefaultAsync();

                    if (user != null)
                    {
                        // User is verified, do something...
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error. The username or password are not correct");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return false;
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddEntityFrameworkSqlServer()
                    .AddDbContext<HomeCareDBContext>();

                // Register UserManager & RoleManager
                services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<HomeCareDBContext>()
                   .AddDefaultTokenProviders();

                // UserManager & RoleManager require logging and HttpContext dependencies
                services.AddLogging();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
