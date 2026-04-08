namespace IronhorseInvoiceAssistant.WinForms.Forms
{
    partial class ProgressBarForm
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
            progressBar = new ProgressBar();
            lblStatus = new Label();
            lblFileName = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Top;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(704, 34);
            progressBar.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblStatus.Location = new Point(0, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "label1";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFileName
            // 
            lblFileName.AutoEllipsis = true;
            lblFileName.AutoSize = true;
            lblFileName.Dock = DockStyle.Bottom;
            lblFileName.ForeColor = SystemColors.ActiveCaptionText;
            lblFileName.Location = new Point(0, 62);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(59, 25);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "label2";
            lblFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.Controls.Add(lblFileName);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(progressBar);
            panel1.Location = new Point(37, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 87);
            panel1.TabIndex = 5;
            // 
            // ProgressBarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 120);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveBorder;
            Name = "ProgressBarForm";
            Text = "ProgressBarForm";
            Load += ProgressBarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label lblStatus;
        private Label lblFileName;
        private Panel panel1;
    }
}