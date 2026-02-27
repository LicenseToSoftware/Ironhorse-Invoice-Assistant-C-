using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Models
{
    public class AppSettingsModel
    {
        /// <summary>
        /// Represents the persistent user configuration for the Ironhorse Invoice Assistant.
        /// This model is serialized to and from a JSON settings file and stores application
        /// version information, last-used folder paths, and default image processing options.
        /// </summary>
        public int Version { get; set; } = 1;

        // UI Defaults /Last Used
        public string? LastSourcePath { get; set; } = "test in models";
        public string? LastDestinationPath { get; set; }

        public ImageSettingsModel Image { get; set; } = new();
    }
}
