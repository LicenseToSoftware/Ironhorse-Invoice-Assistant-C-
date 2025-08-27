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
            buttonResizeImages = new Button();
            textBoxSource = new RichTextBox();
            labelResizeImage = new Label();
            labelOutputLocation = new Label();
            textBoxDestination = new RichTextBox();
            buttonSelectFolderDistination = new Button();
            SuspendLayout();
            // 
            // SelectFolder
            // 
            SelectFolder.Location = new Point(115, 306);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(134, 51);
            SelectFolder.TabIndex = 0;
            SelectFolder.Text = "Select Folder";
            SelectFolder.UseVisualStyleBackColor = true;
            SelectFolder.Click += SelectFolder_Click;
            // 
            // buttonResizeImages
            // 
            buttonResizeImages.Location = new Point(336, 354);
            buttonResizeImages.Name = "buttonResizeImages";
            buttonResizeImages.Size = new Size(140, 51);
            buttonResizeImages.TabIndex = 1;
            buttonResizeImages.Text = "Resize Images";
            buttonResizeImages.UseVisualStyleBackColor = true;
            buttonResizeImages.Click += resizePhoto_Click;
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(64, 122);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(252, 178);
            textBoxSource.TabIndex = 2;
            textBoxSource.Text = "";
            textBoxSource.TextChanged += testOutput_TextChanged;
            // 
            // labelResizeImage
            // 
            labelResizeImage.AutoSize = true;
            labelResizeImage.Location = new Point(112, 85);
            labelResizeImage.Name = "labelResizeImage";
            labelResizeImage.Size = new Size(137, 25);
            labelResizeImage.TabIndex = 3;
            labelResizeImage.Text = "Selected Folder:";
            // 
            // labelOutputLocation
            // 
            labelOutputLocation.AutoSize = true;
            labelOutputLocation.Location = new Point(532, 97);
            labelOutputLocation.Name = "labelOutputLocation";
            labelOutputLocation.Size = new Size(177, 25);
            labelOutputLocation.TabIndex = 6;
            labelOutputLocation.Text = "Selected Destination:";
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(490, 125);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(252, 178);
            textBoxDestination.TabIndex = 5;
            textBoxDestination.Text = "";
            // 
            // buttonSelectFolderDistination
            // 
            buttonSelectFolderDistination.Location = new Point(553, 318);
            buttonSelectFolderDistination.Name = "buttonSelectFolderDistination";
            buttonSelectFolderDistination.Size = new Size(134, 51);
            buttonSelectFolderDistination.TabIndex = 4;
            buttonSelectFolderDistination.Text = "Select Folder";
            buttonSelectFolderDistination.UseVisualStyleBackColor = true;
            buttonSelectFolderDistination.Click += buttonSelectFolderDistination_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOutputLocation);
            Controls.Add(textBoxDestination);
            Controls.Add(buttonSelectFolderDistination);
            Controls.Add(labelResizeImage);
            Controls.Add(textBoxSource);
            Controls.Add(buttonResizeImages);
            Controls.Add(SelectFolder);
            Name = "MainWindow";
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectFolder;
        private Button buttonResizeImages;
        private RichTextBox textBoxSource;
        private Label labelResizeImage;
        private Label labelOutputLocation;
        private RichTextBox textBoxDestination;
        private Button buttonSelectFolderDistination;
    }
}
