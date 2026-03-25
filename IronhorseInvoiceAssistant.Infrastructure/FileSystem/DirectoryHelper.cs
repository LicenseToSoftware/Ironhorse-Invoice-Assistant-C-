using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Infrastructure.FileSystem
{
    public class DirectoryHelper
    {
        /// <summary>
        /// Determines whether the specified directory is writable by attempting to create and delete a temporary file.
        /// </summary>
        /// <param name="dirPath">The path of the directory to check for write access.</param>
        /// <returns>true if the directory is writable; otherwise, false.</returns>
        public static bool IsDirectoryWritable(string dirPath)
        {
            if (string.IsNullOrWhiteSpace(dirPath)) return false;
            if (!Directory.Exists(dirPath)) return false;

            try
            {
                string testFile = Path.Combine(dirPath, Path.GetRandomFileName());

                using (FileStream fs = File.Create(testFile, 1, FileOptions.DeleteOnClose))
                {
                    // If we got here, it's writable
                }
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            catch (IOException)
            {
                return false;
            }
            catch (System.Security.SecurityException)
            {
                return false;
            }
        }
    }
}
