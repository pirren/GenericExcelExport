using System.Collections.Generic;
using System.Linq;

namespace ExcelExport.Models
{
    public class ExportToCsv<T>
    {
        public List<T> Data { get; private set; }

        public ExportToCsv(List<T> obj)
        {
            Data = obj;
        }

        public string[] GetColumnNames()
        {
            return typeof(T).GetProperties().Select(s => s.Name).ToArray();
        }

        public string[][] GetPropValues()
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

            return returnList.ToArray();
        }
    }
}
