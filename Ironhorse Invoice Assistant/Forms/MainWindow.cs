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
                    UpdateSourcePathUI(folderBrowserSource.SelectedPath);
                }
            }

        } // End Method SelectFolder_Click

        // Triggered when the "Select Destination Folder" button is clicked
        private void buttonSelectFolderDistination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDestination = new FolderBrowserDialog())
            {
                folderBrowserDestination.Description = "Select Distination Folder";
                if (folderBrowserDestination.ShowDialog() == DialogResult.OK)
                {
                    UpdateDestinationPathUI(folderBrowserDestination.SelectedPath);
                }
            }
        } // End Method buttonSelectFolderDistination_Click


        // Triggered when the "Resize Photos" button is clicked
        private async void resizePhoto_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrWhiteSpace(SelectedSourcePath) || string.IsNullOrWhiteSpace(SelectedDestinationPath))
                {
                    MessageBox.Show("Please select both source and destination folders before processing.", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }
               


            var button = sender as Button;
            try
            {
                // UI feedback
                button?.Invoke(() => button.Enabled = false);
                var previousCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

                // Run processing off the UI thread
                var results = await Task.Run(() => ImageBatchProcessor.ProcessFolder(SelectedSourcePath, SelectedDestinationPath));

                int total = results.Count;
                int success = results.Count(r => r.Success);
                int failed = total - success;

                if (total == 0)
                {
                    MessageBox.Show("No supported image files were found in the selected source folder.", "No files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (failed == 0)
                {
                    MessageBox.Show($"All {total} images were resized and saved to:\n{SelectedDestinationPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Some failed — show summary and details
                var failedItems = results.Where(r => !r.Success).ToList();
                var sb = new System.Text.StringBuilder();
                sb.AppendLine($"Resized {success} of {total} images. {failed} failed.");
                sb.AppendLine();
                sb.AppendLine("Errors (Showing the first 25 that failed):");
                foreach (var item in failedItems.Take(25))
                {
                    var src = string.IsNullOrEmpty(item.sourceFolder) ? "(unknown source)" : item.sourceFolder;
                    var msg = string.IsNullOrEmpty(item.ErrorMessage) ? "(no message)" : item.ErrorMessage;
                    sb.AppendLine($"{Path.GetFileName(src)} - {msg}");
                }
                if (failedItems.Count > 25)
                {
                    sb.AppendLine($"...and {failedItems.Count - 25} more.");
                }

                // Show the aggregated error information
                MessageBox.Show(sb.ToString(), "Partial Completion - Errors Occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                button?.Invoke(() => button.Enabled = true);
                Cursor.Current = Cursors.Default;
            }

        } // End Method resizePhoto_Click

        private void testOutput_TextChanged(object sender, EventArgs e)
        {

        } // End Method testOutput_TextChanged

        // Triggered when the "Select Destination Folder" button is clicked

        // Helper methods to update the UI with the selected paths and validate them
        private void UpdateSourcePathUI(string path)
        {
            SelectedSourcePath = path;
            textBoxSource.Text = path;
        } // End Method UpdateSourcePathUI

        private void UpdateDestinationPathUI(string path)
        {
            if (!IsDirectoryWritable(path)) { 
                MessageBox.Show("The selected destination folder is not writable. Please choose a different folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedDestinationPath = path;
            textBoxDestination.Text = path;
        } // End Method UpdateDestinationPathUI

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
        } // End Method IsDirectoryWritable

        // Getters and Setters
        // Stores the user's selected source and destination folder paths

        private string _selectedSourcePath = string.Empty;
        public string SelectedSourcePath
        {
            get => _selectedSourcePath;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Source path cannot be empty.", nameof(SelectedSourcePath));
                _selectedSourcePath = value.Trim();
            }
        }

        private string _selectedDestinationPath = string.Empty;
        public string SelectedDestinationPath
        {
            get => _selectedDestinationPath;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Destination path cannot be empty.", nameof(SelectedDestinationPath));
                _selectedDestinationPath = value.Trim();
            }
        }
        // end Getters and Setters


    } // End Class MainWindow







} // End Name Space IronhorseInvoiceAssistant