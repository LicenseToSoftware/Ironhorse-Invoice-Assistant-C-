using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace IronhorseInvoiceAssistant.Services
{
    public static class ImageBatchProcessor
    {
        /// <summary>
        /// Resizes all supported image files in the source folder and saves them to the destination folder.
        /// </summary>
        /// <param name="sourceFolder">The folder containing original images.</param>
        /// <param name="destinationFolder">The folder to save resized images.</param>
        /// <param name="resizeWidth">Width to resize to (default = 800).</param>
        /// <param name="resizeHeight">Height to resize to (default = 600).</param>
        public static void ProcessFolder(string sourceFolder, string destinationFolder)
        {
            sourceFolder = sourceFolder.Trim();
            destinationFolder = destinationFolder.Trim();
            int resizeWidth = 800;
            int resizeHeight = 600;
            try
            {
                if (!Directory.Exists(sourceFolder))
                {
                    MessageBox.Show("Source folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Directory.Exists(destinationFolder))
                {
                    MessageBox.Show("Destination folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var supportedExtensions = new[] { ".jpg", ".jpeg", ".png", ".bmp" };
                var files = Directory.GetFiles(sourceFolder)
                                     .Where(f => supportedExtensions.Contains(Path.GetExtension(f).ToLower()));

                foreach (var file in files)
                {
                    try
                    {
                        using (var image = SixLabors.ImageSharp.Image.Load(file))
                        {
                            image.Mutate(x => x.Resize(resizeWidth, resizeHeight));

                            string fileName = Path.GetFileName(file);
                            string destinationPath = Path.Combine(destinationFolder, fileName);

                            image.Save(destinationPath, new JpegEncoder { Quality = 85 }); // You can tweak Quality
                        }
                    }
                    catch (UnauthorizedAccessException uaEx)
                    {
                        MessageBox.Show($"Access denied to file: {file}\n\n{uaEx.Message}", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"I/O error with file: {file}\n\n{ioEx.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error processing file: {file}\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Image processing complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatal error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

