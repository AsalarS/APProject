namespace adminApp.CustomRows
{
    partial class UCComments
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
            lblDate = new Label();
            lblCategory = new Label();
            lblServiceName = new Label();
            lblUserName = new Label();
            lblTime = new Label();
            rtbText = new RichTextBox();
            toolTipServiceID = new ToolTip(components);
            toolTipUserID = new ToolTip(components);
            toolTipCategoryID = new ToolTip(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(22, 22, 44);
            panel1.Location = new Point(3, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 2);
            panel1.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(85, 250, 190);
            lblDate.Location = new Point(738, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(61, 17);
            lblDate.TabIndex = 6;
            lblDate.Text = "9/11/2001";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.FromArgb(131, 140, 163);
            lblCategory.Location = new Point(627, 36);
            lblCategory.MaximumSize = new Size(100, 25);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 25);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Plumbing";
            // 
            // lblServiceName
            // 
            lblServiceName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblServiceName.AutoSize = true;
            lblServiceName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblServiceName.ForeColor = Color.FromArgb(131, 140, 163);
            lblServiceName.Location = new Point(339, 36);
            lblServiceName.MaximumSize = new Size(140, 25);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(135, 25);
            lblServiceName.TabIndex = 8;
            lblServiceName.Text = "Basic Cleaning";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.FromArgb(131, 140, 163);
            lblUserName.Location = new Point(489, 36);
            lblUserName.MaximumSize = new Size(130, 25);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(117, 25);
            lblUserName.TabIndex = 9;
            lblUserName.Text = "Jack Daniels";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(85, 250, 190);
            lblTime.Location = new Point(749, 61);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(54, 17);
            lblTime.TabIndex = 10;
            lblTime.Text = "12:00:00";
            lblTime.Click += lblTime_Click;
            // 
            // rtbText
            // 
            rtbText.BackColor = Color.FromArgb(0, 0, 24);
            rtbText.BorderStyle = BorderStyle.None;
            rtbText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbText.ForeColor = Color.White;
            rtbText.Location = new Point(37, 17);
            rtbText.Name = "rtbText";
            rtbText.ReadOnly = true;
            rtbText.Size = new Size(296, 75);
            rtbText.TabIndex = 18;
            rtbText.Text = "";
            // 
            // toolTipServiceID
            // 
            toolTipServiceID.BackColor = Color.FromArgb(50, 50, 77);
            toolTipServiceID.ForeColor = Color.White;
            toolTipServiceID.ToolTipTitle = "Service ID";
            // 
            // toolTipUserID
            // 
            toolTipUserID.BackColor = Color.FromArgb(50, 50, 77);
            toolTipUserID.ForeColor = Color.White;
            toolTipUserID.ToolTipTitle = "User ID";
            // 
            // toolTipCategoryID
            // 
            toolTipCategoryID.BackColor = Color.FromArgb(50, 50, 77);
            toolTipCategoryID.ForeColor = Color.White;
            toolTipCategoryID.ToolTipTitle = "Category ID";
            // 
            // UCComments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            Controls.Add(rtbText);
            Controls.Add(lblTime);
            Controls.Add(lblUserName);
            Controls.Add(lblServiceName);
            Controls.Add(lblCategory);
            Controls.Add(lblDate);
            Controls.Add(panel1);
            Name = "UCComments";
            Size = new Size(820, 100);
            Load += UCComments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblDate;
        private Label lblCategory;
        private Label lblServiceName;
        private Label lblUserName;
        private Label lblTime;
        private RichTextBox rtbText;
        private ToolTip toolTipServiceID;
        private ToolTip toolTipUserID;
        private ToolTip toolTipCategoryID;
    }
}
