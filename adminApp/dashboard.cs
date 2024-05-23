using adminApp;
using AdminApp.Pages;
using HomeCareObjects.Model;
using ProjectFormApp;

namespace AdminApp
{
    public partial class dashboard : Form
    {
        HomeCareDBContext context;
        FormsIdentityContext IdentityContext = new FormsIdentityContext();

        public dashboard()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ProjectFormApp.Global.HomeCareUser != null)
            {

                label2.Text = Global.HomeCareUser.FullName;
            }
            else
            {
                label2.Text = "User not set";
            }
        }

        //VISUAL ELEMENTS

        // Dahsboard Button
        private void dashboardBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverText(dashboardBtn, Color.White);
        }

        private void dashboardBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverText(dashboardBtn, Color.FromArgb(131, 140, 163));
        }
        //Services Button
        private void servicesBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverText(servicesBtn, Color.White);
        }

        private void servicesBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverText(servicesBtn, Color.FromArgb(131, 140, 163));
        }
        //Category Button
        private void categoryBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverText(categoryBtn, Color.White);
        }

        private void categoryBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverText(categoryBtn, Color.FromArgb(131, 140, 163));
        }
        //Logs Button
        private void logsBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverText(logsBtn, Color.White);
        }

        private void logsBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverText(logsBtn, Color.FromArgb(131, 140, 163));
        }
        //Logout Button
        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverText(logoutBtn, Color.White);
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverText(logoutBtn, Color.FromArgb(131, 140, 163));
        }
        //Bell Button
        private void bellBtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bellBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void hoverText(Button btn, Color clr)
        {
            btn.ForeColor = clr;
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            showScreen(new logsPage());
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            showScreen(new DashboardPage());
        }

        private void goToPage(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //clear out everything in Global class
            Global.User = null;
            Global.RoleName = null;
            Global.AllAdmins = null;
            Global.AllUsers = null;
            Global.AllManagers = null;
            Global.AllTechnicicans = null;
            goToPage(new Login());
        }

        public void showScreen(object Form) //Change Panel To Form
        {
            if (this.mainScreen.Controls.Count > 0)
                this.mainScreen.Controls.RemoveAt(0);
            Form? f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainScreen.Controls.Add(f);
            this.mainScreen.Tag = f;
            f.Show();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            showScreen(new servicesPage());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            showScreen(new categoryPage());
        }

        private void bellBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
