using Domain;
using ExcelExport;
using ExcelExport.Models;
using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelUtils excelTools = new();

            var genericData = new List<Invoice>()
            {
                new Invoice { Amount = 200, DueDate = DateTime.Parse("2021-06-30"), FirstName = "Pierre", LastName ="Nygård" },
                new Invoice { Amount = 300, DueDate = DateTime.Parse("2021-07-30"), FirstName = "Pierre", LastName ="Nygård" }
            };
            ExportToCsv<Invoice> genericsExportData = new(genericData);

            excelTools.BuildExcelSheet(genericsExportData);
        }

        public static List<T> CreateList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
