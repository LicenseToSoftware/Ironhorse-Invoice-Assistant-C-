namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormRentalCompany
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
            label2 = new Label();
            txtRentalCompanyName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 100);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 0;
            label1.Text = "Rental Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 37);
            label2.Name = "label2";
            label2.Size = new Size(460, 25);
            label2.TabIndex = 1;
            label2.Text = "Note: Maybe call if rental braches does not list company.";
            // 
            // txtRentalCompanyName
            // 
            txtRentalCompanyName.Location = new Point(309, 100);
            txtRentalCompanyName.Name = "txtRentalCompanyName";
            txtRentalCompanyName.Size = new Size(150, 31);
            txtRentalCompanyName.TabIndex = 2;
            // 
            // FormRentalCompany
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRentalCompanyName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRentalCompany";
            Text = "FormRentalCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRentalCompanyName;
    }
}