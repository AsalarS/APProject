namespace AdminApp
{
    partial class pageDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPendingRequests = new Label();
            label2 = new Label();
            lblCompletedRequests = new Label();
            label4 = new Label();
            lblOverdueRequests = new Label();
            label6 = new Label();
            label13 = new Label();
            label8 = new Label();
            label7 = new Label();
            pnlTechnicianData = new FlowLayoutPanel();
            label10 = new Label();
            lblNumberOfServices = new Label();
            lblTopService = new Label();
            label12 = new Label();
            btnRefresh = new Button();
            ddlCategory = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            lblNumberOfTechnicians = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPendingRequests.ForeColor = Color.White;
            lblPendingRequests.Location = new Point(172, 13);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(37, 45);
            lblPendingRequests.TabIndex = 2;
            lblPendingRequests.Text = "0";
            lblPendingRequests.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 27);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Pending Requests";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletedRequests
            // 
            lblCompletedRequests.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCompletedRequests.AutoSize = true;
            lblCompletedRequests.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompletedRequests.ForeColor = Color.White;
            lblCompletedRequests.Location = new Point(179, 13);
            lblCompletedRequests.Name = "lblCompletedRequests";
            lblCompletedRequests.Size = new Size(37, 45);
            lblCompletedRequests.TabIndex = 5;
            lblCompletedRequests.Text = "0";
            lblCompletedRequests.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 4;
            label4.Text = "Completed Requests";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOverdueRequests
            // 
            lblOverdueRequests.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblOverdueRequests.AutoSize = true;
            lblOverdueRequests.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverdueRequests.ForeColor = Color.White;
            lblOverdueRequests.Location = new Point(176, 13);
            lblOverdueRequests.Name = "lblOverdueRequests";
            lblOverdueRequests.Size = new Size(37, 45);
            lblOverdueRequests.TabIndex = 8;
            lblOverdueRequests.Text = "0";
            lblOverdueRequests.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 27);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 7;
            label6.Text = "Overdue Requests";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(131, 140, 163);
            label13.Location = new Point(99, 247);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 3;
            label13.Text = "Technician";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(131, 140, 163);
            label8.Location = new Point(471, 247);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 2;
            label8.Text = "Failed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(131, 140, 163);
            label7.Location = new Point(387, 247);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 1;
            label7.Text = "Total";
            // 
            // pnlTechnicianData
            // 
            pnlTechnicianData.Location = new Point(55, 265);
            pnlTechnicianData.Name = "pnlTechnicianData";
            pnlTechnicianData.Size = new Size(495, 297);
            pnlTechnicianData.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(14, 27);
            label10.Name = "label10";
            label10.Size = new Size(144, 20);
            label10.TabIndex = 18;
            label10.Text = "Number of Services";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfServices
            // 
            lblNumberOfServices.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNumberOfServices.AutoSize = true;
            lblNumberOfServices.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfServices.ForeColor = Color.White;
            lblNumberOfServices.Location = new Point(194, 19);
            lblNumberOfServices.Name = "lblNumberOfServices";
            lblNumberOfServices.Size = new Size(24, 30);
            lblNumberOfServices.TabIndex = 14;
            lblNumberOfServices.Text = "0";
            lblNumberOfServices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopService
            // 
            lblTopService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTopService.AutoSize = true;
            lblTopService.ForeColor = Color.White;
            lblTopService.Location = new Point(129, 30);
            lblTopService.Name = "lblTopService";
            lblTopService.Size = new Size(29, 15);
            lblTopService.TabIndex = 17;
            lblTopService.Text = "N/A";
            lblTopService.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(14, 26);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 16;
            label12.Text = "Top Service";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(13, 13, 37);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(700, 193);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 31);
            btnRefresh.TabIndex = 22;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ddlCategory
            // 
            ddlCategory.BackColor = Color.FromArgb(50, 50, 77);
            ddlCategory.FlatStyle = FlatStyle.Flat;
            ddlCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ddlCategory.ForeColor = Color.White;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(432, 194);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(246, 29);
            ddlCategory.TabIndex = 23;
            ddlCategory.SelectedIndexChanged += ddlManager_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 24;
            label1.Text = "General";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 13, 37);
            panel1.Controls.Add(lblPendingRequests);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(52, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 71);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 13, 37);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblCompletedRequests);
            panel2.Location = new Point(310, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 71);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(13, 13, 37);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblOverdueRequests);
            panel3.Location = new Point(578, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 71);
            panel3.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 189);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 28;
            label3.Text = "Category";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(13, 13, 37);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblTopService);
            panel4.Location = new Point(578, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 71);
            panel4.TabIndex = 28;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(13, 13, 37);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(lblNumberOfServices);
            panel5.Location = new Point(578, 375);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 71);
            panel5.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(13, 13, 37);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(lblNumberOfTechnicians);
            panel6.Location = new Point(578, 491);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 71);
            panel6.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 28);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 18;
            label5.Text = "Number of Technicians";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfTechnicians
            // 
            lblNumberOfTechnicians.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNumberOfTechnicians.AutoSize = true;
            lblNumberOfTechnicians.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfTechnicians.ForeColor = Color.White;
            lblNumberOfTechnicians.Location = new Point(194, 24);
            lblNumberOfTechnicians.Name = "lblNumberOfTechnicians";
            lblNumberOfTechnicians.Size = new Size(24, 30);
            lblNumberOfTechnicians.TabIndex = 14;
            lblNumberOfTechnicians.Text = "0";
            lblNumberOfTechnicians.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pnlTechnicianData);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(ddlCategory);
            Controls.Add(btnRefresh);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardPage";
            Text = "DashboardPage";
            Load += DashboardPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPendingRequests;
        private Label label2;
        private Label lblCompletedRequests;
        private Label label4;
        private Label lblOverdueRequests;
        private Label label6;
        private Label lblNumberOfServices;
        private Label lblTopService;
        private Button btnRefresh;
        private ComboBox ddlCategory;
        private FlowLayoutPanel pnlTechnicianData;
        private Label label7;
        private Label label8;
        private Label label13;
        private Label label10;
        private Label label12;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label5;
        private Label lblNumberOfTechnicians;
    }
}