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
            var genericData = new List<Invoice>()
            {
                new Invoice { Amount = 200, DueDate = DateTime.Parse("2021-06-30"), FirstName = "Pierre", LastName ="Nygård" },
                new Invoice { Amount = 300, DueDate = DateTime.Parse("2021-07-30"), FirstName = "Pierre", LastName ="Nygård" }
            };
            var genericsExportData = GetGenericsExportData(genericData);

            ExcelUtils excelTools = new();
            ExcelUtils.BuildExcelSheet(genericsExportData);
        }

        static ExportToCsv<T> GetGenericsExportData<T>(List<T> data)
        {
            return new ExportToCsv<T>(data);
        }

        public static List<T> CreateList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
