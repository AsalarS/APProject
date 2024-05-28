namespace adminApp.Pages
{
    partial class pageComments
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
            flpComments = new FlowLayoutPanel();
            panel1 = new Panel();
            lblDateTime = new Label();
            lblCategory = new Label();
            lblCustomer = new Label();
            lblService = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpComments
            // 
            flpComments.AutoScroll = true;
            flpComments.FlowDirection = FlowDirection.TopDown;
            flpComments.Location = new Point(12, 43);
            flpComments.Name = "flpComments";
            flpComments.Size = new Size(834, 556);
            flpComments.TabIndex = 1;
            flpComments.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 15, 36);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(lblCustomer);
            panel1.Controls.Add(lblService);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 37);
            panel1.TabIndex = 2;
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
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.FromArgb(131, 140, 163);
            lblCategory.Location = new Point(657, 9);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 17);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            lblCategory.Click += lblCategory_Click;
            lblCategory.MouseEnter += lblCategory_MouseEnter;
            lblCategory.MouseLeave += lblCategory_MouseLeave;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomer.ForeColor = Color.FromArgb(131, 140, 163);
            lblCustomer.Location = new Point(514, 9);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(67, 17);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Customer";
            lblCustomer.Click += lblCustomer_Click;
            lblCustomer.MouseEnter += lblCustomer_MouseEnter;
            lblCustomer.MouseLeave += lblCustomer_MouseLeave;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblService.ForeColor = Color.FromArgb(131, 140, 163);
            lblService.Location = new Point(383, 9);
            lblService.Name = "lblService";
            lblService.Size = new Size(51, 17);
            lblService.TabIndex = 1;
            lblService.Text = "Service";
            lblService.Click += btnService_Click;
            lblService.MouseEnter += lblService_MouseEnter;
            lblService.MouseLeave += lblService_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(131, 140, 163);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "Comment";
            // 
            // pageComments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(panel1);
            Controls.Add(flpComments);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "pageComments";
            Text = "pageComments";
            Load += pageComments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpComments;
        private Panel panel1;
        private Label label1;
        private Label lblService;
        private Label lblDateTime;
        private Label lblCategory;
        private Label lblCustomer;
    }
}