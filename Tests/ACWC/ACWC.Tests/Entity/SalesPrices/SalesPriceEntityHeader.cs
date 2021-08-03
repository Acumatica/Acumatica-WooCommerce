using System;

namespace ACSC.Tests.Entity.SalesPrices
{
    public class SalesPriceEntityHeader : ICloneable
    {
        public string PriceType { get; set; }
        public string PriceCode { get; set; }
        public string InventoryID { get; set; }
        public string Warehouse { get; set; }
        public decimal BreakQty { get; set; }
        public decimal Price { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
