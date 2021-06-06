using System;

namespace Lib
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExcelExportable : Attribute
    {
        public string Options { get; set; } // Not in use
    }
}
