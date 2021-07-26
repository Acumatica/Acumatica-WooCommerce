using System;

namespace ACSC.Tests.Entity.StockItems
{
    public class StockItemPriceCostInfo
    {
        public decimal MSRP { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal PendingCost { get; set; }
        public DateTime PendingCostDate { get; set; }
    }
}
