namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormEquipment
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
            lblEquipmentName = new Label();
            lblOwnerShipType = new Label();
            lblEquipmentAttachments = new Label();
            lblQuipmentType = new Label();
            txtEquipmentName = new TextBox();
            cmbOwnerShipStatus = new ComboBox();
            txtAttachments = new TextBox();
            cmbTypeOfEquipment = new ComboBox();
            SuspendLayout();
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Location = new Point(77, 53);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(176, 25);
            lblEquipmentName.TabIndex = 0;
            lblEquipmentName.Text = "Name of Equipment:";
            // 
            // lblOwnerShipType
            // 
            lblOwnerShipType.AutoSize = true;
            lblOwnerShipType.Location = new Point(77, 94);
            lblOwnerShipType.Name = "lblOwnerShipType";
            lblOwnerShipType.Size = new Size(161, 25);
            lblOwnerShipType.TabIndex = 1;
            lblOwnerShipType.Text = "Owner Ship Status:";
            // 
            // lblEquipmentAttachments
            // 
            lblEquipmentAttachments.AutoSize = true;
            lblEquipmentAttachments.Location = new Point(77, 142);
            lblEquipmentAttachments.Name = "lblEquipmentAttachments";
            lblEquipmentAttachments.Size = new Size(121, 25);
            lblEquipmentAttachments.TabIndex = 2;
            lblEquipmentAttachments.Text = "Attachments: ";
            // 
            // lblQuipmentType
            // 
            lblQuipmentType.AutoSize = true;
            lblQuipmentType.Location = new Point(77, 189);
            lblQuipmentType.Name = "lblQuipmentType";
            lblQuipmentType.Size = new Size(166, 25);
            lblQuipmentType.TabIndex = 3;
            lblQuipmentType.Text = "Type of Equipment:";
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Location = new Point(273, 53);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(481, 31);
            txtEquipmentName.TabIndex = 4;
            // 
            // cmbOwnerShipStatus
            // 
            cmbOwnerShipStatus.FormattingEnabled = true;
            cmbOwnerShipStatus.Location = new Point(273, 94);
            cmbOwnerShipStatus.Name = "cmbOwnerShipStatus";
            cmbOwnerShipStatus.Size = new Size(481, 33);
            cmbOwnerShipStatus.TabIndex = 5;
            // 
            // txtAttachments
            // 
            txtAttachments.Location = new Point(273, 139);
            txtAttachments.Name = "txtAttachments";
            txtAttachments.Size = new Size(481, 31);
            txtAttachments.TabIndex = 6;
            // 
            // cmbTypeOfEquipment
            // 
            cmbTypeOfEquipment.FormattingEnabled = true;
            cmbTypeOfEquipment.Location = new Point(273, 189);
            cmbTypeOfEquipment.Name = "cmbTypeOfEquipment";
            cmbTypeOfEquipment.Size = new Size(481, 33);
            cmbTypeOfEquipment.TabIndex = 7;
            cmbTypeOfEquipment.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FormEquipment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbTypeOfEquipment);
            Controls.Add(txtAttachments);
            Controls.Add(cmbOwnerShipStatus);
            Controls.Add(txtEquipmentName);
            Controls.Add(lblQuipmentType);
            Controls.Add(lblEquipmentAttachments);
            Controls.Add(lblOwnerShipType);
            Controls.Add(lblEquipmentName);
            Name = "FormEquipment";
            Text = "FormEquipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEquipmentName;
        private Label lblOwnerShipType;
        private Label lblEquipmentAttachments;
        private Label lblQuipmentType;
        private TextBox txtEquipmentName;
        private ComboBox cmbOwnerShipStatus;
        private TextBox txtAttachments;
        private ComboBox cmbTypeOfEquipment;
    }
}