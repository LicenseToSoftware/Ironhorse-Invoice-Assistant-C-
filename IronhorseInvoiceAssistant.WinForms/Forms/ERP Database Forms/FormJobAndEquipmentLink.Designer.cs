namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormJobAndEquipmentLink
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
            lblEquipment = new Label();
            lblJobLogID = new Label();
            cmbJobLog = new ComboBox();
            cmbEquipment = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(208, 124);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(107, 25);
            lblEquipment.TabIndex = 0;
            lblEquipment.Text = "Equipment: ";
            // 
            // lblJobLogID
            // 
            lblJobLogID.AutoSize = true;
            lblJobLogID.Location = new Point(208, 72);
            lblJobLogID.Name = "lblJobLogID";
            lblJobLogID.Size = new Size(44, 25);
            lblJobLogID.TabIndex = 1;
            lblJobLogID.Text = "Job:";
            // 
            // cmbJobLog
            // 
            cmbJobLog.FormattingEnabled = true;
            cmbJobLog.Location = new Point(355, 72);
            cmbJobLog.Name = "cmbJobLog";
            cmbJobLog.Size = new Size(182, 33);
            cmbJobLog.TabIndex = 2;
            // 
            // cmbEquipment
            // 
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(369, 124);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(182, 33);
            cmbEquipment.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 25);
            label1.Name = "label1";
            label1.Size = new Size(637, 25);
            label1.TabIndex = 4;
            label1.Text = "Note: Job and Equipment Must Exist in order for them to be assigned togethor";
            // 
            // FormJobAndEquipmentLink
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbEquipment);
            Controls.Add(cmbJobLog);
            Controls.Add(lblJobLogID);
            Controls.Add(lblEquipment);
            Name = "FormJobAndEquipmentLink";
            Text = "FormJobAndEquipmentLink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEquipment;
        private Label lblJobLogID;
        private ComboBox cmbJobLog;
        private ComboBox cmbEquipment;
        private Label label1;
    }
}