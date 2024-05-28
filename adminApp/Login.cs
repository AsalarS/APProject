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
using System.Drawing.Text;
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
            //validation and feedback
            var signInResults = await VerifyUserNamePassword(txtUserName.Text, txtPassword.Text);
            if (signInResults == true && Global.HomeCareUser.UserRole != "Customer" && Global.HomeCareUser.UserRole != "Technician") //if user is verified
            {
                //do something.. i.e. navigate to next forms
                dashboard dash = new dashboard();
                this.Hide();
                dash.Show();
            }
            else if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("you left either username or password empty", "Error");
            }
            else if (Global.HomeCareUser.UserRole == "Customer" || Global.HomeCareUser.UserRole == "Technician") //if user is verified (not technician not Customer)
            {
                MessageBox.Show("Access Denied!!", "Error");
            }
            else
            {
                MessageBox.Show("Error. The username or password are not correct");

                //reset textboxes
                txtUserName.Text = "";
                txtPassword.Text = "";
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
                    var passCheck = await userManager.CheckPasswordAsync(founduser, password) == true;

                    if (passCheck)
                    {
                        var roles = await userManager.GetRolesAsync(founduser);

                        //save into global class

                        Global.User = founduser;

                        Global.RoleName = roles.FirstOrDefault();

                        //Those are added as extra just to show how you can query all users in a certain role
                        Global.AllAdmins = await userManager.GetUsersInRoleAsync("Admin");
                        Global.AllManagers = await userManager.GetUsersInRoleAsync("Manager");
                        Global.AllTechnicians = await userManager.GetUsersInRoleAsync("Technician");
                        Global.AllUsers = await userManager.GetUsersInRoleAsync("User");
                        try
                        {
                            Global.HomeCareUser = Context.Users.Where(x => x.Email == Global.User.Email).FirstOrDefault();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        if (Global.HomeCareUser == null)
                        {
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

        
    }

}
