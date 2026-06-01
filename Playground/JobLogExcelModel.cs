using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class JobLogExcelModel
    {
       public string JobNumber { get; set; }
        public string Equipment { get; set; }
        public string RentalCompany { get; set; }
        public bool EquipmentPaid { get; set; }
        public decimal RentalPrice { get; set; }

        public string CompanyName { get; set; }
        public string ContactNameOrTitle { get; set; }
        public string PhoneFaxEmail { get; set; }

        public string JobType { get; set; }
        public string? JobInformationAndNotes { get; set; }
        public DateTime? JobCompletion { get; set; }

        public DateTime? InvoiceSent { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public DateTime? InvoicePaidDate { get; set; }
        public string? InvoiceStatus { get; set; }

        public string? JobInformationAndPaymentStatus { get; set; }
        public decimal? OutstandingOwed { get; set; }
        public string? Quote { get; set; }
    }
}
