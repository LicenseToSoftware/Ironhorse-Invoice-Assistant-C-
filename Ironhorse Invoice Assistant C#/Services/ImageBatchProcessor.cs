using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace Ironhorse_Invoice_Assistant_C_.Services
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
            Console.WriteLine($"Source folder not found:");
        }
    }
}
