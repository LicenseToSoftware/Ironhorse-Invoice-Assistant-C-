namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormOwnedEquipmentDetails
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
            lblPurchaseDate = new Label();
            lblSerialNumber = new Label();
            lblOriginalPrice = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtSerialNumber = new TextBox();
            nudPurchasePrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPurchasePrice).BeginInit();
            SuspendLayout();
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.Location = new Point(12, 56);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(128, 25);
            lblPurchaseDate.TabIndex = 0;
            lblPurchaseDate.Text = "Purchase Date:";
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.AutoSize = true;
            lblSerialNumber.Location = new Point(12, 101);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(128, 25);
            lblSerialNumber.TabIndex = 1;
            lblSerialNumber.Text = "Serial Number:";
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Location = new Point(12, 152);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(128, 25);
            lblOriginalPrice.TabIndex = 2;
            lblOriginalPrice.Text = "Purchase Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 18);
            label1.Name = "label1";
            label1.Size = new Size(531, 25);
            label1.TabIndex = 3;
            label1.Text = "Note: If Equipment is Owned this form should appear if not listed";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(146, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(146, 101);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(622, 31);
            txtSerialNumber.TabIndex = 5;
            // 
            // nudPurchasePrice
            // 
            nudPurchasePrice.DecimalPlaces = 2;
            nudPurchasePrice.Location = new Point(146, 150);
            nudPurchasePrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPurchasePrice.Name = "nudPurchasePrice";
            nudPurchasePrice.Size = new Size(180, 31);
            nudPurchasePrice.TabIndex = 6;
            // 
            // FormOwnedEquipmentDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudPurchasePrice);
            Controls.Add(txtSerialNumber);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(lblOriginalPrice);
            Controls.Add(lblSerialNumber);
            Controls.Add(lblPurchaseDate);
            Name = "FormOwnedEquipmentDetails";
            Text = "FormOwnedEquipmentDetails";
            ((System.ComponentModel.ISupportInitialize)nudPurchasePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPurchaseDate;
        private Label lblSerialNumber;
        private Label lblOriginalPrice;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSerialNumber;
        private NumericUpDown nudPurchasePrice;
    }
}