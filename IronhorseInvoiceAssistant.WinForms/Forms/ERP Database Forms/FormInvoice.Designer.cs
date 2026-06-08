namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormInvoice
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
            lblInvoiceNumber = new Label();
            lblBillingContact = new Label();
            lblJobId = new Label();
            lblTotalAmount = new Label();
            label5 = new Label();
            lblInvoiceSentDate = new Label();
            lblInvoicePaidDate = new Label();
            lblInvoiceStatus = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            nudTotalAmount = new NumericUpDown();
            lblCurrencySign = new Label();
            dtpInvoiceSentDate = new DateTimePicker();
            dtpInvoicePaidDate = new DateTimePicker();
            cmbInvoiceSent = new ComboBox();
            cmbInvoiceStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudTotalAmount).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(155, 53);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(147, 25);
            lblInvoiceNumber.TabIndex = 0;
            lblInvoiceNumber.Text = " Invoice Number:";
            // 
            // lblBillingContact
            // 
            lblBillingContact.AutoSize = true;
            lblBillingContact.Location = new Point(155, 89);
            lblBillingContact.Name = "lblBillingContact";
            lblBillingContact.Size = new Size(129, 25);
            lblBillingContact.TabIndex = 1;
            lblBillingContact.Text = "Billing Contact:";
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(155, 140);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(67, 25);
            lblJobId.TabIndex = 2;
            lblJobId.Text = "Job ID:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(155, 188);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(123, 25);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 240);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 4;
            label5.Text = "Invoice Sent:";
            // 
            // lblInvoiceSentDate
            // 
            lblInvoiceSentDate.AutoSize = true;
            lblInvoiceSentDate.Location = new Point(155, 282);
            lblInvoiceSentDate.Name = "lblInvoiceSentDate";
            lblInvoiceSentDate.Size = new Size(154, 25);
            lblInvoiceSentDate.TabIndex = 5;
            lblInvoiceSentDate.Text = "Invoice Sent Date:";
            // 
            // lblInvoicePaidDate
            // 
            lblInvoicePaidDate.AutoSize = true;
            lblInvoicePaidDate.Location = new Point(155, 330);
            lblInvoicePaidDate.Name = "lblInvoicePaidDate";
            lblInvoicePaidDate.Size = new Size(152, 25);
            lblInvoicePaidDate.TabIndex = 6;
            lblInvoicePaidDate.Text = "Invoice Paid Date:";
            // 
            // lblInvoiceStatus
            // 
            lblInvoiceStatus.AutoSize = true;
            lblInvoiceStatus.Location = new Point(155, 372);
            lblInvoiceStatus.Name = "lblInvoiceStatus";
            lblInvoiceStatus.Size = new Size(125, 25);
            lblInvoiceStatus.TabIndex = 7;
            lblInvoiceStatus.Text = "Invoice Status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(323, 140);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 11;
            // 
            // nudTotalAmount
            // 
            nudTotalAmount.DecimalPlaces = 2;
            nudTotalAmount.Location = new Point(323, 188);
            nudTotalAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTotalAmount.Name = "nudTotalAmount";
            nudTotalAmount.Size = new Size(180, 31);
            nudTotalAmount.TabIndex = 12;
            nudTotalAmount.ThousandsSeparator = true;
            nudTotalAmount.Value = new decimal(new int[] { 65, 0, 0, 0 });
            // 
            // lblCurrencySign
            // 
            lblCurrencySign.AutoSize = true;
            lblCurrencySign.Location = new Point(295, 190);
            lblCurrencySign.Name = "lblCurrencySign";
            lblCurrencySign.Size = new Size(22, 25);
            lblCurrencySign.TabIndex = 13;
            lblCurrencySign.Text = "$";
            // 
            // dtpInvoiceSentDate
            // 
            dtpInvoiceSentDate.Location = new Point(339, 282);
            dtpInvoiceSentDate.Name = "dtpInvoiceSentDate";
            dtpInvoiceSentDate.Size = new Size(300, 31);
            dtpInvoiceSentDate.TabIndex = 14;
            // 
            // dtpInvoicePaidDate
            // 
            dtpInvoicePaidDate.Location = new Point(339, 330);
            dtpInvoicePaidDate.Name = "dtpInvoicePaidDate";
            dtpInvoicePaidDate.Size = new Size(300, 31);
            dtpInvoicePaidDate.TabIndex = 15;
            // 
            // cmbInvoiceSent
            // 
            cmbInvoiceSent.FormattingEnabled = true;
            cmbInvoiceSent.Location = new Point(339, 237);
            cmbInvoiceSent.Name = "cmbInvoiceSent";
            cmbInvoiceSent.Size = new Size(182, 33);
            cmbInvoiceSent.TabIndex = 16;
            cmbInvoiceSent.Text = "Was Invoice Sent?";
            // 
            // cmbInvoiceStatus
            // 
            cmbInvoiceStatus.FormattingEnabled = true;
            cmbInvoiceStatus.Location = new Point(339, 372);
            cmbInvoiceStatus.Name = "cmbInvoiceStatus";
            cmbInvoiceStatus.Size = new Size(300, 33);
            cmbInvoiceStatus.TabIndex = 17;
            cmbInvoiceStatus.Text = "Paid?/Unpaid?/Other?";
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(cmbInvoiceStatus);
            Controls.Add(cmbInvoiceSent);
            Controls.Add(dtpInvoicePaidDate);
            Controls.Add(dtpInvoiceSentDate);
            Controls.Add(lblCurrencySign);
            Controls.Add(nudTotalAmount);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lblInvoiceStatus);
            Controls.Add(lblInvoicePaidDate);
            Controls.Add(lblInvoiceSentDate);
            Controls.Add(label5);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblJobId);
            Controls.Add(lblBillingContact);
            Controls.Add(lblInvoiceNumber);
            Name = "FormInvoice";
            Text = "Invoice Form";
            ((System.ComponentModel.ISupportInitialize)nudTotalAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNumber;
        private Label lblBillingContact;
        private Label lblJobId;
        private Label lblTotalAmount;
        private Label label5;
        private Label lblInvoiceSentDate;
        private Label lblInvoicePaidDate;
        private Label lblInvoiceStatus;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private NumericUpDown nudTotalAmount;
        private Label lblCurrencySign;
        private DateTimePicker dtpInvoiceSentDate;
        private DateTimePicker dtpInvoicePaidDate;
        private ComboBox cmbInvoiceSent;
        private ComboBox cmbInvoiceStatus;
    }
}