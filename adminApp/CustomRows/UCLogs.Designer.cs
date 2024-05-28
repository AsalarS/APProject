namespace adminApp.CustomRows
{
    partial class UCLogs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            lblFullName = new Label();
            lblSource = new Label();
            lblMessage = new Label();
            toolTipUserID = new ToolTip(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(22, 22, 44);
            panel1.Location = new Point(3, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 2);
            panel1.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(85, 250, 190);
            lblTime.Location = new Point(742, 59);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(54, 17);
            lblTime.TabIndex = 12;
            lblTime.Text = "12:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(85, 250, 190);
            lblDate.Location = new Point(731, 21);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(61, 17);
            lblDate.TabIndex = 11;
            lblDate.Text = "9/11/2001";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.FromArgb(131, 140, 163);
            lblFullName.ImageAlign = ContentAlignment.MiddleRight;
            lblFullName.Location = new Point(529, 33);
            lblFullName.MaximumSize = new Size(200, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(168, 25);
            lblFullName.TabIndex = 13;
            lblFullName.Text = "John Mohammed Doe";
            toolTipUserID.SetToolTip(lblFullName, "UserID");
            // 
            // lblSource
            // 
            lblSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSource.ForeColor = Color.FromArgb(131, 140, 163);
            lblSource.Location = new Point(397, 33);
            lblSource.MaximumSize = new Size(200, 25);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(81, 25);
            lblSource.TabIndex = 14;
            lblSource.Text = "Website";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(27, 27);
            lblMessage.MaximumSize = new Size(350, 40);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(129, 40);
            lblMessage.TabIndex = 16;
            lblMessage.Text = "Message";
            // 
            // toolTipUserID
            // 
            toolTipUserID.BackColor = Color.FromArgb(50, 50, 77);
            toolTipUserID.ForeColor = Color.White;
            toolTipUserID.ToolTipTitle = "User ID";
            // 
            // UCLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            Controls.Add(lblMessage);
            Controls.Add(lblSource);
            Controls.Add(lblFullName);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(panel1);
            Name = "UCLogs";
            Size = new Size(820, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTime;
        private Label lblDate;
        private Label lblFullName;
        private Label lblSource;
        private Label lblMessage;
        private ToolTip toolTipUserID;
    }
}
