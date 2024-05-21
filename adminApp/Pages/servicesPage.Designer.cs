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
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(110, 55);
            dgvServices.Name = "dgvServices";
            dgvServices.RowTemplate.Height = 25;
            dgvServices.Size = new Size(640, 376);
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
            // 
            // servicesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "servicesPage";
            Text = "servicesPage";
            Load += servicesPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvServices;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}