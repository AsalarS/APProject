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
            dgvComments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvComments).BeginInit();
            SuspendLayout();
            // 
            // dgvComments
            // 
            dgvComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComments.Location = new Point(12, 12);
            dgvComments.Name = "dgvComments";
            dgvComments.RowTemplate.Height = 25;
            dgvComments.Size = new Size(834, 587);
            dgvComments.TabIndex = 0;
            // 
            // pageComments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(dgvComments);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "pageComments";
            Text = "pageComments";
            Load += pageComments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvComments;
    }
}