namespace Ironhorse_Invoice_Assistant_C_
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectFolder = new Button();
            test = new Button();
            testOutput = new RichTextBox();
            SuspendLayout();
            // 
            // SelectFolder
            // 
            SelectFolder.Location = new Point(343, 251);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(134, 51);
            SelectFolder.TabIndex = 0;
            SelectFolder.Text = "Select Folder";
            SelectFolder.UseVisualStyleBackColor = true;
            SelectFolder.Click += SelectFolder_Click;
            // 
            // test
            // 
            test.Location = new Point(454, 116);
            test.Name = "test";
            test.Size = new Size(112, 34);
            test.TabIndex = 1;
            test.Text = "button1";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // testOutput
            // 
            testOutput.Location = new Point(164, 48);
            testOutput.Name = "testOutput";
            testOutput.Size = new Size(252, 178);
            testOutput.TabIndex = 2;
            testOutput.Text = "";
            testOutput.TextChanged += testOutput_TextChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testOutput);
            Controls.Add(test);
            Controls.Add(SelectFolder);
            Name = "MainWindow";
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SelectFolder;
        private Button test;
        private RichTextBox testOutput;
    }
}
