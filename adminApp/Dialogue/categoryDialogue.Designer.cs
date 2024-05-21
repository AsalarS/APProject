namespace adminApp.Popup
{
    partial class categoryDialogue
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
            label3 = new Label();
            ddlManager = new ComboBox();
            label2 = new Label();
            descTxt = new TextBox();
            label1 = new Label();
            nameTxt = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            label4 = new Label();
            txtCategoryId = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 227);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 11;
            label3.Text = "Manager :";
            // 
            // ddlManager
            // 
            ddlManager.BackColor = Color.FromArgb(50, 50, 77);
            ddlManager.FlatStyle = FlatStyle.Flat;
            ddlManager.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ddlManager.FormattingEnabled = true;
            ddlManager.Location = new Point(230, 227);
            ddlManager.Name = "ddlManager";
            ddlManager.Size = new Size(300, 38);
            ddlManager.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 162);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 9;
            label2.Text = "Description :";
            // 
            // descTxt
            // 
            descTxt.BackColor = Color.FromArgb(50, 50, 77);
            descTxt.BorderStyle = BorderStyle.None;
            descTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            descTxt.Location = new Point(230, 164);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(300, 28);
            descTxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 98);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 7;
            label1.Text = "Category Name :";
            // 
            // nameTxt
            // 
            nameTxt.BackColor = Color.FromArgb(50, 50, 77);
            nameTxt.BorderStyle = BorderStyle.None;
            nameTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxt.Location = new Point(230, 100);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(300, 28);
            nameTxt.TabIndex = 6;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(13, 13, 37);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(401, 297);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(129, 40);
            cancelBtn.TabIndex = 21;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(13, 13, 37);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(39, 297);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(129, 40);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 33);
            label4.Name = "label4";
            label4.Size = new Size(134, 30);
            label4.TabIndex = 23;
            label4.Text = "Category ID :";
            // 
            // txtCategoryId
            // 
            txtCategoryId.BackColor = Color.FromArgb(50, 50, 77);
            txtCategoryId.BorderStyle = BorderStyle.None;
            txtCategoryId.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryId.Location = new Point(230, 35);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(300, 28);
            txtCategoryId.TabIndex = 22;
            // 
            // categoryDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(570, 381);
            Controls.Add(label4);
            Controls.Add(txtCategoryId);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(label3);
            Controls.Add(ddlManager);
            Controls.Add(label2);
            Controls.Add(descTxt);
            Controls.Add(label1);
            Controls.Add(nameTxt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "categoryDialogue";
            Text = "editWindow";
            Load += categoryDialogue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox ddlManager;
        private Label label2;
        private TextBox descTxt;
        private Label label1;
        private TextBox nameTxt;
        private Button cancelBtn;
        private Button saveBtn;
        private Label label4;
        private TextBox txtCategoryId;
    }
}