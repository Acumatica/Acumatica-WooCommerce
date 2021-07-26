using System;

namespace ACSC.Tests.Entity.SalesPrices
{
    public class SalesPriceEntityDetails : ICloneable
    {
        public string PriceType { get; set; }
        public string PriceCode { get; set; }
        public string InventoryID { get; set; }
        public string Description { get; set; }
        public string UOM { get; set; }
        public string Warehouse { get; set; }
        public decimal BreakQty { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Tax { get; set; }
        public bool Promotion { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
