using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using IronhorseInvoiceAssistant.Domain.Models;

namespace IronhorseInvoiceAssistant.Infrastructure.SQL
{
    /// <summary>
    /// Provides utility methods for constructing SQL connection strings and queries based on database connection information.
    /// </summary>
    public class SQLQueris
    {
        /// <summary>
        /// Constructs a SQL connection string using the provided database connection information.
        /// </summary>
        /// <param name="info">The database connection information.</param>
        /// <returns>A SQL connection string.</returns>
        public static string GetConnectionString(DataBaseConnectionModel info)
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = info.Server,
                InitialCatalog = info.Database,
                UserID = info.Username,
                Password = info.Password,
                TrustServerCertificate = true
            };

            return builder.ConnectionString;

        }
    }
}
