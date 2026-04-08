using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronhorseInvoiceAssistant.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the click event of the Resize Photos button by displaying the ResizeImageForm as a modal dialog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnResizePhotos_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                using var form = new ResizeImageForm();
                form.ShowDialog();
            }
            finally
            {
                this.Show();
            }

        }
    }
}
