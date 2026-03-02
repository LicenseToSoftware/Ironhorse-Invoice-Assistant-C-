using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using SharpImage = SixLabors.ImageSharp.Image;

using IronhorseInvoiceAssistant.Infrastructure.Common;

namespace IronhorseInvoiceAssistant.Infrastructure.Imaging
{
    public class ImageProcessor
    {
        public void ReduceAndSaveJpeg
            (
            string sourcePath, 
            string destinationPath,
            int maxWidth = 1200,
            int maxHeight = 1200,
            int quality = 20 // range 0–100, higher = better quality, larger file
            )
        {

            Guard.AgainstNullOrWhiteSpace(sourcePath, nameof(sourcePath));
            Guard.AgainstNullOrWhiteSpace(destinationPath, nameof(destinationPath));
            Guard.AgainstFileNotFound(sourcePath, $"Source image not found, can not resize image.");
            // FIXME Ensure destination directory does not hold the filepath in the stringname Guard.EnsureDirectoryExist(destinationPath);
            Guard.AgainstOutOfRange(quality, 0, 100, "JPEG quality must be 0–100.", nameof(quality));
            Guard.AgainstLessThanOrEqualToZero(maxWidth, nameof(maxWidth));
            Guard.AgainstLessThanOrEqualToZero(maxHeight, nameof(maxHeight));
            // Placeholder for image resizing logic
            // This method should resize the image at sourcePath to the specified quality
            // and save it to destinationPath.
            // Implementation would typically use an image processing library like ImageSharp or System.Drawing.

            /*
            // Error checking
            

            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException(nameof(quality), "JPEG quality must be 0–100.");

            if (maxWidth <= 0 || maxHeight <= 0)
                throw new ArgumentOutOfRangeException("Max dimensions must be > 0.");
            */


            using var image = SharpImage.Load(sourcePath);

            image.Mutate(x => x.Resize(new ResizeOptions
            {
                Size = new SixLabors.ImageSharp.Size(maxWidth, maxHeight),
                Mode = ResizeMode.Max // Maintain aspect ratio, fit within max dimensions
            }));


            // image encoder with specified quality
            var encoder = new JpegEncoder { Quality = quality };

            // makes sure destination directory exists
            var dir = Path.GetDirectoryName(destinationPath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(path: dir);
            }

            image.Save(destinationPath, encoder);
            

        }

    } // End of ImageProcessor class
}
 