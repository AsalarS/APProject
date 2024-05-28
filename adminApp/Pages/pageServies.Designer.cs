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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dgvServices = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
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
            // dgvServices
            // 
            dgvServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = Color.FromArgb(0, 0, 24);
            dgvServices.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(131, 140, 163);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 77);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 0, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 0, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(131, 140, 163);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 50, 77);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 24);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvServices.GridColor = Color.FromArgb(50, 50, 77);
            dgvServices.Location = new Point(24, 106);
            dgvServices.Margin = new Padding(2);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 0, 24);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(131, 140, 163);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 50, 77);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(13, 13, 37);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvServices.RowHeadersVisible = false;
            dgvServices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 24);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(131, 140, 163);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 50, 77);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(13, 13, 37);
            dgvServices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvServices.RowTemplate.Height = 33;
            dgvServices.ShowEditingIcon = false;
            dgvServices.Size = new Size(802, 407);
            dgvServices.TabIndex = 5;
            // 
            // pageServies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(dgvServices);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pageServies";
            Text = "servicesPage";
            Load += servicesPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private DataGridView dgvServices;
    }
}