namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormJobLog
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
            lblJobNumber = new Label();
            lblJobType = new Label();
            lblAssignedByContact = new Label();
            lblJobStatus = new Label();
            lblJobScope = new Label();
            lblJobStartDate = new Label();
            lblJobCompletionDate = new Label();
            txtJobNumber = new TextBox();
            cmbJobType = new ComboBox();
            cmbAssignedBy = new ComboBox();
            cmbJobStatus = new ComboBox();
            txtJobScope = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpCompletionDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lblJobNumber
            // 
            lblJobNumber.AutoSize = true;
            lblJobNumber.Location = new Point(153, 67);
            lblJobNumber.Name = "lblJobNumber";
            lblJobNumber.Size = new Size(114, 25);
            lblJobNumber.TabIndex = 0;
            lblJobNumber.Text = "Job Number:";
            // 
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Location = new Point(153, 120);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(86, 25);
            lblJobType.TabIndex = 1;
            lblJobType.Text = "Job Type:";
            // 
            // lblAssignedByContact
            // 
            lblAssignedByContact.AutoSize = true;
            lblAssignedByContact.Location = new Point(153, 168);
            lblAssignedByContact.Name = "lblAssignedByContact";
            lblAssignedByContact.Size = new Size(113, 25);
            lblAssignedByContact.TabIndex = 2;
            lblAssignedByContact.Text = "Assigned By:";
            // 
            // lblJobStatus
            // 
            lblJobStatus.AutoSize = true;
            lblJobStatus.Location = new Point(153, 222);
            lblJobStatus.Name = "lblJobStatus";
            lblJobStatus.Size = new Size(97, 25);
            lblJobStatus.TabIndex = 3;
            lblJobStatus.Text = "Job Status:";
            // 
            // lblJobScope
            // 
            lblJobScope.AutoSize = true;
            lblJobScope.Location = new Point(416, 360);
            lblJobScope.Name = "lblJobScope";
            lblJobScope.Size = new Size(196, 25);
            lblJobScope.TabIndex = 4;
            lblJobScope.Text = "Job Scope/Email Chain:";
            // 
            // lblJobStartDate
            // 
            lblJobStartDate.AutoSize = true;
            lblJobStartDate.Location = new Point(85, 534);
            lblJobStartDate.Name = "lblJobStartDate";
            lblJobStartDate.Size = new Size(94, 25);
            lblJobStartDate.TabIndex = 5;
            lblJobStartDate.Text = "Start Date:";
            // 
            // lblJobCompletionDate
            // 
            lblJobCompletionDate.AutoSize = true;
            lblJobCompletionDate.Location = new Point(61, 588);
            lblJobCompletionDate.Name = "lblJobCompletionDate";
            lblJobCompletionDate.Size = new Size(151, 25);
            lblJobCompletionDate.TabIndex = 6;
            lblJobCompletionDate.Text = "Completion Date:";
            // 
            // txtJobNumber
            // 
            txtJobNumber.Location = new Point(283, 67);
            txtJobNumber.Name = "txtJobNumber";
            txtJobNumber.Size = new Size(711, 31);
            txtJobNumber.TabIndex = 8;
            txtJobNumber.Text = "Enter Job Number.";
            txtJobNumber.TextChanged += textBox1_TextChanged;
            // 
            // cmbJobType
            // 
            cmbJobType.FormattingEnabled = true;
            cmbJobType.Location = new Point(283, 117);
            cmbJobType.Name = "cmbJobType";
            cmbJobType.Size = new Size(711, 33);
            cmbJobType.TabIndex = 9;
            // 
            // cmbAssignedBy
            // 
            cmbAssignedBy.FormattingEnabled = true;
            cmbAssignedBy.Location = new Point(283, 168);
            cmbAssignedBy.Name = "cmbAssignedBy";
            cmbAssignedBy.Size = new Size(711, 33);
            cmbAssignedBy.TabIndex = 10;
            // 
            // cmbJobStatus
            // 
            cmbJobStatus.FormattingEnabled = true;
            cmbJobStatus.Location = new Point(283, 222);
            cmbJobStatus.Name = "cmbJobStatus";
            cmbJobStatus.Size = new Size(682, 33);
            cmbJobStatus.TabIndex = 11;
            // 
            // txtJobScope
            // 
            txtJobScope.Location = new Point(214, 404);
            txtJobScope.Multiline = true;
            txtJobScope.Name = "txtJobScope";
            txtJobScope.Size = new Size(563, 46);
            txtJobScope.TabIndex = 13;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(300, 534);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 14;
            // 
            // dtpCompletionDate
            // 
            dtpCompletionDate.Location = new Point(300, 582);
            dtpCompletionDate.Name = "dtpCompletionDate";
            dtpCompletionDate.Size = new Size(300, 31);
            dtpCompletionDate.TabIndex = 15;
            // 
            // FormJobLog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 779);
            Controls.Add(dtpCompletionDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtJobScope);
            Controls.Add(cmbJobStatus);
            Controls.Add(cmbAssignedBy);
            Controls.Add(cmbJobType);
            Controls.Add(txtJobNumber);
            Controls.Add(lblJobCompletionDate);
            Controls.Add(lblJobStartDate);
            Controls.Add(lblJobScope);
            Controls.Add(lblJobStatus);
            Controls.Add(lblAssignedByContact);
            Controls.Add(lblJobType);
            Controls.Add(lblJobNumber);
            Name = "FormJobLog";
            Text = "FormJobLog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJobNumber;
        private Label lblJobType;
        private Label lblAssignedByContact;
        private Label lblJobStatus;
        private Label lblJobScope;
        private Label lblJobStartDate;
        private Label lblJobCompletionDate;
        private TextBox txtJobNumber;
        private ComboBox cmbJobType;
        private ComboBox cmbAssignedBy;
        private ComboBox cmbJobStatus;
        private TextBox txtJobScope;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpCompletionDate;
    }
}