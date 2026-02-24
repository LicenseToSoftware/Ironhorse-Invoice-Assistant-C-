using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronhorseInvoiceAssistant.Helpers
{
    public static class Guard
    {
        public static void AgainstNullOrWhiteSpace(string filePath, string paraName) 
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException(message: $"{paraName} path is required. {paraName}", paramName: paraName);
        }

        public static void AgainstFileNotFound(string filePath, string message = "File not found.")
        {
            if (!File.Exists(filePath))
            { throw new FileNotFoundException(message: message, fileName: filePath); }
        }

        public static void EnsureDirectoryExist(string destinationDirectory)
        {
            if (!Directory.Exists(destinationDirectory)) 
            {  throw new DirectoryNotFoundException($"Listed directory not found {destinationDirectory}"); }
        }

        public static void AgainstOutOfRange(int value, int min, int max, string paraName, string? message = null)
        {

            if (value < min || value > max)
                throw new ArgumentOutOfRangeException(paramName: paraName, message: message ?? $"{paraName} must be between {min} and {max}");
        }

        public static void AgainstLessThanOrEqualToZero(int value, string paramName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(paramName,
                    $"{paramName} must be greater than 0.");
        }

    } //end of Guard class

    /*
     // Error checking
            

           

            if (string.IsNullOrWhiteSpace(destinationPath))
                throw new ArgumentException("Destination path is required.", nameof(destinationPath));

            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException(nameof(quality), "JPEG quality must be 0–100.");

            if (maxWidth <= 0 || maxHeight <= 0)
                throw new ArgumentOutOfRangeException("Max dimensions must be > 0.");
     */
}
