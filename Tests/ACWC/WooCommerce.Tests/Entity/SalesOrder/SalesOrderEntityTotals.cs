using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityTotals : ICloneable
    {
        public decimal OrderQty { get; set; }
        public decimal? CuryTaxTotal { get; set; }
        public decimal CuryOrderTotal { get; set; }
        public decimal? CuryDiscTot { get; set; }
        public decimal? CuryPaymentTotal { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? UnshippedAmount { get; set; }
        public decimal? FreightPrice { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}