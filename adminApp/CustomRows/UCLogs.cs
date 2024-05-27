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
    public partial class UCLogs : UserControl
    {
        public UCLogs()
        {
            InitializeComponent();
        }

        #region Properties

        private String _logMessage;
        private String _source;
        private String _userName;
        private String _date;
        private String _time;

        [Category("Custom Property")]
        public String logMessage
        {
            get { return _logMessage; }
            set { _logMessage = value; lblMessage.Text = value; }
        }

        public String source
        {
            get { return _source; }
            set { _source = value; lblSource.Text = value; }
        }

        public String userName
        {
            get { return _userName; }
            set { _userName = value; lblFullName.Text = value; }
        }

        public String date
        {
        get { return _date; }
        set { _date = value; lblDate.Text = value; }
        }

        public String time
        {
            get { return _time; }
            set { _time = value; lblTime.Text = value; }
        }

        #endregion
    }
}
