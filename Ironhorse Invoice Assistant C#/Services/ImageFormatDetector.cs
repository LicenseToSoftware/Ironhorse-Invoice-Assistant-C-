using System;
using SixLabors.ImageSharp; 
using SixLabors.ImageSharp.Formats;
using SharpImage = SixLabors.ImageSharp.Image;
using System.IO;

namespace Ironhorse_Invoice_Assistant_C_.Services
{
    /// <summary>
    /// Provides utilities to detect image formats using ImageSharp.
    /// </summary>
    public static class ImageFormatDetector
    {

        /// <summary>
        /// Attempts to detect the format of the image at the given file path.
        /// Returns null if the format is unsupported or the file is invalid.
        /// </summary>
        /// <param name="filePath">Full path to the image file.</param>
        /// <returns>An IImageFormat if supported; otherwise, null.</returns>
        public static IImageFormat? GetImageFormat(string filePath)
        {
            try
            {
                using var stream = File.OpenRead(filePath);
                return SharpImage.DetectFormat(stream); //
            }
            catch
            {
                return null; // Handles file not found, permission denied, etc.
            }
        }
    }

}
