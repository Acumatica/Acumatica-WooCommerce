using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Extensions.NonStockItem;

namespace ACSC.Tests.PageVisitors.NonStockItem
{
    public class NonStockItemGIVisitor : INonStockItemGIVisitor
    {
        public NonStockItemGI Get(NonStockItemsGI page)
        {
            var result = new NonStockItemGI();
            var count = page.Details.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.Details.SelectRow(i);
                var row = page.ResultsGridRow;
                if (row != null)
                {
                    result.ResultRows.Add(new NonStockItemGIRow
                    {
                        InventoryCD = row.InventoryCD.Value,
                        Description = row.Description.Value,
                        ItemType = row.ItemType.Value,
                        ItemStatus = row.ItemStatus.Value
                    });
                }
            }

            return result;
        }
    }
}
