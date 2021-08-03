using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityHeader : ICloneable
    {
        public string Custom_1 { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerRefNbr { get; set; }
        public string OrderDesc { get; set; }
        public string Project { get; set; }
        public string NoteText { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}