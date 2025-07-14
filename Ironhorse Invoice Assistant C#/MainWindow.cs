using System.Windows.Forms;

namespace Ironhorse_Invoice_Assistant_C_
{
    public partial class MainWindow : Form
    {
        new string selectedpath = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserSource = new FolderBrowserDialog();
            {
                folderBrowserSource.ShowDialog();
                selectedpath = folderBrowserSource.SelectedPath;
                textBoxSource.Text = selectedpath;
            }

        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void testOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectFolderDistination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDestination = new FolderBrowserDialog();
            {
                folderBrowserDestination.ShowDialog();
                selectedpath = folderBrowserDestination.SelectedPath;
                textBoxDestination.Text = selectedpath;
            }
        }
    }
}