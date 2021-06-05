using Domain;
using ExcelExport;
using ExcelExport.Models;
using System;
using System.Linq;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ExportToCsv<Invoice> exportData = new(
            new[] {
                new Invoice { Amount = 200, DueDate = DateTime.Parse("2021-06-30"), FirstName = "Pierre", LastName ="Nygård" },
                new Invoice { Amount = 300, DueDate = DateTime.Parse("2021-07-30"), FirstName = "Pierre", LastName ="Nygård" }
            }.ToList());

            ExcelUtils excelTools = new();
            excelTools.BuildExcelSheet(exportData);
        }
    }
}
