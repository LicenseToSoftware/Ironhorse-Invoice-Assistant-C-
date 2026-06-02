using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Playground
{
    public class ExcelExportService
    {
        public ExcelExportService()
        { 
        }

        public List<JobLogExcelModel> ImportJobLog(string filePath)
            {
                var jobLogData = new List<JobLogExcelModel>();

                // Read the Excel file and populate the jobLogData list
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1); // Data for joblog is always in the first worksheet

                    foreach (var row in worksheet.RowsUsed().Skip(1))
                    {
                        // Populate jobLogData with actual data
                        var jobLogExcelData = new JobLogExcelModel
                        {

                            JobNumber = row.Cell(1).GetString(),
                            Equipment = row.Cell(2).GetString(),
                            RentalCompany = row.Cell(3).GetString(),
                            EquipmentPaid = ReadBool(row.Cell(4)),
                            RentalPrice = row.Cell(5).GetValue<decimal?>(),
                            CompanyName = row.Cell(6).GetString(),
                            ContactNameOrTitle = row.Cell(7).GetString(),
                            PhoneFaxEmail = row.Cell(8).GetString(),
                            JobType = row.Cell(9).GetString(),
                            JobInformationAndNotes = row.Cell(10).GetString(),
                            JobCompletion = ReadDate(row.Cell(11)),
                            InvoiceSent = ReadDate(row.Cell(12)),
                            InvoiceAmount = row.Cell(13).GetValue<decimal?>(),
                            InvoicePaidDate = ReadDate(row.Cell(14)),
                            InvoiceStatus = row.Cell(15).GetString(),
                            JobInformationAndPaymentStatus = row.Cell(16).GetString(),
                            OutstandingOwed = row.Cell(17).GetString(),
                            Quote = row.Cell(18).GetString()
                        };
                        jobLogData.Add(jobLogExcelData);
                    }

                    return jobLogData;


                }
        }

        /// <summary>
        /// Reads a boolean value from the specified cell.
        /// </summary>
        /// <param name="cell">The cell from which to read the boolean value.</param>
        /// <returns>True if the cell contains 'yes' or 'true'; false if it contains 'no' or 'false'; otherwise, null.</returns>
        private static bool? ReadBool(IXLCell cell)
        {
            if (cell.TryGetValue<bool>(out var value))
                return value;

            var text = cell.GetString().Trim();

            if (text.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                text.Equals("true", StringComparison.OrdinalIgnoreCase))
                return true;

            if (text.Equals("no", StringComparison.OrdinalIgnoreCase) ||
                text.Equals("false", StringComparison.OrdinalIgnoreCase))
                return false;

            return null;
        }

        /// <summary>
        /// Reads a date value from the specified cell, attempting both direct and string-based parsing.
        /// </summary>
        /// <param name="cell">The cell from which to read the date.</param>
        /// <returns>The parsed date if successful; otherwise, null.</returns>
        private static DateTime? ReadDate(IXLCell cell)
        {
            if (cell.TryGetValue<DateTime>(out var value))
                return value;

            var text = cell.GetString().Trim();

            if (DateTime.TryParse(text, out var parsedDate))
                return parsedDate;

            return null;
        }

    }


}
