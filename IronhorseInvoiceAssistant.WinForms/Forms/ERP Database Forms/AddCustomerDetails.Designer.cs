namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class AddCustomerDetails
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
            lblLastName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbCompanies = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtJobTitle = new TextBox();
            txtRegion = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNum = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(79, 66);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 161);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "Job Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 199);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Region:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 243);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 285);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 5;
            label6.Text = "Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 113);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 7;
            label7.Text = "Company:";
            // 
            // cmbCompanies
            // 
            cmbCompanies.FormattingEnabled = true;
            cmbCompanies.Location = new Point(178, 110);
            cmbCompanies.Name = "cmbCompanies";
            cmbCompanies.Size = new Size(182, 33);
            cmbCompanies.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(184, 24);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(184, 66);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 10;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(166, 155);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(150, 31);
            txtJobTitle.TabIndex = 11;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(156, 199);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(150, 31);
            txtRegion.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 13;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(221, 285);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(150, 31);
            txtPhoneNum.TabIndex = 14;
            // 
            // AddCustomerDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtEmail);
            Controls.Add(txtRegion);
            Controls.Add(txtJobTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(cmbCompanies);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblLastName);
            Controls.Add(label1);
            Name = "AddCustomerDetails";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbCompanies;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtJobTitle;
        private TextBox txtRegion;
        private TextBox txtEmail;
        private TextBox txtPhoneNum;
    }
}