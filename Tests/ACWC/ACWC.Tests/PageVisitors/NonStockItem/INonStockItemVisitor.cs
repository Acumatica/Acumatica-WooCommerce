using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Extensions.NonStockItem;

namespace ACSC.Tests.PageVisitors.NonStockItem
{
    public interface INonStockItemVisitor
    {
        NonStockItemEntity Get(Extensions.NonStockItem.NonStockItem page);
        void Full(Extensions.NonStockItem.NonStockItem aCNonStockItemPage);
        void SetData(NonStockItemEntity item);
    }
}
