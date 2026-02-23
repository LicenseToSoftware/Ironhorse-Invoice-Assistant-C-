using IronhorseInvoiceAssistant.Models;
using IronhorseInvoiceAssistant.Services;
using SixLabors.ImageSharp.Processing;
using System.Drawing.Text;
using System.Numerics;

// TODO: for helper methods to be moved later

namespace IronhorseInvoiceAssistant
{
    public partial class MainWindow : Form
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateWidthHeightComboBox(sender, e);
            PopulateQualityComboBox(sender, e);
        }

        // Triggered when the "Select Source Folder" button is clicked
        private void SelectFolder_Click(object sender, EventArgs e)
        {
            PickFolder
                 (
                     description: "Select Source Folder",
                     onSelected: UpdateSourcePathUI
                 );
        } // End Method SelectFolder_Click

        // Triggered when the "Select Destination Folder" button is clicked
        private void buttonSelectFolderDistination_Click(object sender, EventArgs e)
        {
            PickFolder
                (
                    description: "Select Destination Folder",
                    onSelected: UpdateDestinationPathUI
                );
        } // End Method buttonSelectFolderDistination_Click

        private void PickFolder(string description, Action<string> onSelected)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = description,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                onSelected(dialog.SelectedPath);
            }
        }

        // Triggered when the "Resize Photos" button is clicked
        private async void resizePhoto_Click(object sender, EventArgs e)
        {
            string errorMessage;
            string messageBoxTitle;
            

            errorMessage = "Please select a valid source folder before processing.";
            messageBoxTitle = "No Valid Source Folder Selected";
            if (!ValidatePath(SelectedSourcePath, errorMessage, messageBoxTitle))
            {
                return;
            }

            errorMessage = "Please select a valid destination folder before processing.";
            messageBoxTitle = "No Valid Destination Folder Selected";
            if (!ValidatePath(SelectedDestinationPath, errorMessage, messageBoxTitle))
            {
                return;
            }

            var button = sender as Button;
            try
            {
                // UI feedback
                button?.Invoke(() => button.Enabled = false);
                var previousCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

                // Get the selected resize option from the combo box
                var selected = cmbxWidthHeight.SelectedItem as ResizeOption;
                int maxWidth = selected.Width;
                int maxHeight = selected.Length;

                // Get the selected image quality from the combo box
                var imageQuality = (int)cmbxImageQuality.SelectedItem;

                // Run processing off the UI thread
                var results = await Task.Run(() => ImageBatchProcessor.ProcessFolder(SelectedSourcePath, SelectedDestinationPath, maxWidth, maxHeight, imageQuality));

                ResizedResults(results);

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
            if (!IsDirectoryWritable(path))
            {
                MessageBox.Show("The selected destination folder is not writable. Please choose a different folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedDestinationPath = path;
            textBoxDestination.Text = path;
        } // End Method UpdateDestinationPathUI



        // Getters and Setters

        // Getter and Setter for SelectedSourcePath with validation to ensure it is not empty or whitespace, and trims the value before storing it
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

        private void labelResizeImage_Click(object sender, EventArgs e)
        {

        }

        // Getter and Setter for SelectedDestinationPath with validation to ensure it is not empty or whitespace, and trims the value before storing it
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
        // End Getters and Setters
        // Helper Methods

        // Helper method to check if a directory is writable by attempting to create and delete a temporary file within it
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

        // Validates that the provided path is not null, empty, or whitespace and shows an error message if it is invalid
        private bool ValidatePath(string SelectedPath, string ErrorMessage, string WindowTitle)
        {
            if (string.IsNullOrWhiteSpace(SelectedPath))
            {
                MessageBox.Show(
                    ErrorMessage,
                    WindowTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        // summarizes the results of the image resizing operation and displays appropriate messages to the user based on success and failure counts
        private void ResizedResults(List<ImageBatchProcessor.ImageProcessResult> results)
        {
            int total = results.Count;
            int success = results.Count(r => r.Success);
            int failed = total - success;

            if (total == 0)
            {
                ShowInfo($"No supported image files were found in the selected source folder:{SelectedSourcePath}", "No files");
                return;
            }

            if (failed == 0)
            {
                ShowInfo($"All {total} images were resized and saved to:\n{SelectedDestinationPath}", "Success");
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
                // FIXME: msg should only show jpeg right now, its handled by imagesharp.
                sb.AppendLine($"{Path.GetFileName(src)} - {msg}");
            }
            if (failedItems.Count > 25)
            {
                sb.AppendLine($"...and {failedItems.Count - 25} more.");
            }

            // Show the aggregated error information
            MessageBox.Show(sb.ToString(), "Partial Completion - Errors Occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ShowInfo(string message, string title) =>
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Populates the width and height combo box with predefined resize options and sets a default selection
        private void PopulateWidthHeightComboBox(object sender, EventArgs e)
        {
            var options = new List<ResizeOption>
            {
                new ResizeOption { Length = 1200, Width = 1200 },
                new ResizeOption { Length = 800, Width = 800 }
            };

            cmbxWidthHeight.DataSource = options;


            // Set a default (1200 x 1200)
            cmbxWidthHeight.SelectedItem = options.First(s => s.Length == 1200 && s.Width == 1200);
        }

        // Populates the image quality combo box with predefined quality values and sets a default selection
        private void PopulateQualityComboBox(object sender, EventArgs e)
        {
            cmbxImageQuality.DataSource = new List<int>
            {
                90, 80, 70, 60, 50, 40, 30, 20, 10
            };

            cmbxImageQuality.SelectedItem = 90;
        }

        private void cmbxWidthHeight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    } // End Class MainWindow
} // End Name Space IronhorseInvoiceAssistant