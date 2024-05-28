namespace adminApp.CustomRows
{
    partial class UCTechnician
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
            txtTechnicianName = new Label();
            txtTotalRequests = new Label();
            txtCompletedRequests = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtTechnicianName
            // 
            txtTechnicianName.AutoSize = true;
            txtTechnicianName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTechnicianName.ForeColor = Color.White;
            txtTechnicianName.Location = new Point(39, 13);
            txtTechnicianName.Name = "txtTechnicianName";
            txtTechnicianName.Size = new Size(67, 17);
            txtTechnicianName.TabIndex = 0;
            txtTechnicianName.Text = "John Doe";
            // 
            // txtTotalRequests
            // 
            txtTotalRequests.AutoSize = true;
            txtTotalRequests.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalRequests.ForeColor = Color.FromArgb(131, 140, 163);
            txtTotalRequests.Location = new Point(337, 15);
            txtTotalRequests.Name = "txtTotalRequests";
            txtTotalRequests.Size = new Size(21, 15);
            txtTotalRequests.TabIndex = 1;
            txtTotalRequests.Text = "00";
            // 
            // txtCompletedRequests
            // 
            txtCompletedRequests.AutoSize = true;
            txtCompletedRequests.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCompletedRequests.ForeColor = Color.FromArgb(131, 140, 163);
            txtCompletedRequests.Location = new Point(418, 15);
            txtCompletedRequests.Name = "txtCompletedRequests";
            txtCompletedRequests.Size = new Size(21, 15);
            txtCompletedRequests.TabIndex = 2;
            txtCompletedRequests.Text = "00";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(22, 22, 44);
            panel1.Location = new Point(10, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 2);
            panel1.TabIndex = 3;
            // 
            // UCTechnician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            Controls.Add(panel1);
            Controls.Add(txtCompletedRequests);
            Controls.Add(txtTotalRequests);
            Controls.Add(txtTechnicianName);
            Name = "UCTechnician";
            Size = new Size(470, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTechnicianName;
        private Label txtTotalRequests;
        private Label txtCompletedRequests;
        private Panel panel1;
    }
}
