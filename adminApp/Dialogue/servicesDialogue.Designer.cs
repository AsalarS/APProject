namespace adminApp.Dialogue
{
    partial class servicesDialogue
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
            label1 = new Label();
            nameTxt = new TextBox();
            label2 = new Label();
            descTxt = new TextBox();
            label3 = new Label();
            priceTxt = new TextBox();
            label4 = new Label();
            ddlCategory = new ComboBox();
            label5 = new Label();
            ddlTechnician = new ComboBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            label6 = new Label();
            txtServiceId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 9;
            label1.Text = "Services Name :";
            // 
            // nameTxt
            // 
            nameTxt.BackColor = Color.FromArgb(50, 50, 77);
            nameTxt.BorderStyle = BorderStyle.None;
            nameTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxt.ForeColor = Color.White;
            nameTxt.Location = new Point(226, 80);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(300, 28);
            nameTxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 131);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 11;
            label2.Text = "Description :";
            // 
            // descTxt
            // 
            descTxt.BackColor = Color.FromArgb(50, 50, 77);
            descTxt.BorderStyle = BorderStyle.None;
            descTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            descTxt.ForeColor = Color.White;
            descTxt.Location = new Point(226, 133);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(300, 28);
            descTxt.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 188);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 13;
            label3.Text = "Price :";
            // 
            // priceTxt
            // 
            priceTxt.BackColor = Color.FromArgb(50, 50, 77);
            priceTxt.BorderStyle = BorderStyle.None;
            priceTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            priceTxt.ForeColor = Color.White;
            priceTxt.Location = new Point(226, 190);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(300, 28);
            priceTxt.TabIndex = 12;
            priceTxt.WordWrap = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 244);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 15;
            label4.Text = "Category :";
            // 
            // ddlCategory
            // 
            ddlCategory.BackColor = Color.FromArgb(50, 50, 77);
            ddlCategory.FlatStyle = FlatStyle.Flat;
            ddlCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ddlCategory.ForeColor = Color.White;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(226, 244);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(300, 38);
            ddlCategory.TabIndex = 14;
            ddlCategory.DropDownClosed += ddlCategory_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 309);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 17;
            label5.Text = "Technician :";
            // 
            // ddlTechnician
            // 
            ddlTechnician.BackColor = Color.FromArgb(50, 50, 77);
            ddlTechnician.FlatStyle = FlatStyle.Flat;
            ddlTechnician.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ddlTechnician.ForeColor = Color.White;
            ddlTechnician.FormattingEnabled = true;
            ddlTechnician.Location = new Point(226, 309);
            ddlTechnician.Name = "ddlTechnician";
            ddlTechnician.Size = new Size(300, 38);
            ddlTechnician.TabIndex = 16;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(13, 13, 37);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(35, 384);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(129, 40);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(13, 13, 37);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(397, 384);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(129, 40);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(35, 29);
            label6.Name = "label6";
            label6.Size = new Size(119, 30);
            label6.TabIndex = 21;
            label6.Text = "Services ID:";
            // 
            // txtServiceId
            // 
            txtServiceId.BackColor = Color.FromArgb(50, 50, 77);
            txtServiceId.BorderStyle = BorderStyle.None;
            txtServiceId.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtServiceId.ForeColor = Color.White;
            txtServiceId.Location = new Point(226, 31);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.ReadOnly = true;
            txtServiceId.Size = new Size(300, 28);
            txtServiceId.TabIndex = 20;
            // 
            // servicesDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(574, 465);
            Controls.Add(label6);
            Controls.Add(txtServiceId);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(label5);
            Controls.Add(ddlTechnician);
            Controls.Add(label4);
            Controls.Add(ddlCategory);
            Controls.Add(label3);
            Controls.Add(priceTxt);
            Controls.Add(label2);
            Controls.Add(descTxt);
            Controls.Add(label1);
            Controls.Add(nameTxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "servicesDialogue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "servicesCategory";
            Load += servicesDialogue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTxt;
        private Label label2;
        private TextBox descTxt;
        private Label label3;
        private TextBox priceTxt;
        private Label label4;
        private ComboBox ddlCategory;
        private Label label5;
        private ComboBox ddlTechnician;
        private Button saveBtn;
        private Button cancelBtn;
        private Label label6;
        private TextBox txtServiceId;
    }
}