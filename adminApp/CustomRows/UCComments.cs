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
    public partial class UCComments : UserControl
    {
        public UCComments()
        {
            InitializeComponent();
        }

        private void UCComments_Load(object sender, EventArgs e)
        {

        }

        #region Properties

        private String _comment;
        private String _serviceName;
        private String _serviceId;
        private String _userName;
        private String _userId;
        private String _category;
        private String _categoryId;
        private String _date;
        private String _time;

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        [Category("Custom Property")]
        public String Comment
        {
            get { return _comment; }
            set { _comment = value; rtbText.Text = value; }
        }

        public String ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; lblServiceName.Text = value; }
        }

        public String ServiceId
        {
            get { return _serviceId; }
            set { _serviceId = value; toolTipServiceID.SetToolTip(lblServiceName, value); }
        }

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; lblUserName.Text = value; }
        }
        public String UserId
        {
            get { return _userId; }
            set { _userId = value; toolTipUserID.SetToolTip(lblUserName, value); }
        }

        public String Category
        {
            get { return _category; }
            set { _category = value; lblCategory.Text = value; }
        }

        public String CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; toolTipCategoryID.SetToolTip(lblCategory, value); }
        }

        public String Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = value; }
        }
        public String Time
        {
            get { return _time; }
            set { _time = value; lblTime.Text = value; }
        }

        #endregion
    }
}
