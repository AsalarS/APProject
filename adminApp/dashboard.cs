using adminApp;
using adminApp.Pages;
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
        private bool isCommentsActive = false;

        public dashboard()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Default Page
                showScreen(new pageDashboard());
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
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // <---------------------------- Visual Elements ---------------------------->

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

        // Comments Button
        private void btnComments_MouseEnter(object sender, EventArgs e)
        {
            if (!isCommentsActive)
            {
                hoverText(btnComments, Color.White);
            }
        }

        private void btnComments_MouseLeave(object sender, EventArgs e)
        {
            if (!isCommentsActive)
            {
                hoverText(btnComments, Color.FromArgb(131, 140, 163));
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
            showScreen(new pageLogs());

            // Set active state
            SetActiveButtonState(logsBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            showScreen(new pageDashboard());

            // Set active state
            SetActiveButtonState(dashboardBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            showScreen(new pageServies());

            // Set active state
            SetActiveButtonState(servicesBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            showScreen(new pageCategory());

            // Set active state
            SetActiveButtonState(categoryBtn);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            showScreen(new pageComments());

            // Set active state
            SetActiveButtonState(btnComments);

            // Update images and colors
            UpdateButtonStyles();
        }

        private void SetActiveButtonState(Button activeButton) // Set the active button state
        {
            isDashboardActive = activeButton == dashboardBtn;
            isServicesActive = activeButton == servicesBtn;
            isCategoryActive = activeButton == categoryBtn;
            isLogsActive = activeButton == logsBtn;
            isCommentsActive = activeButton == btnComments;
        }

        private void UpdateButtonStyles()
        {
            // Dashboard button
            dashboardBtn.ForeColor = isDashboardActive ? Color.White : Color.FromArgb(131, 140, 163);
            dashboardBtn.Image = isDashboardActive ? adminApp.Properties.Resources.menu_white : adminApp.Properties.Resources.menu_32px;

            // Services button
            servicesBtn.ForeColor = isServicesActive ? Color.White : Color.FromArgb(131, 140, 163);
            servicesBtn.Image = isServicesActive ? adminApp.Properties.Resources.whire_repair_tool : adminApp.Properties.Resources.repair_tool;

            // Category button
            categoryBtn.ForeColor = isCategoryActive ? Color.White : Color.FromArgb(131, 140, 163);
            categoryBtn.Image = isCategoryActive ? adminApp.Properties.Resources.white_options_lines : adminApp.Properties.Resources.options_lines;

            // Logs button
            logsBtn.ForeColor = isLogsActive ? Color.White : Color.FromArgb(131, 140, 163);
            logsBtn.Image = isLogsActive ? adminApp.Properties.Resources.white_editNEW : adminApp.Properties.Resources.editNEW;

            // Comments button
            btnComments.ForeColor = isCommentsActive ? Color.White : Color.FromArgb(131, 140, 163);
            btnComments.Image = isCommentsActive ? adminApp.Properties.Resources.WhiteComment : adminApp.Properties.Resources.comment;
        }

        private void goToPage(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e) //logout and clear all global variables
        {
            // Clear out everything in Global class
            Global.User = null;
            Global.RoleName = null;
            Global.AllAdmins = null;
            Global.AllUsers = null;
            Global.AllManagers = null;
            Global.AllTechnicians = null;
            Global.HomeCareUser = null;
            goToPage(new Login());
        }

        public void showScreen(object Form) // Change the forms showing in the panel to navigate the application
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

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
