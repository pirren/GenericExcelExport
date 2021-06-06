using System.Collections.Generic;
using System.Linq;

namespace ExcelExport.Models
{
    public class ExportToCsv<T> : ExportToCsvBase
    {
        public List<T> Data { get; private set; }

        public ExportToCsv(List<T> obj)
        {
            Data = obj;
        }

        public override string[] GetColumnHeaders()
        {
            return typeof(T).GetProperties().Select(s => s.Name).ToArray();
        }

        public override List<string[]> GetPropValues()
        {
            List<string[]> returnList = new();

            var props = typeof(T).GetProperties();

            foreach (var item in Data)
            {
                List<string> itemProperties = new();
                foreach (var prop in props)
                {
                    itemProperties.Add(prop.GetValue(item).ToString());
                }
                returnList.Add(itemProperties.ToArray());
            }

            return returnList;
        }
    }

    public abstract class ExportToCsvBase
    {
        /// <summary>
        /// Get column names for excel sheet. Must be overwritten!
        /// </summary>
        /// <returns>Column names</returns>
        public abstract string[] GetColumnHeaders();

        /// <summary>
        /// Get property values of each item for excel sheet. Must be overwritten!
        /// </summary>
        /// <returns>List of array with each property value for each item</returns>
        public abstract List<string[]> GetPropValues();
    }
}
