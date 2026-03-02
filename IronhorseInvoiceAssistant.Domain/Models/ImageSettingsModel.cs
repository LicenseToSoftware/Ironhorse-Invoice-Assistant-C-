using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Domain.Models
{
    public class ImageSettingsModel()
    {
        /// <summary>
        /// Gets or sets the default image width.
        /// </summary>
        public int MaxWidth { get; set; } = 800;

        /// <summary>
        /// Gets or sets the default image height.
        /// </summary>
        public int MaxHeight { get; set; } = 800;

        /// <summary>
        /// Gets or set the default image quality.
        /// </summary>
        public int ImageQuality { get; set; } = 90;

    }
}
