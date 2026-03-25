using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Domain.Models
{
    public sealed record ImageBatchProgress(
        int CurrentFileIndex,
        int TotalFileIndex,
        string CurrentFileName
        );
}
