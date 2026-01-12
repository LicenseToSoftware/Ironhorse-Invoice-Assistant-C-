using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using SharpImage = SixLabors.ImageSharp.Image;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Services
{
    public class ImageProcessor
    {
        public void ResizeAndSaveJpeg
            (
            string sourcePath, 
            string destinationPath,
            int maxWidth = 1600,
            int maxHeight = 1600,
            int quality = 90 // range 0–100, higher = better quality, larger file
            )
        {
            // Placeholder for image resizing logic
            // This method should resize the image at sourcePath to the specified quality
            // and save it to destinationPath.
            // Implementation would typically use an image processing library like ImageSharp or System.Drawing.

            if (string.IsNullOrWhiteSpace(sourcePath))
                throw new ArgumentException("Source path is required.", nameof(sourcePath));

            if (!File.Exists(sourcePath))
                throw new FileNotFoundException("Source image not found.", sourcePath);

            if (string.IsNullOrWhiteSpace(destinationPath))
                throw new ArgumentException("Destination path is required.", nameof(destinationPath));

            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException(nameof(quality), "JPEG quality must be 0–100.");

            if (maxWidth <= 0 || maxHeight <= 0)
                throw new ArgumentOutOfRangeException("Max dimensions must be > 0.");



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
                Directory.CreateDirectory(dir);
            }

            image.Save(destinationPath, encoder);
            

        }


    }
}
