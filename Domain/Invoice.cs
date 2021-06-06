using Lib;
using System;

namespace Domain
{
    [ExcelExportable]
    public class Invoice
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Created { get; } = DateTime.Now;
    }
}
