namespace AdminApp
{
    partial class dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            mainScreen = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            servicesBtn = new Button();
            categoryBtn = new Button();
            logsBtn = new Button();
            logoutBtn = new Button();
            dashboardBtn = new Button();
            btnComments = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 44);
            panel1.Location = new Point(202, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 545);
            panel1.TabIndex = 0;
            // 
            // mainScreen
            // 
            mainScreen.Dock = DockStyle.Right;
            mainScreen.Location = new Point(206, 0);
            mainScreen.Name = "mainScreen";
            mainScreen.Size = new Size(858, 611);
            mainScreen.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 82);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 34);
            label2.MaximumSize = new Size(204, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 40);
            label2.TabIndex = 1;
            label2.Text = "John Doe";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(131, 140, 163);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            // 
            // servicesBtn
            // 
            servicesBtn.BackColor = Color.Transparent;
            servicesBtn.FlatAppearance.BorderSize = 0;
            servicesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 37);
            servicesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 24);
            servicesBtn.FlatStyle = FlatStyle.Flat;
            servicesBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            servicesBtn.ForeColor = Color.FromArgb(131, 140, 163);
            servicesBtn.Image = (Image)resources.GetObject("servicesBtn.Image");
            servicesBtn.Location = new Point(1, 145);
            servicesBtn.Name = "servicesBtn";
            servicesBtn.Size = new Size(204, 60);
            servicesBtn.TabIndex = 4;
            servicesBtn.Text = " Services";
            servicesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            servicesBtn.UseVisualStyleBackColor = false;
            servicesBtn.Click += servicesBtn_Click;
            servicesBtn.MouseEnter += servicesBtn_MouseEnter;
            servicesBtn.MouseLeave += servicesBtn_MouseLeave;
            // 
            // categoryBtn
            // 
            categoryBtn.BackColor = Color.Transparent;
            categoryBtn.FlatAppearance.BorderSize = 0;
            categoryBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 37);
            categoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 24);
            categoryBtn.FlatStyle = FlatStyle.Flat;
            categoryBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            categoryBtn.ForeColor = Color.FromArgb(131, 140, 163);
            categoryBtn.Image = (Image)resources.GetObject("categoryBtn.Image");
            categoryBtn.Location = new Point(1, 205);
            categoryBtn.Name = "categoryBtn";
            categoryBtn.Size = new Size(204, 60);
            categoryBtn.TabIndex = 5;
            categoryBtn.Text = " Category";
            categoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            categoryBtn.UseVisualStyleBackColor = false;
            categoryBtn.Click += categoryBtn_Click;
            categoryBtn.MouseEnter += categoryBtn_MouseEnter;
            categoryBtn.MouseLeave += categoryBtn_MouseLeave;
            // 
            // logsBtn
            // 
            logsBtn.BackColor = Color.Transparent;
            logsBtn.FlatAppearance.BorderSize = 0;
            logsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 37);
            logsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 24);
            logsBtn.FlatStyle = FlatStyle.Flat;
            logsBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logsBtn.ForeColor = Color.FromArgb(131, 140, 163);
            logsBtn.Image = adminApp.Properties.Resources.editNEW;
            logsBtn.Location = new Point(0, 330);
            logsBtn.Name = "logsBtn";
            logsBtn.Size = new Size(204, 60);
            logsBtn.TabIndex = 6;
            logsBtn.Text = " Logs";
            logsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logsBtn.UseVisualStyleBackColor = false;
            logsBtn.Click += logsBtn_Click;
            logsBtn.MouseEnter += logsBtn_MouseEnter;
            logsBtn.MouseLeave += logsBtn_MouseLeave;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 37);
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 24);
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.FromArgb(131, 140, 163);
            logoutBtn.Location = new Point(0, 536);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(206, 73);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            logoutBtn.MouseEnter += logoutBtn_MouseEnter;
            logoutBtn.MouseLeave += logoutBtn_MouseLeave;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.Transparent;
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 37);
            dashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 24);
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.FromArgb(131, 140, 163);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.Location = new Point(0, 79);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(204, 60);
            dashboardBtn.TabIndex = 9;
            dashboardBtn.Text = " Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            dashboardBtn.MouseEnter += dashboardBtn_MouseEnter;
            dashboardBtn.MouseLeave += dashboardBtn_MouseLeave;
            // 
            // btnComments
            // 
            btnComments.BackColor = Color.Transparent;
            btnComments.FlatAppearance.BorderSize = 0;
            btnComments.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 37);
            btnComments.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 24);
            btnComments.FlatStyle = FlatStyle.Flat;
            btnComments.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComments.ForeColor = Color.FromArgb(131, 140, 163);
            btnComments.Image = adminApp.Properties.Resources.comment;
            btnComments.Location = new Point(0, 267);
            btnComments.Name = "btnComments";
            btnComments.Size = new Size(204, 60);
            btnComments.TabIndex = 10;
            btnComments.Text = "Comments";
            btnComments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComments.UseVisualStyleBackColor = false;
            btnComments.Click += btnComments_Click;
            btnComments.MouseEnter += btnComments_MouseEnter;
            btnComments.MouseLeave += btnComments_MouseLeave;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(1064, 611);
            Controls.Add(panel1);
            Controls.Add(btnComments);
            Controls.Add(dashboardBtn);
            Controls.Add(logoutBtn);
            Controls.Add(logsBtn);
            Controls.Add(categoryBtn);
            Controls.Add(panel3);
            Controls.Add(mainScreen);
            Controls.Add(servicesBtn);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += dashboard_FormClosing;
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel mainScreen;
        private Panel panel3;
        private Button servicesBtn;
        private Button categoryBtn;
        private Button logsBtn;
        private Button logoutBtn;
        private Button dashboardBtn;
        private Label label1;
        private Label label2;
        private Button btnComments;
    }
}
