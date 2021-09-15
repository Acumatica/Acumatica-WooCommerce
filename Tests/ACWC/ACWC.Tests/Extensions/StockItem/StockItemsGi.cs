using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.StockItem;
using GeneratedWrappers.Acumatica;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;

namespace ACSC.Tests.Extensions.StockItem
{
    public class StockItemsGi : IN2025PL_PXGenericInqGrph
    {
        public c_results_grid.c_grid_header ResultsGridHeader => Results_grid.Columns;
        public c_results_grid Details => Results_grid;
        public ResultsRow ResultsGridRow => new ResultsRow(this);

        public class ResultsRow
        {
            private readonly StockItemsGi _parent;
            private readonly c_results_grid.c_grid_row _row;

            public ResultsRow(StockItemsGi parent)
            {
                _parent = parent;
                _row = _parent.Details.Row;
            }

            public Selector InventoryCD => _row.InventoryItem_inventoryCD;
            public Selector Description => _row.InventoryItem_descr;
            public Selector ItemClass => _row.InventoryItem_itemClassID;
            public DropDown ItemType => _row.InventoryItem_itemType;
            public DropDown ItemStatus => _row.InventoryItem_itemStatus;
            public decimal BasePrice => decimal.Parse(_row.InventoryItem_basePrice.GetValue());

        }

        public StockItemGI Get()
        {
            var visitor = VisitorsManager.GetSingle<IStockItemGIVisitor>(typeof(StockItemGIVisitor));
            return visitor.Get(this);
        }

        public void CreateStockItemAC()
        {
            OpenScreen();
        }
    }
}