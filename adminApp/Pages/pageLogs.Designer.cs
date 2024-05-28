namespace AdminApp.Pages
{
    partial class pageLogs
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
            flpLogs = new FlowLayoutPanel();
            panel1 = new Panel();
            lblDateTime = new Label();
            lblUser = new Label();
            lblSource = new Label();
            lblMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpLogs
            // 
            flpLogs.FlowDirection = FlowDirection.TopDown;
            flpLogs.Location = new Point(12, 43);
            flpLogs.Name = "flpLogs";
            flpLogs.Size = new Size(834, 556);
            flpLogs.TabIndex = 1;
            flpLogs.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 15, 36);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblSource);
            panel1.Controls.Add(lblMessage);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 37);
            panel1.TabIndex = 3;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateTime.ForeColor = Color.FromArgb(131, 140, 163);
            lblDateTime.Location = new Point(755, 9);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(82, 17);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "Date & Time";
            lblDateTime.UseMnemonic = false;
            lblDateTime.Click += lblDateTime_Click;
            lblDateTime.MouseEnter += lblDateTime_MouseEnter;
            lblDateTime.MouseLeave += lblDateTime_MouseLeave;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(131, 140, 163);
            lblUser.Location = new Point(583, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(35, 17);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            lblUser.Click += lblUser_Click;
            lblUser.MouseEnter += lblUser_MouseEnter;
            lblUser.MouseLeave += lblUser_MouseLeave;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSource.ForeColor = Color.FromArgb(131, 140, 163);
            lblSource.Location = new Point(436, 9);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(49, 17);
            lblSource.TabIndex = 1;
            lblSource.Text = "Source";
            lblSource.Click += lblSource_Click;
            lblSource.MouseEnter += lblSource_MouseEnter;
            lblSource.MouseLeave += lblSource_MouseLeave;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.FromArgb(131, 140, 163);
            lblMessage.Location = new Point(151, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(61, 17);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            // 
            // pageLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(panel1);
            Controls.Add(flpLogs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pageLogs";
            Text = "logsPage";
            Load += logsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpLogs;
        private Panel panel1;
        private Label lblDateTime;
        private Label lblUser;
        private Label lblSource;
        private Label lblMessage;
    }
}