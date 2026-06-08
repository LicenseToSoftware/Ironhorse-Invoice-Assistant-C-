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
    //TODO add Logic to connect to database and add data
    public partial class AddCustomerDetails : Form
    {
        public AddCustomerDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO add logic to populate the form fields with the selected company's details from the SQL database
        }
    }
}
