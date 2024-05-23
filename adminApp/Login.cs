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
using ProjectFormApp;
namespace AdminApp
{
    public partial class Login : Form
    {
        private IServiceProvider serviceProvider;
        HomeCareDBContext Context;
         FormsIdentityContext IdentityContext = new FormsIdentityContext();
        

        public Login()
        {
            InitializeComponent();
            Context = new HomeCareDBContext();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var signInResults = await VerifyUserNamePassword(txtUserName.Text, txtPassword.Text);
            if (signInResults == true) //if user is verified
            {
                //do something.. i.e. navigate to next forms
                dashboard dash = new dashboard();
                this.Hide();
                dash.Show();
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


                var services = new ServiceCollection();
                ConfigureServices(services);
                serviceProvider = services.BuildServiceProvider();

                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var founduser = await userManager.FindByEmailAsync(txtUserName.Text);

                if (founduser != null)
                {
                    var passCheck = await userManager.CheckPasswordAsync(founduser, password) == true  ;

                    if (passCheck)
                    {
                        var roles = await userManager.GetRolesAsync(founduser);

                        if (roles.Contains("Admin") || roles.Contains("Manager"))
                        {
                            //save into global class
                            Global.User = founduser;
                            Global.RoleName = roles.FirstOrDefault();

                            // Those are added as extra just to show how you can query all users in a certain role
                            Global.AllAdmins = await userManager.GetUsersInRoleAsync("Admin");
                            Global.AllManagers = await userManager.GetUsersInRoleAsync("Manager");
                            Global.AllTechnicicans = await userManager.GetUsersInRoleAsync("Technician");
                            Global.AllUsers = await userManager.GetUsersInRoleAsync("User");
                            try
                            {
                                Global.HomeCareUser = Context.Users.Where(x => x.Email == ProjectFormApp.Global.User.Email).FirstOrDefault();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                            return true;
                        }
                        else
                        {
                            // User does not have the required role
                            MessageBox.Show("Must be admin or manager");
                            return false;
                        }

                    }
                    return passCheck;
                }
                return false;
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
                    .AddDbContext<FormsIdentityContext>();

                // Register UserManager & RoleManager
                services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<FormsIdentityContext>()
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

        private void btnDebugLogin_Click(object sender, EventArgs e)
        {
            //this comment below is for debugging purposes

            this.Hide();
            dashboard dashboard = new dashboard();
            dashboard.Show();
        }
    }

}
