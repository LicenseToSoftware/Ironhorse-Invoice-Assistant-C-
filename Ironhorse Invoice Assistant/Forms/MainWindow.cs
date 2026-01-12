using IronhorseInvoiceAssistant.Services;
using System.Windows.Forms;

// TODO: for helper methods to be moved later
using System;
using System.IO;
using System.Linq;

namespace IronhorseInvoiceAssistant
{
    public partial class MainWindow : Form
    {
        // Stores the user's selected source and destination folder paths
        public string SelectedSourcePath { get; private set; } = string.Empty;
        public string SelectedDestinationPath { get; private set; } = string.Empty;

        // Constructor: Initializes UI components
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Triggered when the "Select Source Folder" button is clicked
        private void SelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserSource = new FolderBrowserDialog())
            {
                folderBrowserSource.Description = "Select Source Folder";
                if (folderBrowserSource.ShowDialog() == DialogResult.OK)
                {
                    SetSourcePath(folderBrowserSource.SelectedPath);
                }
            }

        } // End Method SelectFolder_Click

        // TODO: fix this method, i need to make show folders are able to be read and write!
        private void resizePhoto_Click(object sender, EventArgs e)
        {
            ImageBatchProcessor.ProcessFolder(SelectedSourcePath, SelectedDestinationPath);
        } 

        private void testOutput_TextChanged(object sender, EventArgs e)
        {

        } // End Method testOutput_TextChanged

        // Triggered when the "Select Destination Folder" button is clicked
        private void buttonSelectFolderDistination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDestination = new FolderBrowserDialog())
            {
                folderBrowserDestination.Description = "Select Distination Folder";
                if (folderBrowserDestination.ShowDialog() == DialogResult.OK)
                {
                    SetDestinationPath(folderBrowserDestination.SelectedPath);
                }
            }
        } // End Method buttonSelectFolderDistination_Click
         
        // setters
        private void SetSourcePath(string path)
        {
            SelectedSourcePath = path;
            textBoxSource.Text = path;
        }

        private void SetDestinationPath(string path)
        {
            if (!IsDirectoryWritable(path)) { 
                MessageBox.Show("The selected destination folder is not writable. Please choose a different folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedDestinationPath = path;
            textBoxDestination.Text = path;
        }

        // TODO: for helper methods to be moved later
        // None UI move to another class later helper methods
        public static bool IsDirectoryWritable(string dirPath)
        {
            try
            {
                string testFile = Path.Combine(dirPath, Path.GetRandomFileName());
                using (FileStream fs = File.Create(testFile, 1, FileOptions.DeleteOnClose))
                {
                    // If we got here, it's writable
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


    } // End Class MainWindow







} // End Name Space IronhorseInvoiceAssistant