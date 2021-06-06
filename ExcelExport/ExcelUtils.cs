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

        public void BuildExcelSheet<T>(ExportToCsv<T> exportdata) 
        {
            using var workbook = new XLWorkbook(); // todo: implement
            Type t = typeof(T); 

            var columns = exportdata.GetColumnNames();
            var data = exportdata.GetPropValues();
        }
    }
}
