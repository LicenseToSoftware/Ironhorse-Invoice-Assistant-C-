using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronhorseInvoiceAssistant.Domain.Models;
using static IronhorseInvoiceAssistant.Infrastructure.SQL.SQLQueris;

namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    public partial class FormDataBaseConnection : Form
    {
        private string localHost;

        // TODO: This field is used to hold the SQL connection object. It is initialized as null and will be assigned a valid SqlConnection instance when a connection is successfully established.
        private SqlConnection? _connection;

        public FormDataBaseConnection()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the "Connect" button click. It attempts to establish a connection to the SQL database using the provided credentials and connection details. If the connection is successful, it displays a success message; otherwise, it shows an error message with the exception details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDataBaseConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct the connection string for the ip and port combination
                localHost = $"{txtLocalHost.Text}, {txtSQLPortAddress.Text}";
                DataBaseConnectionModel info = new()
                {
                    Server = localHost,
                    Database = txtDatabase.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                string connectionString =
                    GetConnectionString(info);

                using SqlConnection conn =
                    new(connectionString);

                // Attempt to open the connection asynchronously
                await conn.OpenAsync();

                MessageBox.Show(
                    "Connection Successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Save connection string somewhere
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Connection Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
