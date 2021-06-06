using ClosedXML.Excel;
using ExcelExport.Models;
using Lib;
using System;

namespace ExcelExport
{
    public class ExcelUtils
    {
        public ExcelUtils() { }

        public void BuildExcelSheet<T>(ExportToCsv<T> exportdata)
        {
            using var workbook = new XLWorkbook(); // todo: implement

            if (!typeof(T).IsExcelExportable())
                throw new ExcelExportException("This model is not allowed to be exported!");

            var columns = exportdata.GetColumnHeaders();
            var data = exportdata.GetPropValues();
        }

        private class ExcelExportException : ApplicationException
        {
            public ExcelExportException(string message) : base(message) { }
        }
    }
}
