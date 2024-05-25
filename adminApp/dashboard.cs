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

        // State trackers for button active states
        private bool isDashboardActive = true;
        private bool isServicesActive = false;
        private bool isCategoryActive = false;
        private bool isLogsActive = false;

        public dashboard()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Default Page
            showScreen(new DashboardPage());
            // Set active state
            SetActiveButtonState(dashboardBtn);
            // Update images and colors
            UpdateButtonStyles();

            if (ProjectFormApp.Global.HomeCareUser != null)
            {
                label2.Text = Global.HomeCareUser.FullName;
            }
            else
            {
                label2.Text = "User not set";
            }
            //this is to hide logs from managers
            if (Global.HomeCareUser.UserRole == "Manager")
            {
                logsBtn.Enabled = false;
                logsBtn.Hide();

                
            }
        }

        // Visual Elements

        // Dashboard Button
        private void dashboardBtn_MouseEnter(object sender, EventArgs e)
        {
            if (!isDashboardActive)
            {
                hoverText(dashboardBtn, Color.White);
            }
        }

        private void dashboardBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!isDashboardActive)
            {
                hoverText(dashboardBtn, Color.FromArgb(131, 140, 163));
            }
        }

        // Services Button
        private void servicesBtn_MouseEnter(object sender, EventArgs e)
        {
            if (!isServicesActive)
            {
                hoverText(servicesBtn, Color.White);
            }
        }

        private void servicesBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!isServicesActive)
            {
                hoverText(servicesBtn, Color.FromArgb(131, 140, 163));
            }
        }

        // Category Button
        private void categoryBtn_MouseEnter(object sender, EventArgs e)
        {
            if (!isCategoryActive)
            {
                hoverText(categoryBtn, Color.White);
            }
        }

        private void categoryBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!isCategoryActive)
            {
                hoverText(categoryBtn, Color.FromArgb(131, 140, 163));
            }
        }

        // Logs Button
        private void logsBtn_MouseEnter(object sender, EventArgs e)
        {
            if (!isLogsActive)
            {
                hoverText(logsBtn, Color.White);
            }
        }

        private void logsBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!isLogsActive)
            {
                hoverText(logsBtn, Color.FromArgb(131, 140, 163));
            }
        }

        // Logout Button
        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverText(logoutBtn, Color.White);
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverText(logoutBtn, Color.FromArgb(131, 140, 163));
        }

        private void hoverText(Button btn, Color clr)
        {
            btn.ForeColor = clr;
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            showScreen(new logsPage());

            // Set active state
            SetActiveButtonState(logsBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            showScreen(new DashboardPage());

            // Set active state
            SetActiveButtonState(dashboardBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            showScreen(new servicesPage());

            // Set active state
            SetActiveButtonState(servicesBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            showScreen(new categoryPage());

            // Set active state
            SetActiveButtonState(categoryBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void SetActiveButtonState(Button activeButton)
        {
            isDashboardActive = activeButton == dashboardBtn;
            isServicesActive = activeButton == servicesBtn;
            isCategoryActive = activeButton == categoryBtn;
            isLogsActive = activeButton == logsBtn;
        }

        private void UpdateButtonStyles()
        {
            // Dashboard button
            dashboardBtn.ForeColor = isDashboardActive ? Color.White : Color.FromArgb(131, 140, 163);
            dashboardBtn.Image = isDashboardActive ? Properties.Resources.menu_white : Properties.Resources.menu_32px;

            // Services button
            servicesBtn.ForeColor = isServicesActive ? Color.White : Color.FromArgb(131, 140, 163);
            servicesBtn.Image = isServicesActive ? Properties.Resources.whire_repair_tool : Properties.Resources.repair_tool;

            // Category button
            categoryBtn.ForeColor = isCategoryActive ? Color.White : Color.FromArgb(131, 140, 163);
            categoryBtn.Image = isCategoryActive ? Properties.Resources.white_options_lines : Properties.Resources.options_lines;

            // Logs button
            logsBtn.ForeColor = isLogsActive ? Color.White : Color.FromArgb(131, 140, 163);
            logsBtn.Image = isLogsActive ? Properties.Resources.white_edit : Properties.Resources.edit;
        }

        private void goToPage(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Clear out everything in Global class
            Global.User = null;
            Global.RoleName = null;
            Global.AllAdmins = null;
            Global.AllUsers = null;
            Global.AllManagers = null;
            Global.AllTechnicicans = null;
            Global.HomeCareUser = null;
            goToPage(new Login());
        }

        public void showScreen(object Form) // Change Panel To Form
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

        private void bellBtn_Click(object sender, EventArgs e)
        {
            //TODO: Implement bell button click
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Implementation for label2 click
        }
    }
}
