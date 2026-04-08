using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.WinForms.Forms.Base
{
    /// <summary>
    /// BaseForm serves as a common ancestor for all forms in the application, providing shared styling and behavior.
    /// </summary>
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Set common properties for all forms
            Font = new Font("Segoe UI", 10);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
           
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
    }
}
