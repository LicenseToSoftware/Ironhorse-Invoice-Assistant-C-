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
        public void ResizeImageJPG(string sourcePath, string destinationPath)
        {
            // Placeholder for image resizing logic
            // This method should resize the image at sourcePath to the specified quality
            // and save it to destinationPath.
            // Implementation would typically use an image processing library like ImageSharp or System.Drawing.

            using (SharpImage image = SharpImage.Load(sourcePath))
            {
                // Save with quality level (90 is usually a good balance)
                var encoder = new JpegEncoder
                {
                    Quality = 90 // range 0–100, higher = better quality, larger file
                };

                image.Save(destinationPath, encoder);
            }

        }


    }
}
