using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Domain.Models
{
    /// <summary>
    /// Represents a selectable resize preset for image processing.
    /// Used by the UI to provide predefined length and width values
    /// when resizing images.
    /// </summary>
    public class ResizeOption
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
            return $"{Height} x {Width}";
        }
    }
}
