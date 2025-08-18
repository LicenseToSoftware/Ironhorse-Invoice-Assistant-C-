using System.Windows.Forms;

namespace Ironhorse_Invoice_Assistant_C_
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
                    SelectedSourcePath = folderBrowserSource.SelectedPath;
                    textBoxSource.Text = SelectedSourcePath;
                }
            }

        } // End Method SelectFolder_Click

        private void test_Click(object sender, EventArgs e)
        {

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
                    SelectedDestinationPath = folderBrowserDestination.SelectedPath;
                    textBoxDestination.Text = SelectedDestinationPath;
                }
            }
        } // End Method buttonSelectFolderDistination_Click
    } // End Class MainWindow
} // End Name Space Ironhorse_Invoice_Assistant_C_