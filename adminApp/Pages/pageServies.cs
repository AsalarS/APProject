using adminApp.Dialogue;
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
using ProjectFormApp;

namespace AdminApp
{
    public partial class pageServies : Form
    {
        HomeCareDBContext context;
        public pageServies()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void servicesPage_Load(object sender, EventArgs e)
        {
            //this is to change the text color
            //this.ForeColor = Color.Black;
            dgvServices.ForeColor = Color.Black;
            RefreshGridView();

            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryID";
            ddlCategory.SelectedItem = null;

            ddlTechnician.DataSource = context.Users.Where(x => x.UserRole == "Technician").ToList();
            ddlTechnician.DisplayMember = "FullName";
            ddlTechnician.ValueMember = "UserID";
            ddlTechnician.SelectedItem = null;


        }

        private void RefreshGridView()
        {
            dgvServices.DataSource = null;
            var servicesToShow = context.Services.AsQueryable();
            if (txtServiceID.Text != "")
            {
                servicesToShow = servicesToShow
                    .Where(x => x.ServiceId == Convert.ToInt32(txtServiceID.Text));
                //if order id is specified in the filters, get the order with that id
            }
            else if (ddlCategory.SelectedValue != null)
            {
                servicesToShow = servicesToShow
                    .Where(x => x.CategoryId == Convert.ToInt32(ddlCategory.SelectedValue.ToString()));
                //if customer is selected from the combobox, get orders of that customer
            }
            else if (ddlTechnician.SelectedValue != null)
            {
                servicesToShow = servicesToShow
                    .Where(x => x.TechnicianId == Convert.ToInt32(ddlTechnician.SelectedValue.ToString()));
                //if customer is selected from the combobox, get orders of that customer
            }

            
            
            dgvServices.DataSource = servicesToShow.OrderByDescending(m => m.ServiceId).Select(o => new
            {

                ServiceID = o.ServiceId,
                ServiceName = o.ServiceName,
                ServiceDescription = o.ServiceDescription,
                ServicePrice = o.ServicePrice,
                CategoryID = o.Category.CategoryId,
                TechnicianID = o.TechnicianId,

            }).ToList();

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int firstcell = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value);
            Service service = context.Services.Single(x => x.ServiceId == firstcell);
            int SelectedCategoryID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[4].Value);

            if (Global.HomeCareUser.UserId != Convert.ToInt32(context.Categories.Where(x => x.CategoryId == SelectedCategoryID).FirstOrDefault().ManagerId.ToString()) && Global.HomeCareUser.UserRole != "Admin")
            {
                MessageBox.Show("the Service your trying to Delete is assigned to another manager");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete service (" + firstcell + ")", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Services.Remove(service);

                    context.SaveChanges();

                    MessageBox.Show("Deleted successfully. ");

                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                    MessageBox.Show($"Error: {ex.InnerException?.Message}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            servicesDialogue frmservicedialouge = new servicesDialogue();
            frmservicedialouge.ShowDialog();
            if (frmservicedialouge.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Added successfully."); //Show feedback to the user
                RefreshGridView(); //refresh only if the user added a new record
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int SelectedServiceID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value);
                int SelectedCategoryID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[4].Value);
               // Service selectedService = context.Services.Find(SelectedServiceID);
                servicesDialogue frmServiceEdit = new servicesDialogue(SelectedServiceID);

                if (Global.HomeCareUser.UserId != Convert.ToInt32(context.Categories.Where(x => x.CategoryId == SelectedCategoryID).FirstOrDefault().ManagerId.ToString()) && Global.HomeCareUser.UserRole != "Admin")
                {
                    MessageBox.Show("the Service your trying to update is assigned to another manager");
                    return;
                }
                else
                {
                    frmServiceEdit.ShowDialog();
                }

                if (frmServiceEdit.DialogResult == DialogResult.OK)
                {
                    RefreshGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtServiceID.Text = "";
            ddlTechnician.SelectedItem = null;
            ddlCategory.SelectedItem = null;
            RefreshGridView();
        }
    }
}
