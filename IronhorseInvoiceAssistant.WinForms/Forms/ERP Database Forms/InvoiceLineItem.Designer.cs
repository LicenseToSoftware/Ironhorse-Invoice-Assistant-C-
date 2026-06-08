namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class InvoiceLineItem
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
            lblLineNumber = new Label();
            lblLineItemTitle = new Label();
            lblDescription = new Label();
            lblQuantity = new Label();
            lblUnitPrice = new Label();
            lblTotalPrice = new Label();
            nudLineNumber = new NumericUpDown();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            nudQuantity = new NumericUpDown();
            nudUnitPrice = new NumericUpDown();
            lbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudLineNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // lblLineNumber
            // 
            lblLineNumber.AutoSize = true;
            lblLineNumber.Location = new Point(28, 59);
            lblLineNumber.Name = "lblLineNumber";
            lblLineNumber.Size = new Size(117, 25);
            lblLineNumber.TabIndex = 0;
            lblLineNumber.Text = "Line Number:";
            // 
            // lblLineItemTitle
            // 
            lblLineItemTitle.AutoSize = true;
            lblLineItemTitle.Location = new Point(97, 110);
            lblLineItemTitle.Name = "lblLineItemTitle";
            lblLineItemTitle.Size = new Size(48, 25);
            lblLineItemTitle.TabIndex = 1;
            lblLineItemTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(39, 151);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(61, 196);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 25);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(55, 236);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(90, 25);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(50, 281);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(95, 25);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "Total Price:";
            // 
            // nudLineNumber
            // 
            nudLineNumber.Location = new Point(151, 59);
            nudLineNumber.Name = "nudLineNumber";
            nudLineNumber.Size = new Size(551, 31);
            nudLineNumber.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(151, 107);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(551, 31);
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Insert Line Title";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(151, 148);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(551, 31);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "Insert Line Description";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(151, 196);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(551, 31);
            nudQuantity.TabIndex = 9;
            // 
            // nudUnitPrice
            // 
            nudUnitPrice.DecimalPlaces = 2;
            nudUnitPrice.Location = new Point(151, 236);
            nudUnitPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudUnitPrice.Name = "nudUnitPrice";
            nudUnitPrice.Size = new Size(551, 31);
            nudUnitPrice.TabIndex = 10;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(151, 281);
            lbl.Name = "lbl";
            lbl.Size = new Size(373, 25);
            lbl.TabIndex = 11;
            lbl.Text = "Need to decide best tool For dynamic update";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 22);
            label1.Name = "label1";
            label1.Size = new Size(377, 25);
            label1.TabIndex = 12;
            label1.Text = "Note: Only call from invoice window if needed";
            // 
            // InvoiceLineItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl);
            Controls.Add(nudUnitPrice);
            Controls.Add(nudQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(nudLineNumber);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblDescription);
            Controls.Add(lblLineItemTitle);
            Controls.Add(lblLineNumber);
            Name = "InvoiceLineItem";
            Text = "InvoiceLineItem";
            ((System.ComponentModel.ISupportInitialize)nudLineNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLineNumber;
        private Label lblLineItemTitle;
        private Label lblDescription;
        private Label lblQuantity;
        private Label lblUnitPrice;
        private Label lblTotalPrice;
        private NumericUpDown nudLineNumber;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudUnitPrice;
        private Label lbl;
        private Label label1;
    }
}