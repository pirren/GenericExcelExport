using ClosedXML.Excel;
using ExcelExport.Models;
using System;

namespace ExcelExport
{
    public class ExcelUtils
    {
        public ExcelUtils()
        {

        }

        public void BuildExcelSheet<T>(ExportToCsv<T> exportdata) where T : class
        {
            using var workbook = new XLWorkbook();
            Type t = typeof(T);

            var columns = exportdata.GetColumnNames();
            var data = exportdata.GetPropValues();
        }
    }
}
