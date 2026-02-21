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
        public sealed record ImageProcessResult(
            string sourceFolder,
            string destinationFolder,
            bool Success,
            string? ErrorMessage = null
            );

            public static List<ImageProcessResult> ProcessFolder
                (
                string sourceFolder,
                string destinationFolder,
                int maxWidth = 1200,
                int maxHeight = 1200,
                int quality = 90,
                bool includeSubfolders = false,
                bool overwrite = true
                )
            {
                if (string.IsNullOrWhiteSpace(sourceFolder))
                    throw new ArgumentException("Source folder is required.", nameof(sourceFolder));

                if (string.IsNullOrWhiteSpace(destinationFolder))
                    throw new ArgumentException("Destination folder is required.", nameof(destinationFolder));

                sourceFolder = sourceFolder.Trim();
                destinationFolder = destinationFolder.Trim();

                if (!Directory.Exists(sourceFolder) || !Directory.Exists(destinationFolder))
                    throw new DirectoryNotFoundException($"Source or Destination folder not found: {sourceFolder},{destinationFolder}");


                var supported = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                { ".jpg", ".jpeg", ".png", ".bmp" };

                var searchOption = includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

                var files = Directory.EnumerateFiles(sourceFolder, "*.*", searchOption)
                                     .Where(f => supported.Contains(Path.GetExtension(f)));


                var processor = new ImageProcessor();
                var results = new List<ImageProcessResult>();

                foreach (var file in files)
                {
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

                        results.Add(new ImageProcessResult(file, destPath, true));
                    }
                    catch (Exception ex)
                    {
                        results.Add(new ImageProcessResult(file, "", false, ex.Message));
                    }
                }

                return results;
            }
        }
    }
