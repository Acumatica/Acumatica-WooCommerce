using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Extensions.StockItem;

namespace ACSC.Tests.PageVisitors.StockItem
{
    public interface IStockItemGIVisitor
    {
        StockItemGI Get(StockItemsGi page);
    }
}