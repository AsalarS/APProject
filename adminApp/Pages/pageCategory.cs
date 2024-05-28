using adminApp.Popup;
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
using adminApp.Dialogue;

namespace AdminApp.Pages
{
    public partial class pageCategory : Form
    {
        HomeCareDBContext context;
        public pageCategory()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void categoryPage_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = context.Users.ToList();
            RefreshGridView();

            if (Global.HomeCareUser.UserRole == "Manager") //Hide the CRUD or Add, Delete, Update buttons if the user is not an Admin
            {
                btnAdd.Enabled = false;
                btnAdd.Hide();

                btnDelete.Enabled = false;
                btnDelete.Hide();

                btnUpdate.Enabled = false;
                btnUpdate.Hide();
            }

            //Populate the combobox
            ddlManager.DataSource = context.Users.Where(x => x.UserRole == "Manager").ToList();
            ddlManager.DisplayMember = "FullName";
            ddlManager.ValueMember = "UserID";
            ddlManager.SelectedItem = null;

        }
        private void RefreshGridView()
        {


            dgvCategory.DataSource = null;
            var categoriesToShow = context.Categories.AsQueryable();
            if (txtCategoryID.Text != "")
            {
                categoriesToShow = categoriesToShow
                    .Where(x => x.CategoryId == Convert.ToInt32(txtCategoryID.Text));
                //if order id is specified in the filters, get the order with that id
            }
            else if (ddlManager.SelectedValue != null)
            {
                categoriesToShow = categoriesToShow
                    .Where(x => x.ManagerId == Convert.ToInt32(ddlManager.SelectedValue.ToString()));
                //if customer is selected from the combobox, get orders of that customer
            }
            
            dgvCategory.DataSource = categoriesToShow.OrderByDescending(m => m.CategoryId).Select(o => new
            {
                ID = o.CategoryId,
                Name = o.CategoryName,
                Description = o.Description,
                Manager = o.ManagerId,
            }).ToList();

            // Set column headers style
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 13, 37);
            dgvCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategory.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCategory.Font.FontFamily, 10, FontStyle.Bold);
            dgvCategory.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 10, 10, 10);

            // Set column widths
            dgvCategory.Columns[0].Width = 50; // CategoryID
            dgvCategory.Columns[1].Width = 200; // CategoryName
            dgvCategory.Columns[2].Width = 300; // Description
            dgvCategory.Columns[3].Width = 100; // ManagerID

            // Set column alignment
            dgvCategory.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategory.Columns["Manager"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            categoryDialogue frmcategoryAdd = new categoryDialogue();
            frmcategoryAdd.ShowDialog();
            if (frmcategoryAdd.DialogResult == DialogResult.OK) //if category added successfully
            {
                MessageBox.Show("Added successfully."); //Show feedback to the user
                RefreshGridView(); //refresh only if the user added a new record
                Logger("Category Added");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int firstcell = Convert.ToInt32(dgvCategory.SelectedCells[0].OwningRow.Cells[0].Value); //Get the category ID of the selected row
            Category category = context.Categories.Single(x => x.CategoryId == firstcell);

            if (MessageBox.Show("Are you sure you want to delete category (" + firstcell + ")", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Categories.Remove(category);

                    context.SaveChanges();

                    MessageBox.Show("Deleted successfully. ");

                    Logger("Category Deleted");

                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.InnerException?.Message}");
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int SelectedCategoryID = Convert.ToInt32(dgvCategory.SelectedCells[0].OwningRow.Cells[0].Value); //Get the category ID of the selected row
                categoryDialogue frmCategoryEdit = new categoryDialogue(SelectedCategoryID);
                frmCategoryEdit.ShowDialog();

                if (frmCategoryEdit.DialogResult == DialogResult.OK) //if category updated successfully
                {
                    Logger("Category Updated");
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
            //Reset the filters
            txtCategoryID.Text = "";
            ddlManager.SelectedItem = null;
            RefreshGridView();
        }
        private void Logger(string Message) //Logging to database method
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
