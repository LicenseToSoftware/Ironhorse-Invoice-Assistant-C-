using IronhorseInvoiceAssistant.Infrastructure;
using IronhorseInvoiceAssistant.Models;
using IronhorseInvoiceAssistant.Services;
using SixLabors.ImageSharp.Processing;
using System.Drawing.Text;
using System.Numerics;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            var settings = SettingsSevice.Load();

            MessageBox.Show(settings?.LastSourcePath ?? "No source path saved.");
            SettingsPath.EnsureUserSettingsFile();
            PopulateWidthHeightComboBox(sender, e);
            PopulateQualityComboBox(sender, e);

        }

        /// <summary>
        /// Handles the click event to prompt the user to select a source folder and updates the UI with the selected
        /// path.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void SelectFolder_Click(object sender, EventArgs e)
        {
            PickFolder
                 (
                     description: "Select Source Folder",
                     onSelected: UpdateSourcePathUI
                 );
        } // End Method SelectFolder_Click

        /// <summary>
        /// Opens a folder selection dialog allowing the user to choose the destination folder
        /// where processed images will be saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFolderDistination_Click(object sender, EventArgs e)
        {
            PickFolder
                (
                    description: "Select Destination Folder",
                    onSelected: UpdateDestinationPathUI
                );
        } // End Method SelectFolderDistination_Click

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
                ImageSettings settings = GetImageProcessingSettings(cmbxWidthHeight, cmbxImageQuality);

                // Run processing off the UI thread
                var results = await Task.Run(() => ImageBatchProcessor.ProcessFolder
                (
                    SelectedSourcePath,
                    SelectedDestinationPath,
                    settings.MaxWidth,
                    settings.MaxHeight,
                    settings.imageQuality
                ));
                ResizedResults(results);

            }
            finally
            {
                button?.Invoke(() => button.Enabled = true);
                Cursor.Current = Cursors.Default;
            }

        } // End Method resizePhoto_Click

        // Getters and Setters

        /// <summary>
        /// Stores the currently selected source path.
        /// </summary>
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
        /// <summary>
        /// Gets the currently selected destination path.
        /// </summary>
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

        //Sealed Records
        /// <summary>
        /// Represents settings for image processing, including maximum dimensions and quality.
        /// </summary>
        /// <param name="MaxWidth">The maximum allowed width for the image, in pixels.</param>
        /// <param name="MaxHeight">The maximum allowed height for the image, in pixels.</param>
        /// <param name="imageQuality">The quality level of the image, typically as a percentage.</param>
        private sealed record ImageSettings(
                int MaxWidth,
                int MaxHeight,
                int imageQuality
                );

        private static ImageSettings GetImageProcessingSettings(ComboBox widthHeightComboBox, ComboBox imageQualityComboBox)
        {
            // Get the selected resize option from the combo box
            var selected = widthHeightComboBox.SelectedItem as ResizeOption ?? throw new InvalidOperationException("Resize Width x Height of image not selected");

            // Get the selected image quality from the combo box
            int imageQuality = (int)imageQualityComboBox.SelectedItem;

            return new ImageSettings(
                selected.Width,
                selected.Height,
                imageQuality
                );
        }

        /// <summary>
        /// Determines whether the specified directory is writable by attempting to create and delete a temporary file.
        /// </summary>
        /// <param name="dirPath">The path of the directory to check for write access.</param>
        /// <returns>true if the directory is writable; otherwise, false.</returns>
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

        /// <summary>
        /// Validates that the specified path is not null, empty, or whitespace and displays an error message if
        /// invalid.
        /// </summary>
        /// <param name="SelectedPath">The path to validate.</param>
        /// <param name="ErrorMessage">The error message to display if the path is invalid.</param>
        /// <param name="WindowTitle">The title of the error message window.</param>
        /// <returns>true if the path is valid; otherwise, false.</returns>
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

        /// <summary>
        /// Displays a summary of image processing results, including success and failure counts, and shows detailed
        /// error information if any images failed to process.
        /// </summary>
        /// <param name="results">A list of image processing results to summarize.</param>
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

        // Combo Box Population Methods

        /// <summary>
        /// s Populates the width and height combo box with predefined resize options (1200x1200 and 800x800) and sets a default selection to 1200x1200
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateWidthHeightComboBox(object sender, EventArgs e)
        {
            var options = new List<ResizeOption>
            {
                new ResizeOption { Height = 1200, Width = 1200 },
                new ResizeOption { Height = 800, Width = 800 }
            };

            cmbxWidthHeight.DataSource = options;


            // Set a default (1200 x 1200)
            cmbxWidthHeight.SelectedItem = options.First(s => s.Height == 1200 && s.Width == 1200);
        }

        /// <summary>
        /// Populates the image quality combo box with predefined quality values and sets the default selection.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void PopulateQualityComboBox(object sender, EventArgs e)
        {
            cmbxImageQuality.DataSource = new List<int>
            {
                90, 80, 70, 60, 50, 40, 30, 20, 10
            };

            cmbxImageQuality.SelectedItem = 90;
        }

        // Triggered when the "Select Destination Folder" button is clicked
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
    } // End Class MainWindow
} // End Name Space IronhorseInvoiceAssistant