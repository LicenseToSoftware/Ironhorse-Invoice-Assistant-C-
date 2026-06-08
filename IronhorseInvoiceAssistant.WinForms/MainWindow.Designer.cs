namespace IronhorseInvoiceAssistant.WinForms
{
    partial class MainWindow
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
            lblCompletionReportAssistance = new Label();
            lblJobLog = new Label();
            btnCompletionReportAssistant = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblCompletionReportAssistance
            // 
            lblCompletionReportAssistance.AutoSize = true;
            lblCompletionReportAssistance.Location = new Point(150, 95);
            lblCompletionReportAssistance.Name = "lblCompletionReportAssistance";
            lblCompletionReportAssistance.Size = new Size(243, 25);
            lblCompletionReportAssistance.TabIndex = 0;
            lblCompletionReportAssistance.Text = "Completion Report Assistant:";
            // 
            // lblJobLog
            // 
            lblJobLog.AutoSize = true;
            lblJobLog.Location = new Point(304, 149);
            lblJobLog.Name = "lblJobLog";
            lblJobLog.Size = new Size(79, 25);
            lblJobLog.TabIndex = 1;
            lblJobLog.Text = "Job Log:";
            // 
            // btnCompletionReportAssistant
            // 
            btnCompletionReportAssistant.Location = new Point(460, 93);
            btnCompletionReportAssistant.Name = "btnCompletionReportAssistant";
            btnCompletionReportAssistant.Size = new Size(112, 34);
            btnCompletionReportAssistant.TabIndex = 2;
            btnCompletionReportAssistant.Text = "Rep Assis";
            btnCompletionReportAssistant.UseVisualStyleBackColor = true;
            btnCompletionReportAssistant.Click += btnCompletionReportAssistant_Click;
            // 
            // button1
            // 
            button1.Location = new Point(460, 149);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Job Log";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCompletionReportAssistant);
            Controls.Add(lblJobLog);
            Controls.Add(lblCompletionReportAssistance);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompletionReportAssistance;
        private Label lblJobLog;
        private Button btnCompletionReportAssistant;
        private Button button1;
    }
}