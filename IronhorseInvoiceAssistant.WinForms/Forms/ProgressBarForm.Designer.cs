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
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(302, 211);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(150, 34);
            progressBar.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(355, 273);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "label1";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(354, 305);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(59, 25);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "label2";
            // 
            // ProgressBarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFileName);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Name = "ProgressBarForm";
            Text = "ProgressBarForm";
            Load += ProgressBarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label lblStatus;
        private Label lblFileName;
    }
}