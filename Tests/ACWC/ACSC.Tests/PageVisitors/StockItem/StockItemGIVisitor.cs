using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Extensions.StockItem;

namespace ACSC.Tests.PageVisitors.StockItem
{
    public class StockItemGIVisitor : IStockItemGIVisitor
    {
        public StockItemGI Get(StockItemsGi page)
        {
            var result = new StockItemGI();
            var count = page.Details.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.Details.SelectRow(i);
                var row = page.ResultsGridRow;
                if (row != null)
                {
                    result.ResultRows.Add(new StockItemGIRow
                    {
                        InventoryCD = row.InventoryCD.GetValue(),
                        Description = row.Description.GetValue(),
                        ItemType = row.ItemType.GetValue(),
                        ItemClass = row.ItemClass.GetValue(),
                        
                        ItemStatus = row.ItemStatus.GetValue()
                    });
                }
            }

            return result;
        }
    }
}