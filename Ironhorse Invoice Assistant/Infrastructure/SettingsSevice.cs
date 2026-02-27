using IronhorseInvoiceAssistant.Models;
using IronhorseInvoiceAssistant.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Infrastructure
{
    /// <summary>
    /// Provides functionality for loading and saving user application settings
    /// to a JSON file stored in the local user settings directory.
    /// </summary>
    public static class SettingsSevice
    {
      
        /// /// <summary>
        /// JSON serializer configuration used when reading and writing the settings file.
        /// Enables case-insensitive property matching and controls formatting behavior.
        /// </summary>
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = false // modifying object is allowed
        };

        /// <summary>
        /// Loads the application settings from the user's local settings file.
        /// </summary>
        /// <returns>
        /// An <see cref="AppSettingsModel"/> instance containing the persisted settings,
        /// or null if deserialization fails.
        /// </returns>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the settings file does not exist.
        /// </exception>
        /// <exception cref="JsonException">
        /// Thrown if the file contains invalid JSON.
        /// </exception>
        public static AppSettingsModel? Load()
        {
            string path = SettingsPath.GetLocalUserSettingsPath();

            if (!File.Exists(path))
                return new AppSettingsModel();

            var json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<AppSettingsModel>(json, JsonOptions);
        }

        /// <summary>
        /// Saves the specified application settings to the user's local settings file.
        /// If the file already exists, it will be overwritten.
        /// </summary>
        /// <param name="settings">
        /// The <see cref="AppSettingsModel"/> instance containing the settings to persist.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the settings object is null.
        /// </exception>
        /// <exception cref="IOException">
        /// Thrown if the file cannot be written.
        /// </exception>
        public static void Save(AppSettingsModel settings)
        {
            string json = JsonSerializer.Serialize(settings, JsonOptions);
            File.WriteAllText(SettingsPath.GetLocalUserSettingsPath(), json);
        }
        
    }
}
