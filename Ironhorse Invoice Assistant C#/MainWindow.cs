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
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            {
                folderBrowserDialog.ShowDialog();
                selectedpath = folderBrowserDialog.SelectedPath;
                testOutput.Text = selectedpath;
            }

        }

        private void test_Click(object sender, EventArgs e)
        {
    
        }

        private void testOutput_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}