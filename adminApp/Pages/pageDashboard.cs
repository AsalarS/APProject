using adminApp.CustomRows;
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
    public partial class pageDashboard : Form
    {
        HomeCareDBContext context;
        FormsIdentityContext formsIdentityContext;
        public pageDashboard()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            formsIdentityContext = new FormsIdentityContext();

        }

        private void RefreshData() 
        {
            // Get the selected category ID from the dropdown
            int selectedCategoryId = (int)ddlCategory.SelectedValue;

            // Fetch the technicians who have services in the selected category
            var technicians = context.Users
                                     .Where(x => x.UserRole == "Technician")
                                     .Where(x => context.ServiceRequests
                                                       .Where(sr => sr.Service.CategoryId == selectedCategoryId)
                                                       .Select(sr => sr.TechnicianId)
                                                       .Contains(x.UserId))
                                     .ToList();

            flpTechnicianData.Controls.Clear(); // Clear existing controls
            flpTechnicianData.Refresh();
         
            foreach (var technician in technicians)
            {
                UCTechnician row = new UCTechnician();
                row.technicianName = technician.FullName;
                row.totalRequests = context.ServiceRequests
                                            .Where(x => x.TechnicianId == technician.UserId && x.Service.CategoryId == selectedCategoryId)
                                            .Count()
                                            .ToString();
                row.failedRequests = context.ServiceRequests
                                             .Where(x => x.TechnicianId == technician.UserId
                                                     && x.RequestDate > x.DateNeeded
                                                     && x.Service.CategoryId == selectedCategoryId)
                                             .Count()
                                             .ToString();
                flpTechnicianData.Controls.Add(row);
            }

            // Pending Requests
            lblPendingRequests.Text = context.ServiceRequests
                                              .Where(x => x.RequestStatus == 1)
                                              .Count()
                                              .ToString();
            // Completed Requests
            lblCompletedRequests.Text = context.ServiceRequests
                                            .Where(x => x.RequestStatus == 3)
                                            .Count()
                                            .ToString();
            // Active Requests
            lblActiveRequests.Text = context.ServiceRequests
                                            .Where(x => x.RequestStatus == 2)
                                            .Count()
                                            .ToString();
            //Top Service
            var topServiceId = context.ServiceRequests
                                      .GroupBy(x => x.ServiceId)
                                      .OrderByDescending(x => x.Count())
                                      .Select(x => x.Key)
                                      .FirstOrDefault();

            var topServiceName = context.Services
                                        .Where(s => s.ServiceId == topServiceId)
                                        .Select(s => s.ServiceName)
                                        .FirstOrDefault();

            lblTopService.Text = topServiceName;
            //Number of services
            lblNumberOfServices.Text = context.ServiceRequests.Where(x => x.Service.CategoryId == selectedCategoryId)
                                            .Count()
                                            .ToString();
            //Number of technicians
            lblNumberOfTechnicians.Text = technicians
                                            .Count()
                                            .ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryId";

            RefreshData();
        }

        private void ddlManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
