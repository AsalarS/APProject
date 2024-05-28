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
            RefreshGridView(); //Populate Data Grid View

            //Populate the comboboxes
            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryID";
            ddlCategory.SelectedItem = null;

            ddlTechnician.DataSource = context.Users.Where(x => x.UserRole == "Technician").ToList();
            ddlTechnician.DisplayMember = "FullName";
            ddlTechnician.ValueMember = "UserID";
            ddlTechnician.SelectedItem = null;


        }

        private void RefreshGridView() //Refresh & Populate Data Grid View
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

                ID = o.ServiceId,
                Name = o.ServiceName,
                Description = o.ServiceDescription,
                Price = o.ServicePrice,
                Category = o.Category.CategoryId,
                Technician = o.TechnicianId,

            }).ToList();

            // Set column headers style
            dgvServices.EnableHeadersVisualStyles = false;
            dgvServices.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 13, 37);
            dgvServices.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvServices.ColumnHeadersDefaultCellStyle.Font = new Font(dgvServices.Font.FontFamily, 10, FontStyle.Bold);
            dgvServices.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 10, 10, 10);

            // Set column widths
            dgvServices.Columns[0].Width = 50; // ServicesID
            dgvServices.Columns[1].Width = 175; // ServiceName
            dgvServices.Columns[2].Width = 300; // Description
            dgvServices.Columns[3].Width = 125; // ServicePrice
            dgvServices.Columns[4].Width = 100; // CategoryID
            dgvServices.Columns[5].Width = 100; // TechnicianID

            // Set column alignment
            dgvServices.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServices.Columns["Category"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServices.Columns["Technician"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Format Price column as currency and set its text color
            dgvServices.Columns["Price"].DefaultCellStyle.Format = "N2"; // Currency format
            dgvServices.Columns["Price"].DefaultCellStyle.ForeColor = Color.FromArgb(85, 250, 190); // Set color

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int firstcell = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value); //Get the service ID of the selected row
            Service service = context.Services.Single(x => x.ServiceId == firstcell);
            int SelectedCategoryID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[4].Value); //Get the CategoryID of the selected row

            if (Global.HomeCareUser.UserId != Convert.ToInt32(context.Categories.Where(x => x.CategoryId == SelectedCategoryID).FirstOrDefault().ManagerId.ToString())
                && Global.HomeCareUser.UserRole != "Admin") //If the user is not the manager of the category
            {
                MessageBox.Show("the Service your trying to Delete is assigned to another manager");
                return;
            }

            //Validating delete
            if (MessageBox.Show("Are you sure you want to delete service (" + firstcell + ")", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Services.Remove(service);
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully. ");
                    Logger("Service Deleted"); //Logging action to database
                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when trying to delete service: {ex.InnerException?.Message}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Open the dialogue to add a new service
            servicesDialogue frmservicedialouge = new servicesDialogue();
            frmservicedialouge.ShowDialog();
            if (frmservicedialouge.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Added successfully.");
                Logger("Service Added");
                RefreshGridView(); //refresh only if the user added a new record
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int SelectedServiceID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value); //Get the serviceID of the selected row
                int SelectedCategoryID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[4].Value); //Get the CategoryID of the selected row
                servicesDialogue frmServiceEdit = new servicesDialogue(SelectedServiceID);

                if (Global.HomeCareUser.UserId != Convert.ToInt32(context.Categories.Where(x => x.CategoryId == SelectedCategoryID).FirstOrDefault().ManagerId.ToString()) 
                    && Global.HomeCareUser.UserRole != "Admin") //If the user is not the manager of the category
                {
                    MessageBox.Show("the Service your trying to update is assigned to another manager");
                    return;
                }
                else
                {
                    frmServiceEdit.ShowDialog();
                }

                if (frmServiceEdit.DialogResult == DialogResult.OK) //give feedback to the use if update is successful
                {
                    Logger("Service Updated");
                    RefreshGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when updating: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) //Filter functionlity is integrated into the RefreshGridView function
        {
            RefreshGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset the filters and DataGridView
            txtServiceID.Text = "";
            ddlTechnician.SelectedItem = null;
            ddlCategory.SelectedItem = null;
            RefreshGridView();
        }
        private void Logger(string Message) //Logging to database function
        {

            try
            {
                Log log = new Log();
                log.Message = Message;
                log.Source = "Desktop App";
                log.DateTime = DateTime.Now;
                log.UserId = Global.HomeCareUser.UserId;
                log.Type = "N/A";
                log.OriginalValues = "N/A";
                log.CurrentValues = "N/A";

                context.Logs.Add(log);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
