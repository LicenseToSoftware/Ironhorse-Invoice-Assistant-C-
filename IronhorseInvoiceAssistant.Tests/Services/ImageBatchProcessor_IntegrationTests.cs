using IronhorseInvoiceAssistant.Services;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
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

        [TestMethod]
        public void ProcessFolder_NoSupportedImages_ReturnsEmptyList()
        {
            // Arrange: create real temp source + destination folders
            string sourceFolder = Path.Combine(Path.GetTempPath(), "IH_SRC_" + Guid.NewGuid());
            string destinationFolder = Path.Combine(Path.GetTempPath(), "IH_DEST_" + Guid.NewGuid());

            Directory.CreateDirectory(sourceFolder);
            Directory.CreateDirectory(destinationFolder);

            try
            {
                // Put only unsupported files in source
                File.WriteAllText(Path.Combine(sourceFolder, "notes.txt"), "hello");
                File.WriteAllText(Path.Combine(sourceFolder, "data.csv"), "a,b,c");

                // Act
                var results = ImageBatchProcessor.ProcessFolder(sourceFolder, destinationFolder);

                // Assert
                Assert.IsNotNull(results);
                Assert.AreEqual(0, results.Count);
            }
            finally
            {
                // Cleanup
                Directory.Delete(sourceFolder, recursive: true);
                Directory.Delete(destinationFolder, recursive: true);
            }
        }

        [TestMethod]
        public void ProcessFolder_WithOnePng_CreatesJpegInDestination()
        {
            // Arrange
            string sourceFolder = Path.Combine(Path.GetTempPath(), "IH_SRC_" + Guid.NewGuid());
            string destinationFolder = Path.Combine(Path.GetTempPath(), "IH_DEST_" + Guid.NewGuid());

            Directory.CreateDirectory(sourceFolder);
            Directory.CreateDirectory(destinationFolder);

            try
            {
                // Create a real PNG in the source folder
                string srcPngPath = Path.Combine(sourceFolder, "sample.png");
                using (var img = new Image<Rgba32>(2000, 1500))
                {
                    img.Save(srcPngPath);
                }

                // Act
                var results = ImageBatchProcessor.ProcessFolder(
                    sourceFolder: sourceFolder,
                    destinationFolder: destinationFolder,
                    maxWidth: 1200,
                    maxHeight: 1200,
                    quality: 90,
                    includeSubfolders: false,
                    overwrite: true
                );

                // Assert: result list
                Assert.AreEqual(1, results.Count, "Expected exactly one file to be processed.");
                Assert.IsTrue(results[0].Success, $"Expected success. Error: {results[0].ErrorMessage}");

                // Assert: output file exists and is jpg
                string outPath = results[0].destinationFolder; // this is your dest file path
                Assert.IsTrue(File.Exists(outPath), $"Expected output file to exist: {outPath}");
                Assert.AreEqual(".jpg", Path.GetExtension(outPath).ToLowerInvariant());

                // Optional: verify it was resized to max bounds
                using var outImg = Image.Load(outPath);
                Assert.IsTrue(outImg.Width <= 1200, $"Expected width <= 1200, got {outImg.Width}");
                Assert.IsTrue(outImg.Height <= 1200, $"Expected height <= 1200, got {outImg.Height}");
            }
            finally
            {
                Directory.Delete(sourceFolder, recursive: true);
                Directory.Delete(destinationFolder, recursive: true);
            }
        }

        [TestMethod]
        public void ProcessFolder_OverwriteFalse_WhenOutputExists_Skips()
        {
            // Arrange
            string sourceFolder = Path.Combine(Path.GetTempPath(), "IH_SRC_" + Guid.NewGuid());
            string destinationFolder = Path.Combine(Path.GetTempPath(), "IH_DEST_" + Guid.NewGuid());

            Directory.CreateDirectory(sourceFolder);
            Directory.CreateDirectory(destinationFolder);

            try
            {
                // Create a source PNG
                string srcPngPath = Path.Combine(sourceFolder, "sample.png");
                using (var img = new Image<Rgba32>(800, 600))
                {
                    img.Save(srcPngPath);
                }

                // Act 1: First run creates the JPG
                var first = ImageBatchProcessor.ProcessFolder(
                    sourceFolder: sourceFolder,
                    destinationFolder: destinationFolder,
                    overwrite: true
                );

                Assert.AreEqual(1, first.Count);
                Assert.IsTrue(first[0].Success, $"First run should succeed. Error: {first[0].ErrorMessage}");

                // Act 2: Second run should skip because overwrite:false
                var second = ImageBatchProcessor.ProcessFolder(
                    sourceFolder: sourceFolder,
                    destinationFolder: destinationFolder,
                    overwrite: false
                );

                // Assert
                Assert.AreEqual(1, second.Count);
                Assert.IsFalse(second[0].Success, "Second run should be marked as not successful due to skip.");
                Assert.IsTrue(
                    second[0].ErrorMessage?.Contains("Skipped", StringComparison.OrdinalIgnoreCase) == true,
                    $"Expected 'Skipped' message but got: {second[0].ErrorMessage}"
                );

                // Also verify the destination file still exists
                Assert.IsTrue(File.Exists(first[0].destinationFolder));
            }
            finally
            {
                Directory.Delete(sourceFolder, recursive: true);
                Directory.Delete(destinationFolder, recursive: true);
            }
        }

    }
}
