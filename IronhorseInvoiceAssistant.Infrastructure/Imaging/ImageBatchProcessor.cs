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
        public static List<ImageProcessResult> ProcessFolder
                (
                string sourceFolder,
                string destinationFolder,
                int maxWidth = 1200,
                int maxHeight = 1200,
                int quality = 90,
                bool includeSubfolders = false,
                bool overwrite = true,
                IProgress<ImageBatchProgress>? progress = null
                ){
            {
                // Validate inputs
                Guard.AgainstNullOrWhiteSpace(sourceFolder, nameof(sourceFolder));
                Guard.AgainstNullOrWhiteSpace(destinationFolder, nameof(destinationFolder));
                sourceFolder = sourceFolder.Trim();
                destinationFolder = destinationFolder.Trim();
                Guard.EnsureDirectoryExist(sourceFolder);
                Guard.EnsureDirectoryExist(destinationFolder);

                var supported = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                { ".jpg", ".jpeg", ".png", ".bmp" };

                var searchOption = includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

                var files = Directory.EnumerateFiles(sourceFolder, "*.*", searchOption)
                                     .Where(f => supported.Contains(Path.GetExtension(f))).ToList();

                var processor = new ImageProcessor();
                var results = new List<ImageProcessResult>();
                int totalFiles = files.Count;
                int currentFileIndex = 0;
                // Report initial progress (0% with no file name)
                foreach (var file in files)
                {
                    currentFileIndex++;

                    progress?.Report(new ImageBatchProgress(
                        CurrentFileIndex: currentFileIndex,
                        TotalFileIndex: totalFiles,
                        CurrentFileName: Path.GetFileName(file)
                    ));
                    try
                    {
                        // Keep same filename, but force .jpg extension since we're saving JPEG
                        var destFileName = Path.ChangeExtension(Path.GetFileName(file), ".jpg");
                        var destPath = Path.Combine(destinationFolder, destFileName);

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
                }
                return results;
            }
        }



    }
}
