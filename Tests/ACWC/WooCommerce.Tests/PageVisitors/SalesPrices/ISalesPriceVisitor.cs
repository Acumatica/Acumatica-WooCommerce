using ACSC.Tests.Entity.SalesPrices;
using ACSC.Tests.Extensions.SalesPrices;

namespace ACSC.Tests.PageVisitors.SalesPrices
{
    public interface ISalesPriceVisitor
    {
        SalesPriceEntity Get(ACSalesPricePage page);
        void Full(ACSalesPricePage page);
        void SetData(SalesPriceEntity salesPriceEntityEntity);
    }
}
