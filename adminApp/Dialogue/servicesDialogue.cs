using HomeCareObjects.Model;
using ProjectFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminApp.Dialogue
{
    public partial class servicesDialogue : Form
    {
        HomeCareDBContext context;
        Service service;
        public servicesDialogue()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            service = new Service();
        }

        public servicesDialogue(int service)
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            this.service = context.Services.Find(service);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void servicesDialogue_Load(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine(Global.HomeCareUser.UserId);
                // this if statement alows the manager to add services to his assigned category only
                if (context.Categories.Any(x => x.ManagerId == Global.HomeCareUser.UserId) && Global.HomeCareUser.UserRole == "Manager")
                {
                    ddlCategory.DataSource = context.Categories.Where(x => x.ManagerId == Global.HomeCareUser.UserId).ToList();
                    ddlCategory.DisplayMember = "CategoryName";
                    ddlCategory.ValueMember = "CategoryID";
                    ddlCategory.Enabled = false;


                }
                if (Global.HomeCareUser.UserRole == "Admin")
                {
                    ddlCategory.DataSource = context.Categories.ToList();
                    ddlCategory.DisplayMember = "CategoryName";
                    ddlCategory.ValueMember = "CategoryID";
                    ddlCategory.SelectedItem = null;

                }

                if (service != null && service.ServiceId > 0)
                {
                    txtServiceId.Text = service.ServiceId.ToString();
                    ddlCategory.SelectedValue = service.CategoryId;
                    ddlTechnician.SelectedValue = service.TechnicianId;
                    nameTxt.Text = service.ServiceName;
                    descTxt.Text = service.ServiceDescription;
                    priceTxt.Text = service.ServicePrice.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                service.ServiceName = nameTxt.Text;
                service.ServiceDescription = descTxt.Text;
                if (!Double.TryParse(priceTxt.Text, out _))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }
                service.ServicePrice = Convert.ToDecimal(priceTxt.Text);

                if (ddlCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category and a technician.");
                    return;
                }

                service.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue.ToString());
                //service.TechnicianId = Convert.ToInt32(ddlTechnician.SelectedValue.ToString());
                service.TechnicianId = ddlTechnician.SelectedValue != null ? Convert.ToInt32(ddlTechnician.SelectedValue) : null;

                if (service != null && service.ServiceId > 0)
                {
                    context.Services.Update(service);
                }
                else
                {
                    //add the order to the orders DBSet
                    context.Services.Add(service);
                }
                //Execute the insert SQL
                context.SaveChanges();

                //Only if the insert was successful, we can 
                this.DialogResult = DialogResult.OK;
                //close the form
                this.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                // MessageBox.Show($"Error: {ex.InnerException?.Message}");
                MessageBox.Show("Error on save: " + ex.Message);
            }
        }

        private void ddlCategory_DropDownClosed(object sender, EventArgs e) //TODO: Discuss database changes
        {
            try
            {
                var selectedValue = Convert.ToInt32(ddlCategory.SelectedValue);
                var technicianIds = context.Services
                                           .Where(x => x.CategoryId == selectedValue)
                                           .Select(x => x.TechnicianId)
                                           .ToList();
                // Get the unique technician IDs and then their names
                var technicians = context.Users
                                          .Where(u => technicianIds.Contains(u.UserId))
                                          .ToList();

                ddlTechnician.DataSource = technicians;
                ddlTechnician.DisplayMember = "FullName";
                ddlTechnician.ValueMember = "UserID";
                ddlTechnician.SelectedItem = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
