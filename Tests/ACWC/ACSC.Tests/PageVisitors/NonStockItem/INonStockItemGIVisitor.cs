using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Extensions.NonStockItem;

namespace ACSC.Tests.PageVisitors.NonStockItem
{
    public interface INonStockItemGIVisitor
    {
        NonStockItemGI Get(NonStockItemsGI page);
    }
}
