namespace AdminApp
{
    partial class servicesPage
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
            dgvServices = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            lblTechnician = new Label();
            lblCategory = new Label();
            lblServieID = new Label();
            btnReset = new Button();
            btnFilter = new Button();
            ddlTechnician = new ComboBox();
            ddlCategory = new ComboBox();
            txtServiceID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(24, 107);
            dgvServices.Name = "dgvServices";
            dgvServices.RowTemplate.Height = 25;
            dgvServices.Size = new Size(802, 376);
            dgvServices.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(110, 505);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(399, 505);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(675, 505);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTechnician);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblServieID);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(ddlTechnician);
            groupBox1.Controls.Add(ddlCategory);
            groupBox1.Controls.Add(txtServiceID);
            groupBox1.ForeColor = Color.FromArgb(131, 140, 163);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 89);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search and Filter";
            // 
            // lblTechnician
            // 
            lblTechnician.AutoSize = true;
            lblTechnician.Location = new Point(456, 48);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new Size(63, 15);
            lblTechnician.TabIndex = 7;
            lblTechnician.Text = "Technician";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(226, 48);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblServieID
            // 
            lblServieID.AutoSize = true;
            lblServieID.Location = new Point(46, 48);
            lblServieID.Name = "lblServieID";
            lblServieID.Size = new Size(58, 15);
            lblServieID.TabIndex = 5;
            lblServieID.Text = "Service ID";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(721, 60);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(721, 22);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // ddlTechnician
            // 
            ddlTechnician.FormattingEnabled = true;
            ddlTechnician.Location = new Point(534, 40);
            ddlTechnician.Name = "ddlTechnician";
            ddlTechnician.Size = new Size(121, 23);
            ddlTechnician.TabIndex = 2;
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(315, 40);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(121, 23);
            ddlCategory.TabIndex = 1;
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new Point(120, 40);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new Size(100, 23);
            txtServiceID.TabIndex = 0;
            // 
            // servicesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "servicesPage";
            Text = "servicesPage";
            Load += servicesPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvServices;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private TextBox txtServiceID;
        private ComboBox ddlTechnician;
        private ComboBox ddlCategory;
        private Label lblTechnician;
        private Label lblCategory;
        private Label lblServieID;
        private Button btnReset;
        private Button btnFilter;
    }
}