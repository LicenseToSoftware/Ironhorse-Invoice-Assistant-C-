using IronhorseInvoiceAssistant.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IronhorseInvoiceAssistant.Services.ImageBatchProcessor;

namespace IronhorseInvoiceAssistant.Tests.Services
{
    [TestClass]
    public class ImageBatchProcessor_IntegrationTests
    {
        [TestMethod]
        public void ProcessFolder_SourceFolder_Blank_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                ImageBatchProcessor.ProcessFolder("   ", "C:\\est"));
        }

        [TestMethod]
        public void ProcessFolder_DestinationFolder_Blank_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                ImageBatchProcessor.ProcessFolder("C:\\src", "   "));
        }

        [TestMethod]
        public void ProcessFolder_SourceFolder_DoesNotExist_ThrowsDirectoryNotFoundException()
        {
            // Pick a path that should basically never exist
            string sourceFolder = Path.Combine(Path.GetTempPath(), "SOURCE_IH_DOES_NOT_EXIST_" + Guid.NewGuid());
            string destinationFolder = Path.Combine(Path.GetTempPath(), "DEST_IH_DOES_NOT_EXIST_" + Guid.NewGuid()); 

            Assert.ThrowsException<DirectoryNotFoundException>(() =>
                ImageBatchProcessor.ProcessFolder(sourceFolder, destinationFolder));
        }
    

        /*
        

                        if (!Directory.Exists(sourceFolder))
                            throw new DirectoryNotFoundException($"Source folder not found: {sourceFolder}");


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
        */
    }
}
