using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Infrastructure
{
    /// <summary>
    /// Provides methods to get paths for settings files.
    /// </summary>
    public static class SettingsPath
    {

        /// <summary>
        /// Gets the path to the local user settings file.
        /// </summary>
        /// <returns>The full path to the local user settings file.</returns>
        public static string GetLocalUserSettingsPath()
        {
            string jsonFile = GetJsonFileName();
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IronhorseInvoiceAssitant");

            Directory.CreateDirectory(folder);

            return Path.Combine(folder, jsonFile);
        }

        /// <summary>
        /// Gets the path to the default settings file included with the application.
        /// </summary>
        /// <returns>The full path to the default settings file.</returns>
        public static string GetDefaultSettingsPath()
        {
            string jsonFile = GetJsonFileName();
            return Path.Combine(AppContext.BaseDirectory, "Data", jsonFile);
        }

        /// <summary>
        /// Gets the name of the JSON settings file.
        /// </summary>
        /// <returns>The name of the JSON settings file.</returns>
        public static string GetJsonFileName()
        {
            return "settings.json";
        }
        
        /// <summary>
        /// Ensures that the user settings file exists by creating it from a default template or with minimal content if
        /// necessary.
        /// </summary>
        /// <returns>The full path to the user settings file.</returns>
        public static string EnsureUserSettingsFile()
        {
            var userFilePath = GetLocalUserSettingsPath();

            // check if local appdata exists, if not, create it
            if (!File.Exists(userFilePath))
            {
                var defaultPath = GetDefaultSettingsPath();

                // if default path exist, copy default to userpath
                if (File.Exists(defaultPath))
                {
                    File.Copy(defaultPath, userFilePath);
                }
                else
                {
                    File.WriteAllText(userFilePath, "{\n  \"version\": 1\n}\n"); // fallback minimal file
                }
            }
            return userFilePath;
        }
    }
}
