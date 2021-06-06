using System;

namespace Lib
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Domain model is exportable to csv or not
        /// </summary>
        /// <param name="t">Type of model</param>
        /// <returns>Yes or no</returns>
        public static bool IsExcelExportable(this Type t)
            => (ExcelExportable)Attribute.GetCustomAttribute(t, typeof(ExcelExportable)) != null;
    }
}
