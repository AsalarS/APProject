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
        }
        private void RefreshGridView()
        {
            try
            {
                dgvCategory.DataSource = null;
                var categoriesToShow = context.Categories.AsQueryable();

            }
            catch (Exception ex)
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int  firstcell = Convert.ToInt32(dgvCategory.SelectedCells[0].OwningRow.Cells[0].Value);
            Category category = context.Categories.Single(x => x.CategoryId == firstcell);

           if (MessageBox.Show("Are you sure you want to delete order (" + firstcell + ") & its details?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var alldet = context.Categories
                }
            }
        }
    }
}
