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

namespace AdminApp
{
    public partial class servicesPage : Form
    {
        HomeCareDBContext context;
        public servicesPage()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void servicesPage_Load(object sender, EventArgs e)
        {
            //this is to change the text color
            this.ForeColor = Color.Black;
            RefreshGridView();
        }

        private void RefreshGridView()
        {


            dgvServices.DataSource = null;
            var servicesToShow = context.Services.AsQueryable();
            dgvServices.DataSource = servicesToShow.OrderByDescending(m => m.ServiceId).Select(o => new
            {

                ServiceID = o.ServiceId,
                ServiceName = o.ServiceName,
                ServiceDescription = o.ServiceDescription,
                ServicePrice = o.ServicePrice,
                categoryID = o.CategoryId,
                TechnicianID = o.TechnicianId,

            }).ToList();




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int firstcell = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value);
            Service service = context.Services.Single(x => x.ServiceId == firstcell);

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
    }
}
