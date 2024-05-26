using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminApp.CustomRows
{
    public partial class UCTechnician : UserControl
    {
        public UCTechnician()
        {
            InitializeComponent();
        }

        #region Properties

        private String _technicianName;
        private String _totalRequests;
        private String _failedRequests;

        [Category("Custom Property")]
        public String technicianName
        {
            get { return _technicianName; }
            set { _technicianName = value; txtTechnicianName.Text = value; }
        }

        public String totalRequests
        {
            get { return _totalRequests; }
            set { _totalRequests = value; txtTotalRequests.Text = value; }
        }

        public String failedRequests
        {
            get { return _failedRequests; }
            set { _failedRequests = value; txtFailedRequests.Text = value; }
        }

        #endregion

    }
}
