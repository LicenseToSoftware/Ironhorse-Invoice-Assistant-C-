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
    public partial class AddCompanyDetails : Form
    {
        public AddCompanyDetails()
        {
            InitializeComponent();
        }

        private void AddCompanyDetails_Load(object sender, EventArgs e)
        {
            cmbBillingState.Items.AddRange(new string[]
            {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE",
                "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS",
                "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS",
                "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY",
                "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV",
                "WI", "WY"
            });

            cmbBillingState.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
