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
                //Validation
                if(nameTxt.Text == null)
                {
                    MessageBox.Show("Please enter a service name.");
                    return;
                }
                if (descTxt.Text == null)
                {
                    MessageBox.Show("Please enter a service description.");
                    return;
                }
                if (!Double.TryParse(priceTxt.Text, out _))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }
                if (ddlCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category.");
                    return;
                }

                service.ServiceName = nameTxt.Text;
                service.ServiceDescription = descTxt.Text;
                service.ServicePrice = Convert.ToDecimal(priceTxt.Text);
                service.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue.ToString());

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

                //Only if the insert was successful
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                // MessageBox.Show($"Error: {ex.InnerException?.Message}");
                MessageBox.Show("Error on save: " + ex.Message);
            }
        }
    }
}
