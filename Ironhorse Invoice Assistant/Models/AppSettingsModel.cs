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

        /// <summary>
        /// Gets or sets the default image width.
        /// </summary>
        public int resizeWidth { get; set; } = 1200;

        /// <summary>
        /// Gets or sets the default image height.
        /// </summary>
        public int resizeHeight { get; set; } = 1200;

        /// <summary>
        /// Gets or set the default image quality.
        /// </summary>
        public int Quality { get; set; } = 90;
    }
}
