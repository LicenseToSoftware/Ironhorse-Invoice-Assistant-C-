using IronhorseInvoiceAssistant.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
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

            var folder = EnsureLocalAppDirectory();

            return Path.Combine(folder, jsonFile);
        }

        //
        public static string EnsureLocalAppDirectory()
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IronhorseInvoiceAssistant");

             Directory.CreateDirectory(folder); // creates directory if missing; does nothing if it already exists

            return folder;
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
                    var defaultSettings = new AppSettingsModel();

                    var json = JsonSerializer.Serialize(
                        defaultSettings,
                        new JsonSerializerOptions { WriteIndented = true });

                    File.WriteAllText(userFilePath, json);
                }
            }
            return userFilePath;
        }
    }
}
