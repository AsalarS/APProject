namespace AdminApp
{
    partial class pageServies
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
            dgvServices.Size = new Size(802, 404);
            dgvServices.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(13, 13, 37);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 528);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(13, 13, 37);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(355, 528);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(13, 13, 37);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(686, 528);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 50);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
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
            lblTechnician.Location = new Point(456, 24);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new Size(63, 15);
            lblTechnician.TabIndex = 7;
            lblTechnician.Text = "Technician";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(234, 24);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblServieID
            // 
            lblServieID.AutoSize = true;
            lblServieID.Location = new Point(34, 24);
            lblServieID.Name = "lblServieID";
            lblServieID.Size = new Size(58, 15);
            lblServieID.TabIndex = 5;
            lblServieID.Text = "Service ID";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(13, 13, 37);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(688, 50);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(108, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(13, 13, 37);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(688, 15);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(108, 29);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // ddlTechnician
            // 
            ddlTechnician.BackColor = Color.FromArgb(50, 50, 77);
            ddlTechnician.FlatStyle = FlatStyle.Flat;
            ddlTechnician.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ddlTechnician.ForeColor = Color.White;
            ddlTechnician.FormattingEnabled = true;
            ddlTechnician.Location = new Point(456, 40);
            ddlTechnician.Name = "ddlTechnician";
            ddlTechnician.Size = new Size(199, 29);
            ddlTechnician.TabIndex = 2;
            // 
            // ddlCategory
            // 
            ddlCategory.BackColor = Color.FromArgb(50, 50, 77);
            ddlCategory.FlatStyle = FlatStyle.Flat;
            ddlCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ddlCategory.ForeColor = Color.White;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(234, 40);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(202, 29);
            ddlCategory.TabIndex = 1;
            // 
            // txtServiceID
            // 
            txtServiceID.BackColor = Color.FromArgb(50, 50, 77);
            txtServiceID.BorderStyle = BorderStyle.None;
            txtServiceID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtServiceID.ForeColor = Color.White;
            txtServiceID.Location = new Point(34, 43);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new Size(186, 22);
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