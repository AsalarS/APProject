namespace AdminApp.Pages
{
    partial class logsPage
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
            dgvLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.BackgroundColor = Color.FromArgb(0, 0, 24);
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.GridColor = SystemColors.Menu;
            dgvLogs.Location = new Point(60, 60);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowTemplate.Height = 25;
            dgvLogs.Size = new Size(750, 450);
            dgvLogs.TabIndex = 0;
            dgvLogs.CellContentClick += dgvLogs_CellContentClick;
            // 
            // logsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(858, 611);
            Controls.Add(dgvLogs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logsPage";
            Text = "logsPage";
            Load += logsPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLogs;
    }
}