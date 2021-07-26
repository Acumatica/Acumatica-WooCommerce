using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityDetails : ICloneable
    {
        public int? LineNbr { get; set; }
        public string InventoryID { get; set; }
        public string TranDesc { get; set; }
        public string BranchID { get; set; }
        public string DiscountID { get; set; }
        public decimal OrderQty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? CuryDiscAmt { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string SiteID { get; set; }
        public string TaxCategory { get; set; }
        public string ProjectTask { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}