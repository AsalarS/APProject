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

namespace adminApp.Pages
{
    public partial class pageComments : Form
    {
        HomeCareDBContext context;
        public pageComments()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void pageComments_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            dgvComments.DataSource = null;

            var LogsToShow = context.Comments.AsQueryable();

            dgvComments.DataSource = LogsToShow.OrderByDescending(m => m.CommentDate).Select(o => new
            {
                CommentText = o.CommentText,
                CommentDate = o.CommentDate.ToString(),
                CommentTime = o.CommentDate.ToString(),
                UserID = o.UserId,
                ServiceRequestID = o.RequestId

            }).ToList();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
