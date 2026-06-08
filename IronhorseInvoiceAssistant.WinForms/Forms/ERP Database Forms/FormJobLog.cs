using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    public partial class FormJobLog : Form
    {
        public FormJobLog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TODO: Make sure jobnumber does not already exist in database, if it does, then user must enter a different job number. If it does not exist, then add the job number to the database.
        }
    }
}
