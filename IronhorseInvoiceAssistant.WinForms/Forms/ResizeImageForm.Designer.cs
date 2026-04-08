namespace IronhorseInvoiceAssistant.WinForms.Forms
{
    partial class ResizeImageForm
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
            SelectFolder.Location = new Point(75, 199);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(147, 57);
            SelectFolder.TabIndex = 0;
            SelectFolder.Text = "Select Folder";
            SelectFolder.UseVisualStyleBackColor = true;
            SelectFolder.Click += SelectFolder_Click;
            // 
            // buttonResizeImages
            // 
            buttonResizeImages.BackColor = Color.WhiteSmoke;
            buttonResizeImages.Location = new Point(335, 164);
            buttonResizeImages.Name = "buttonResizeImages";
            buttonResizeImages.Size = new Size(154, 57);
            buttonResizeImages.TabIndex = 1;
            buttonResizeImages.Text = "Resize Images";
            buttonResizeImages.UseVisualStyleBackColor = false;
            buttonResizeImages.Click += resizePhoto_Click;
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(12, 290);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(277, 199);
            textBoxSource.TabIndex = 2;
            textBoxSource.Text = "";
            // 
            // labelSelectedImage
            // 
            labelSelectedImage.AutoSize = true;
            labelSelectedImage.Location = new Point(71, 259);
            labelSelectedImage.Name = "labelSelectedImage";
            labelSelectedImage.Size = new Size(151, 28);
            labelSelectedImage.TabIndex = 3;
            labelSelectedImage.Text = "Selected Folder:";
            // 
            // labelOutputLocation
            // 
            labelOutputLocation.AutoSize = true;
            labelOutputLocation.Location = new Point(640, 260);
            labelOutputLocation.Name = "labelOutputLocation";
            labelOutputLocation.Size = new Size(195, 28);
            labelOutputLocation.TabIndex = 6;
            labelOutputLocation.Text = "Selected Destination:";
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(591, 293);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(277, 199);
            textBoxDestination.TabIndex = 5;
            textBoxDestination.Text = "";
            // 
            // buttonSelectFolderDistination
            // 
            buttonSelectFolderDistination.Location = new Point(653, 199);
            buttonSelectFolderDistination.Name = "buttonSelectFolderDistination";
            buttonSelectFolderDistination.Size = new Size(147, 57);
            buttonSelectFolderDistination.TabIndex = 4;
            buttonSelectFolderDistination.Text = "Select Folder";
            buttonSelectFolderDistination.UseVisualStyleBackColor = true;
            buttonSelectFolderDistination.Click += SelectFolderDistination_Click;
            // 
            // txtWidthHeight
            // 
            txtWidthHeight.AutoSize = true;
            txtWidthHeight.Location = new Point(255, 83);
            txtWidthHeight.Name = "txtWidthHeight";
            txtWidthHeight.Size = new Size(148, 28);
            txtWidthHeight.TabIndex = 10;
            txtWidthHeight.Text = "Width x Height:";
            // 
            // txtImageQuality
            // 
            txtImageQuality.AutoSize = true;
            txtImageQuality.Location = new Point(265, 125);
            txtImageQuality.Name = "txtImageQuality";
            txtImageQuality.Size = new Size(138, 28);
            txtImageQuality.TabIndex = 12;
            txtImageQuality.Text = "Image Quality:";
            // 
            // cmbxWidthHeight
            // 
            cmbxWidthHeight.AllowDrop = true;
            cmbxWidthHeight.FormattingEnabled = true;
            cmbxWidthHeight.Location = new Point(411, 80);
            cmbxWidthHeight.Name = "cmbxWidthHeight";
            cmbxWidthHeight.Size = new Size(200, 36);
            cmbxWidthHeight.TabIndex = 13;
            // 
            // cmbxImageQuality
            // 
            cmbxImageQuality.FormattingEnabled = true;
            cmbxImageQuality.Location = new Point(411, 122);
            cmbxImageQuality.Name = "cmbxImageQuality";
            cmbxImageQuality.Size = new Size(200, 36);
            cmbxImageQuality.TabIndex = 14;
            // 
            // ResizeImageForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 504);
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
            Name = "ResizeImageForm";
            Text = "Resize Photos";
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
