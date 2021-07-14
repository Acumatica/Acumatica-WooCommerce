using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityDiscountDetails : ICloneable
    {
        public string DiscCode { get; set; }
        public string Description { get; set; }
        public decimal? DiscAmt { get; set; }
        public string ExtDiscCode { get; set; }
        public decimal? DiscountPct { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}