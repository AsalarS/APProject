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

        // Properties for the User Control
        //Each one is assigned to its label
        #region Properties

        private String _technicianName;
        private String _totalRequests;
        private String _completedRequest;

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

        public String completedRequests
        {
            get { return _completedRequest; }
            set { _completedRequest = value; txtCompletedRequests.Text = value; }
        }

        #endregion

    }
}
