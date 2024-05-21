using HomeCareObjects.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        public servicesDialogue(Service service)
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            this.service = service;
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
                ddlCategory.DataSource = context.Categories.ToList();
                ddlCategory.DisplayMember = "CategoryName";
                ddlCategory.ValueMember = "CategoryId";
                ddlCategory.SelectedItem = null;

                ddlTechnician.DataSource = context.Users.Where(x => x.UserRole == "Technician").ToList();
                ddlTechnician.DisplayMember = "FullName";
                ddlTechnician.ValueMember = "UserId";
                ddlTechnician.SelectedItem = null;

                if (service.ServiceId > 0)
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
                service.ServicePrice = Convert.ToDecimal(priceTxt.Text);
                service.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue.ToString());
                service.TechnicianId = Convert.ToInt32(ddlTechnician.SelectedValue.ToString());

                if (ddlCategory.SelectedValue == null || ddlTechnician.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category and a technician.");
                    return;
                }


                if (service.CategoryId > 0)
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
                MessageBox.Show("Error: " + ex.Message);
            }
            }
    }
}
