using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Domain.Models
{
    /// <summary>
    /// Represents the progress of processing a batch of images, including the current file index, total file count, and the name of the current file being processed.
    /// </summary>
    /// <param name="CurrentFileIndex">The index of the current file being processed.</param>
    /// <param name="TotalFileIndex">The total number of files to be processed.</param>
    /// <param name="CurrentFileName">The name of the current file being processed.</param>
    public sealed record ImageBatchProgress(
        int CurrentFileIndex,
        int TotalFileIndex,
        string CurrentFileName
        );
}
