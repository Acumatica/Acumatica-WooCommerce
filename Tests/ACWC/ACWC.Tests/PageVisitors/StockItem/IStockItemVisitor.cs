using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Extensions.StockItem;

namespace ACSC.Tests.PageVisitors.StockItem
{
    public interface IStockItemVisitor
    {
        void Full(Extensions.StockItem.StockItem page);
        StockItemEntity Get(Extensions.StockItem.StockItem page);
        void SetData(StockItemEntity stockItem);
    }
}