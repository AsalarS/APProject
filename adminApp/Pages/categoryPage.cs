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
            dataGridView1.DataSource = context.Users.ToList();
            
        }
    }
}
