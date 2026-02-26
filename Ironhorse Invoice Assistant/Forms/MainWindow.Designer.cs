namespace IronhorseInvoiceAssistant
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
            labelSelectedImage = new Label();
            labelOutputLocation = new Label();
            textBoxDestination = new RichTextBox();
            buttonSelectFolderDistination = new Button();
            txtWidthHeight = new Label();
            txtImageQuality = new Label();
            cmbxWidthHeight = new ComboBox();
            cmbxImageQuality = new ComboBox();
            SuspendLayout();
            // 
            // SelectFolder
            // 
            SelectFolder.Location = new Point(68, 178);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(134, 51);
            SelectFolder.TabIndex = 0;
            SelectFolder.Text = "Select Folder";
            SelectFolder.UseVisualStyleBackColor = true;
            SelectFolder.Click += SelectFolder_Click;
            // 
            // buttonResizeImages
            // 
            buttonResizeImages.Location = new Point(330, 364);
            buttonResizeImages.Name = "buttonResizeImages";
            buttonResizeImages.Size = new Size(140, 51);
            buttonResizeImages.TabIndex = 1;
            buttonResizeImages.Text = "Resize Images";
            buttonResizeImages.UseVisualStyleBackColor = true;
            buttonResizeImages.Click += resizePhoto_Click;
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(12, 260);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(252, 178);
            textBoxSource.TabIndex = 2;
            textBoxSource.Text = "";
            // 
            // labelSelectedImage
            // 
            labelSelectedImage.AutoSize = true;
            labelSelectedImage.Location = new Point(68, 232);
            labelSelectedImage.Name = "labelSelectedImage";
            labelSelectedImage.Size = new Size(137, 25);
            labelSelectedImage.TabIndex = 3;
            labelSelectedImage.Text = "Selected Folder:";
            // 
            // labelOutputLocation
            // 
            labelOutputLocation.AutoSize = true;
            labelOutputLocation.Location = new Point(594, 246);
            labelOutputLocation.Name = "labelOutputLocation";
            labelOutputLocation.Size = new Size(177, 25);
            labelOutputLocation.TabIndex = 6;
            labelOutputLocation.Text = "Selected Destination:";
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(555, 274);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(252, 178);
            textBoxDestination.TabIndex = 5;
            textBoxDestination.Text = "";
            // 
            // buttonSelectFolderDistination
            // 
            buttonSelectFolderDistination.Location = new Point(615, 192);
            buttonSelectFolderDistination.Name = "buttonSelectFolderDistination";
            buttonSelectFolderDistination.Size = new Size(134, 51);
            buttonSelectFolderDistination.TabIndex = 4;
            buttonSelectFolderDistination.Text = "Select Folder";
            buttonSelectFolderDistination.UseVisualStyleBackColor = true;
            buttonSelectFolderDistination.Click += SelectFolderDistination_Click;
            // 
            // txtWidthHeight
            // 
            txtWidthHeight.AutoSize = true;
            txtWidthHeight.Location = new Point(189, 83);
            txtWidthHeight.Name = "txtWidthHeight";
            txtWidthHeight.Size = new Size(135, 25);
            txtWidthHeight.TabIndex = 10;
            txtWidthHeight.Text = "Width x Height:";
            // 
            // txtImageQuality
            // 
            txtImageQuality.AutoSize = true;
            txtImageQuality.Location = new Point(227, 167);
            txtImageQuality.Name = "txtImageQuality";
            txtImageQuality.Size = new Size(127, 25);
            txtImageQuality.TabIndex = 12;
            txtImageQuality.Text = "Image Quality:";
            // 
            // cmbxWidthHeight
            // 
            cmbxWidthHeight.AllowDrop = true;
            cmbxWidthHeight.FormattingEnabled = true;
            cmbxWidthHeight.Location = new Point(330, 80);
            cmbxWidthHeight.Name = "cmbxWidthHeight";
            cmbxWidthHeight.Size = new Size(182, 33);
            cmbxWidthHeight.TabIndex = 13;
            // 
            // cmbxImageQuality
            // 
            cmbxImageQuality.FormattingEnabled = true;
            cmbxImageQuality.Location = new Point(360, 164);
            cmbxImageQuality.Name = "cmbxImageQuality";
            cmbxImageQuality.Size = new Size(182, 33);
            cmbxImageQuality.TabIndex = 14;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbxImageQuality);
            Controls.Add(cmbxWidthHeight);
            Controls.Add(txtImageQuality);
            Controls.Add(txtWidthHeight);
            Controls.Add(labelOutputLocation);
            Controls.Add(textBoxDestination);
            Controls.Add(buttonSelectFolderDistination);
            Controls.Add(labelSelectedImage);
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
        private Label labelSelectedImage;
        private Label labelOutputLocation;
        private RichTextBox textBoxDestination;
        private Button buttonSelectFolderDistination;
        private Label txtWidthHeight;
        private Label txtImageQuality;
        private ComboBox cmbxWidthHeight;
        private ComboBox cmbxImageQuality;
    }
}
