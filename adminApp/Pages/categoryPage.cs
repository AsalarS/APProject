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


namespace AdminApp.Pages
{
    public partial class categoryPage : Form
    {
        HomeCareDBContext context;
        public categoryPage()
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
        }
        private void RefreshGridView()
        {
            
            
            dgvCategory.DataSource = null;
            var categoriesToShow = context.Categories.AsQueryable();
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int  firstcell = Convert.ToInt32(dgvCategory.SelectedCells[0].OwningRow.Cells[0].Value);
            Category category = context.Categories.Single(x => x.CategoryId == firstcell);

           if (MessageBox.Show("Are you sure you want to delete category (" + firstcell + ")", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Categories.Remove(category);

                    context.SaveChanges();

                    MessageBox.Show("Added successfully. ");

                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                    MessageBox.Show($"Error: {ex.InnerException?.Message}");
                }
            }
        }


    }
}
