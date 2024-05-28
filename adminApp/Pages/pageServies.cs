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
                    Logger("Service Deleted");
                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when trying to delete: {ex.InnerException?.Message}");
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
                Logger("Service Added");
                RefreshGridView(); //refresh only if the user added a new record
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int SelectedServiceID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value);
                int SelectedCategoryID = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[4].Value);
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
                    Logger("Service Updated");
                    RefreshGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when updating: " + ex.Message);
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
        private void Logger(string Message)
        {

            try
            {
                Log log = new Log();
                log.Message = Message;
                log.Source = "Desktop App";
                log.DateTime = DateTime.Now;
                log.UserId = Global.HomeCareUser.UserId;
                log.ExceptionType = "N/A";
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
