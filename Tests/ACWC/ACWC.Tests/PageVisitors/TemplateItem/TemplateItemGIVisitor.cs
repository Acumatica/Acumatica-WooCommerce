using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.Extensions.TemplateItems;


namespace ACSC.Tests.PageVisitors.TemplateItem
{
    public class TemplateItemGIVisitor : ITemplateItemGIVisitor
    {
        public TemplateItemGI Get(ACTemplateItemGI page)
        {
            var result = new TemplateItemGI();
            var count = page.ResultsGrid.RowsCount().ToString();
            int.TryParse(count, out var rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.ResultsGrid.SelectRow(i);
                var row = page.ResultsGridRow;
                if (row != null)
                {
                    result.ResultRows.Add(new TemplateItemGIRow
                    {
                        InventoryCD = row.InventoryCD.GetValue(),
                        Description = row.Description.GetValue(),
                        ItemType = row.ItemType.GetValue(),
                        ItemClass = row.ItemClass.GetValue(),
                        PostingClass = row.PostingClass.GetValue(),
                        TaxCategory = row.TaxCategory.GetValue(),
                        DefWarehouse = row.DefWarehouse.GetValue(),
                        BaseUnit = row.BaseUnit.GetValue(),
                        DefaultPrice = decimal.Parse(row.BasePrice.GetValue()),
                        ItemStatus = row.ItemStatus.GetValue()
                    });
                }
            }

            return result;
        }
    }
}