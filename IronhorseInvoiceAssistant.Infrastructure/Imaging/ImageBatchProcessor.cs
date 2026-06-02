using IronhorseInvoiceAssistant.Domain.Models;
using IronhorseInvoiceAssistant.Infrastructure.Common;

namespace IronhorseInvoiceAssistant.Infrastructure.Imaging
{
    /// <summary>
    /// Provides methods to process batches of images, including resizing and format conversion.
    /// </summary>
    public static class ImageBatchProcessor
    {
        /// <summary>
        /// Resizes all supported image files in the source folder and saves them to the destination folder.
        /// </summary>
        /// <param name="sourceFolder">The folder containing original images.</param>
        /// <param name="destinationFolder">The folder to save resized images.</param>
        /// <param name="resizeWidth">Width to resize to (default = 800).</param>
        /// <param name="resizeHeight">Height to resize to (default = 600).</param>
        public sealed record ImageProcessResult(
            string sourceFolder,
            string destinationFolder,
            bool Success,
            string? ErrorMessage = null
            );

        /// <summary>
        /// Processes all supported image files in the specified folder, resizing and converting them as needed.
        /// </summary>
        /// <param name="sourceFolder">The folder containing original images.</param>
        /// <param name="destinationFolder">The folder to save processed images.</param>
        /// <param name="maxWidth">The maximum width for resized images (default = 1200).</param>
        /// <param name="maxHeight">The maximum height for resized images (default = 1200).</param>
        /// <param name="quality">The quality for JPEG images (default = 90).</param>
        /// <param name="includeSubfolders">Whether to include subfolders (default = false).</param>
        /// <param name="overwrite">Whether to overwrite existing files (default = true).</param>
        /// <returns>A list of results for each processed image.</returns>
        public static List<ImageProcessResult> ProcessFolder(
                string sourceFolder,
                string destinationFolder,
                int maxWidth = 1200,
                int maxHeight = 1200,
                int quality = 90,
                bool includeSubfolders = false,
                bool overwrite = true,
                IProgress<ImageBatchProgress>? progress = null
                )
        {
            {
                // Validate inputs
                Guard.AgainstNullOrWhiteSpace(sourceFolder, nameof(sourceFolder));
                Guard.AgainstNullOrWhiteSpace(destinationFolder, nameof(destinationFolder));
                sourceFolder = sourceFolder.Trim();
                destinationFolder = destinationFolder.Trim();
                Guard.EnsureDirectoryExist(sourceFolder);
                Guard.EnsureDirectoryExist(destinationFolder);

                var files = GetSupportedImageFiles(sourceFolder, includeSubfolders);

                var processor = new ImageProcessor();
                var results = new List<ImageProcessResult>();
                int totalFiles = files.Count;
                int currentFileIndex = 0;
                // Report initial progress (0% with no file name)
                foreach (var file in files)
                {
                    currentFileIndex++;


                    try
                    {
                        // TODO - Build a system to distuinguish between different image formats and only convert to JPEG if necessary. For now, we'll just convert everything to JPEG since that's what our downstream process expects.
                        // Keep same filename, but force .jpg extension since we're saving JPEG
                        var destPath = BuildDestinationPathJPG(file, destinationFolder);

                        if (!overwrite && File.Exists(destPath))
                        {
                            results.Add(new ImageProcessResult(file, destPath, false, "Skipped (already exists)."));
                            continue;
                        }

                        processor.ReduceAndSaveJpeg(
                            sourcePath: file,
                            destinationPath: destPath,
                            maxWidth: maxWidth,
                            maxHeight: maxHeight,
                            quality: quality
                        );

                        results.Add(new ImageProcessResult(
                            file,
                            destPath,
                            true)
                        );
                    }
                    catch (Exception ex)
                    {
                        results.Add(new ImageProcessResult(
                            file,
                            "",
                            false,
                            ex.Message));
                    }
                    // Report progress after processing each file
                    progress?.Report(new ImageBatchProgress(
                        CurrentFileIndex: currentFileIndex,
                        TotalFileIndex: totalFiles,
                        CurrentFileName: Path.GetFileName(file)
                    ));
                }
                return results;
            }
        }

        /// <summary>
        /// Builds the destination file path for a processed image, ensuring it has a .jpg extension and is located in the specified destination folder.
        /// </summary>
        /// <param name="sourceFile">The source image file path.</param>
        /// <param name="destinationFolder">The destination folder where the processed image will be saved.</param>
        /// <returns>The full path of the destination image file.</returns>
        private static string BuildDestinationPathJPG(string sourceFile, string destinationFolder)
        {
            var destFileName = Path.ChangeExtension(Path.GetFileName(sourceFile), ".jpg");
            return Path.Combine(destinationFolder, destFileName);
        }

        /// <summary>
        /// Gets a list of supported image files from the specified folder, optionally including subfolders.
        /// </summary>
        /// <param name="folder">The folder to search for image files.</param>
        /// <param name="includeSubfolders">Whether to include subfolders in the search.</param>
        /// <returns>A list of supported image file paths.</returns>
        private static List<string> GetSupportedImageFiles(string folder, bool includeSubfolders)
        {
            var supported = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                { ".jpg", ".jpeg", ".png", ".bmp" };

            var searchOption = includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            return Directory.EnumerateFiles(folder, "*.*", searchOption)
                                 .Where(f => supported.Contains(Path.GetExtension(f))).ToList();

        }
    }
}
