using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Domain.Models
{
    /// <summary>
    /// Represents the necessary information required to establish a connection to a SQL database, including server address, database name, username, password, and an option to trust the server certificate.
    /// </summary>
    public class DataBaseConnectionModel
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool TrustServerCertificate { get; set; } = true;
    }
}
