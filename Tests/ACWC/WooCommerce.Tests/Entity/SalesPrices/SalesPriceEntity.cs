using System.Collections.Generic;

namespace ACSC.Tests.Entity.SalesPrices
{
    public class SalesPriceEntity
    {
        public SalesPriceEntity()
        {
            Summary = new SalesPriceEntityHeader();
            Details = new List<SalesPriceEntityDetails>();
        }

        public SalesPriceEntityHeader Summary { get; set; }
        public List<SalesPriceEntityDetails> Details { get; set; }
    }
}
