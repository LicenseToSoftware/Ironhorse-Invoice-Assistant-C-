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
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateProgress(int current, int total, string filename)
        {

            progressBar.Maximum = total;
            progressBar.Value = current;

            lblStatus.Text = $"Currently proccessing {current} of {total} files";
            lblFileName.Text = filename;



        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
