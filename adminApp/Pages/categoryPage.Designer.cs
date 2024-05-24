namespace AdminApp.Pages
{
    partial class categoryPage
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
            dgvCategory = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            lblManager = new Label();
            lblCategoryID = new Label();
            btnReset = new Button();
            btnFilter = new Button();
            ddlManager = new ComboBox();
            txtCategoryID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(24, 107);
            dgvCategory.Margin = new Padding(2);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 62;
            dgvCategory.RowTemplate.Height = 33;
            dgvCategory.Size = new Size(802, 407);
            dgvCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(13, 13, 37);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 530);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 50);
            btnAdd.TabIndex = 2;
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
            btnDelete.Location = new Point(355, 530);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 50);
            btnDelete.TabIndex = 3;
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
            btnUpdate.Location = new Point(680, 530);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 50);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblManager);
            groupBox1.Controls.Add(lblCategoryID);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(ddlManager);
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.ForeColor = Color.FromArgb(131, 140, 163);
            groupBox1.Location = new Point(24, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 89);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search and Filter";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Location = new Point(402, 18);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(54, 15);
            lblManager.TabIndex = 7;
            lblManager.Text = "Manager";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Location = new Point(54, 18);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(69, 15);
            lblCategoryID.TabIndex = 5;
            lblCategoryID.Text = "Category ID";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(13, 13, 37);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(716, 56);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
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
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(716, 18);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // ddlManager
            // 
            ddlManager.BackColor = Color.FromArgb(50, 50, 77);
            ddlManager.FlatStyle = FlatStyle.Flat;
            ddlManager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ddlManager.ForeColor = Color.White;
            ddlManager.FormattingEnabled = true;
            ddlManager.Location = new Point(402, 37);
            ddlManager.Name = "ddlManager";
            ddlManager.Size = new Size(290, 29);
            ddlManager.TabIndex = 2;
            // 
            // txtCategoryID
            // 
            txtCategoryID.BackColor = Color.FromArgb(50, 50, 77);
            txtCategoryID.BorderStyle = BorderStyle.None;
            txtCategoryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryID.ForeColor = Color.White;
            txtCategoryID.Location = new Point(54, 37);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(290, 22);
            txtCategoryID.TabIndex = 0;
            // 
            // categoryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "categoryPage";
            Text = "categoryPage";
            Load += categoryPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategory;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private Label lblManager;
        private Label lblCategoryID;
        private Button btnReset;
        private Button btnFilter;
        private ComboBox ddlManager;
        private TextBox txtCategoryID;
    }
}