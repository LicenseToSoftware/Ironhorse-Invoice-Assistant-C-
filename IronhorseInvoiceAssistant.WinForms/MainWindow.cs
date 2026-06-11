using IronhorseInvoiceAssistant.WinForms.Forms;
using IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronhorseInvoiceAssistant.WinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCompletionReportAssistant_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResizeImageForm completionReportAssistantForm = new ResizeImageForm();
            completionReportAssistantForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataBaseConnection FormGetConnectionString = new FormDataBaseConnection();
            FormGetConnectionString.ShowDialog();
            this.Show();
        }
    }
}
