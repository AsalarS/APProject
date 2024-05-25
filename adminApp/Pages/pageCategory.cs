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
            //this is to change the text color
            this.ForeColor = Color.Black;

            if (Global.HomeCareUser.UserRole == "Manager")
            {
                btnAdd.Enabled = false;
                btnAdd.Hide();

                btnDelete.Enabled = false;
                btnDelete.Hide();

                btnUpdate.Enabled = false;
                btnUpdate.Hide();
            }
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
                categoryID = o.CategoryId,
                CategoryName = o.CategoryName,
                Description = o.Description,
                ManagerID = o.ManagerId,
            }).ToList();




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            categoryDialogue frmcategoryAdd = new categoryDialogue();
            frmcategoryAdd.ShowDialog();
            if (frmcategoryAdd.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Added successfully."); //Show feedback to the user
                RefreshGridView(); //refresh only if the user added a new record
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int firstcell = Convert.ToInt32(dgvCategory.SelectedCells[0].OwningRow.Cells[0].Value);
            Category category = context.Categories.Single(x => x.CategoryId == firstcell);

            if (MessageBox.Show("Are you sure you want to delete category (" + firstcell + ")", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Categories.Remove(category);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int SelectedCategoryID = Convert.ToInt32(dgvCategory.SelectedCells[0].OwningRow.Cells[0].Value);
                categoryDialogue frmCategoryEdit = new categoryDialogue(SelectedCategoryID);
                frmCategoryEdit.ShowDialog();

                if (frmCategoryEdit.DialogResult == DialogResult.OK)
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
            txtCategoryID.Text = "";
            ddlManager.SelectedItem = null;
            RefreshGridView();
        }
    }
}
