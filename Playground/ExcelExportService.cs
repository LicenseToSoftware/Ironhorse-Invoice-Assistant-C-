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
                            EquipmentPaid = row.Cell(4).GetBoolean(),
                            RentalPrice = row.Cell(5).GetValue<decimal>(),
                            CompanyName = row.Cell(6).GetString(),
                            ContactNameOrTitle = row.Cell(7).GetString(),
                            PhoneFaxEmail = row.Cell(8).GetString(),
                            JobType = row.Cell(9).GetString(),
                            JobInformationAndNotes = row.Cell(10).GetString(),
                            JobCompletion = row.Cell(11).GetValue<DateTime?>(),
                            InvoiceSent = row.Cell(12).GetValue<DateTime?>(),
                            InvoiceAmount = row.Cell(13).GetValue<decimal?>(),
                            InvoicePaidDate = row.Cell(14).GetValue<DateTime?>(),
                            InvoiceStatus = row.Cell(15).GetString(),
                            JobInformationAndPaymentStatus = row.Cell(16).GetString(),
                            OutstandingOwed = row.Cell(17).GetValue<decimal?>(),
                            Quote = row.Cell(18).GetString()
                        };
                        jobLogData.Add(jobLogExcelData);
                    }

                    return jobLogData;


                }
        }

    }


}
