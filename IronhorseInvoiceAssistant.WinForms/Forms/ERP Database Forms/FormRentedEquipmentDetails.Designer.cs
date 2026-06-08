namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormRentedEquipmentDetails
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
            txtAssignedNumber = new TextBox();
            nudRentalRate = new NumericUpDown();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cmbIsRentalPaid = new ComboBox();
            lblISRentPaid = new Label();
            lblAgreementNumber = new Label();
            lblRentalRate = new Label();
            lblRentalEndDate = new Label();
            lblRentalStartDate = new Label();
            lblBranchID = new Label();
            lblRentalCompany = new Label();
            cmbRentalCompanyID = new ComboBox();
            cmbRentalBranchID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRentalRate).BeginInit();
            SuspendLayout();
            // 
            // txtAssignedNumber
            // 
            txtAssignedNumber.Location = new Point(375, 288);
            txtAssignedNumber.Name = "txtAssignedNumber";
            txtAssignedNumber.Size = new Size(150, 31);
            txtAssignedNumber.TabIndex = 23;
            // 
            // nudRentalRate
            // 
            nudRentalRate.DecimalPlaces = 2;
            nudRentalRate.Location = new Point(277, 247);
            nudRentalRate.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudRentalRate.Name = "nudRentalRate";
            nudRentalRate.Size = new Size(180, 31);
            nudRentalRate.TabIndex = 22;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(277, 209);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 21;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(277, 168);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 20;
            // 
            // cmbIsRentalPaid
            // 
            cmbIsRentalPaid.FormattingEnabled = true;
            cmbIsRentalPaid.Location = new Point(338, 337);
            cmbIsRentalPaid.Name = "cmbIsRentalPaid";
            cmbIsRentalPaid.Size = new Size(182, 33);
            cmbIsRentalPaid.TabIndex = 19;
            // 
            // lblISRentPaid
            // 
            lblISRentPaid.AutoSize = true;
            lblISRentPaid.Location = new Point(166, 337);
            lblISRentPaid.Name = "lblISRentPaid";
            lblISRentPaid.Size = new Size(110, 25);
            lblISRentPaid.TabIndex = 18;
            lblISRentPaid.Text = "Rental Paid?:";
            // 
            // lblAgreementNumber
            // 
            lblAgreementNumber.AutoSize = true;
            lblAgreementNumber.Location = new Point(166, 292);
            lblAgreementNumber.Name = "lblAgreementNumber";
            lblAgreementNumber.Size = new Size(159, 25);
            lblAgreementNumber.TabIndex = 17;
            lblAgreementNumber.Text = "Assigned Number:";
            // 
            // lblRentalRate
            // 
            lblRentalRate.AutoSize = true;
            lblRentalRate.Location = new Point(166, 247);
            lblRentalRate.Name = "lblRentalRate";
            lblRentalRate.Size = new Size(104, 25);
            lblRentalRate.TabIndex = 16;
            lblRentalRate.Text = "Rental Rate:";
            // 
            // lblRentalEndDate
            // 
            lblRentalEndDate.AutoSize = true;
            lblRentalEndDate.Location = new Point(166, 209);
            lblRentalEndDate.Name = "lblRentalEndDate";
            lblRentalEndDate.Size = new Size(88, 25);
            lblRentalEndDate.TabIndex = 15;
            lblRentalEndDate.Text = "End Date:";
            // 
            // lblRentalStartDate
            // 
            lblRentalStartDate.AutoSize = true;
            lblRentalStartDate.Location = new Point(166, 167);
            lblRentalStartDate.Name = "lblRentalStartDate";
            lblRentalStartDate.Size = new Size(94, 25);
            lblRentalStartDate.TabIndex = 14;
            lblRentalStartDate.Text = "Start Date:";
            // 
            // lblBranchID
            // 
            lblBranchID.AutoSize = true;
            lblBranchID.Location = new Point(160, 120);
            lblBranchID.Name = "lblBranchID";
            lblBranchID.Size = new Size(141, 25);
            lblBranchID.TabIndex = 24;
            lblBranchID.Text = "Branch Location:";
            // 
            // lblRentalCompany
            // 
            lblRentalCompany.AutoSize = true;
            lblRentalCompany.Location = new Point(160, 79);
            lblRentalCompany.Name = "lblRentalCompany";
            lblRentalCompany.Size = new Size(146, 25);
            lblRentalCompany.TabIndex = 25;
            lblRentalCompany.Text = "Rental Company:";
            // 
            // cmbRentalCompanyID
            // 
            cmbRentalCompanyID.FormattingEnabled = true;
            cmbRentalCompanyID.Location = new Point(312, 79);
            cmbRentalCompanyID.Name = "cmbRentalCompanyID";
            cmbRentalCompanyID.Size = new Size(182, 33);
            cmbRentalCompanyID.TabIndex = 26;
            // 
            // cmbRentalBranchID
            // 
            cmbRentalBranchID.FormattingEnabled = true;
            cmbRentalBranchID.Location = new Point(307, 120);
            cmbRentalBranchID.Name = "cmbRentalBranchID";
            cmbRentalBranchID.Size = new Size(182, 33);
            cmbRentalBranchID.TabIndex = 27;
            // 
            // FormRentedEquipmentDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRentalBranchID);
            Controls.Add(cmbRentalCompanyID);
            Controls.Add(lblRentalCompany);
            Controls.Add(lblBranchID);
            Controls.Add(txtAssignedNumber);
            Controls.Add(nudRentalRate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cmbIsRentalPaid);
            Controls.Add(lblISRentPaid);
            Controls.Add(lblAgreementNumber);
            Controls.Add(lblRentalRate);
            Controls.Add(lblRentalEndDate);
            Controls.Add(lblRentalStartDate);
            Name = "FormRentedEquipmentDetails";
            Text = "FormRentedEquipmentDetails";
            ((System.ComponentModel.ISupportInitialize)nudRentalRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAssignedNumber;
        private NumericUpDown nudRentalRate;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private ComboBox cmbIsRentalPaid;
        private Label lblISRentPaid;
        private Label lblAgreementNumber;
        private Label lblRentalRate;
        private Label lblRentalEndDate;
        private Label lblRentalStartDate;
        private Label lblBranchID;
        private Label lblRentalCompany;
        private ComboBox cmbRentalCompanyID;
        private ComboBox cmbRentalBranchID;
    }
}