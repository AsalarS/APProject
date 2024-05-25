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


namespace ProjectFormApp
{
    public partial class Login : Form
    {
        private  IServiceProvider serviceProvider;

        FormsIdentityContext IdentityContext = new FormsIdentityContext();
       
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
         
            var signInResults = await VerifyUserNamePassword(txtUserName.Text, txtPassword.Text);
            if(signInResults == true) //if user is verified
            {
                //do something.. i.e. navigate to next forms
                Home home = new Home();
                this.Hide();
                home.Show();
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
                        Global.AllTechnicicans = await userManager.GetUsersInRoleAsync("Technician");
                        Global.AllUsers = await userManager.GetUsersInRoleAsync("User");
                    }
                    return passCheck;
                }
                return false;
            }
            catch (Exception ex) {
                MessageBox.Show("Error");
                return false; 
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            try { 
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
            catch(Exception ex) {
                MessageBox.Show("Error");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
