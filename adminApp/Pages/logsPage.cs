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
    public partial class logsPage : Form
    {
        HomeCareDBContext context;

        public logsPage()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void logsPage_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            this.dgvLogs.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvLogs.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void RefreshGridView()
        {
            dgvLogs.DataSource = null;

            var LogsToShow = context.Logs.AsQueryable();

            dgvLogs.DataSource = LogsToShow.OrderByDescending(m => m.DateTime).Select(o => new
            {
                Source = o.Source,
                ExeptionType = o.ExceptionType,
                Date = o.DateTime.ToString(),
                Message = o.Message,
                OriginalValues = o.OriginalValues,
                CurrentValue = o.CurrentValues,

                UserID = o.UserId,

            }).ToList();

        }

        private void dgvLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
