namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormRentalBranches
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
            lblRentalCompanyID = new Label();
            lblBranchState = new Label();
            cmbRentalCompanyName = new ComboBox();
            cmbRentalBranchState = new ComboBox();
            lblBranchEmail = new Label();
            lblBranchPhone = new Label();
            lblBranchAddress = new Label();
            txtBranchAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // lblRentalCompanyID
            // 
            lblRentalCompanyID.AutoSize = true;
            lblRentalCompanyID.Location = new Point(119, 53);
            lblRentalCompanyID.Name = "lblRentalCompanyID";
            lblRentalCompanyID.Size = new Size(146, 25);
            lblRentalCompanyID.TabIndex = 0;
            lblRentalCompanyID.Text = "Rental Company:";
            // 
            // lblBranchState
            // 
            lblBranchState.AutoSize = true;
            lblBranchState.Location = new Point(119, 97);
            lblBranchState.Name = "lblBranchState";
            lblBranchState.Size = new Size(113, 25);
            lblBranchState.TabIndex = 1;
            lblBranchState.Text = "Branch State:";
            // 
            // cmbRentalCompanyName
            // 
            cmbRentalCompanyName.FormattingEnabled = true;
            cmbRentalCompanyName.Location = new Point(291, 53);
            cmbRentalCompanyName.Name = "cmbRentalCompanyName";
            cmbRentalCompanyName.Size = new Size(182, 33);
            cmbRentalCompanyName.TabIndex = 7;
            // 
            // cmbRentalBranchState
            // 
            cmbRentalBranchState.FormattingEnabled = true;
            cmbRentalBranchState.Location = new Point(291, 97);
            cmbRentalBranchState.Name = "cmbRentalBranchState";
            cmbRentalBranchState.Size = new Size(182, 33);
            cmbRentalBranchState.TabIndex = 8;
            // 
            // lblBranchEmail
            // 
            lblBranchEmail.AutoSize = true;
            lblBranchEmail.Location = new Point(119, 250);
            lblBranchEmail.Name = "lblBranchEmail";
            lblBranchEmail.Size = new Size(58, 25);
            lblBranchEmail.TabIndex = 9;
            lblBranchEmail.Text = "Email:";
            // 
            // lblBranchPhone
            // 
            lblBranchPhone.AutoSize = true;
            lblBranchPhone.Location = new Point(119, 202);
            lblBranchPhone.Name = "lblBranchPhone";
            lblBranchPhone.Size = new Size(66, 25);
            lblBranchPhone.TabIndex = 10;
            lblBranchPhone.Text = "Phone:";
            // 
            // lblBranchAddress
            // 
            lblBranchAddress.AutoSize = true;
            lblBranchAddress.Location = new Point(119, 153);
            lblBranchAddress.Name = "lblBranchAddress";
            lblBranchAddress.Size = new Size(139, 25);
            lblBranchAddress.TabIndex = 11;
            lblBranchAddress.Text = "Branch Address:";
            // 
            // txtBranchAddress
            // 
            txtBranchAddress.Location = new Point(291, 153);
            txtBranchAddress.Name = "txtBranchAddress";
            txtBranchAddress.Size = new Size(150, 31);
            txtBranchAddress.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(291, 199);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 31);
            txtPhoneNumber.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(291, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 14;
            // 
            // FormRentalBranches
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtBranchAddress);
            Controls.Add(lblBranchAddress);
            Controls.Add(lblBranchPhone);
            Controls.Add(lblBranchEmail);
            Controls.Add(cmbRentalBranchState);
            Controls.Add(cmbRentalCompanyName);
            Controls.Add(lblBranchState);
            Controls.Add(lblRentalCompanyID);
            Name = "FormRentalBranches";
            Text = "FormRentalBranches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRentalCompanyID;
        private Label lblBranchState;
        private ComboBox cmbRentalCompanyName;
        private ComboBox cmbRentalBranchState;
        private Label lblBranchEmail;
        private Label lblBranchPhone;
        private Label lblBranchAddress;
        private TextBox txtBranchAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
    }
}