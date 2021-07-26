using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityTaxDetails : ICloneable
    {
        public string TaxID { get; set; }
        public decimal TaxAmt { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}