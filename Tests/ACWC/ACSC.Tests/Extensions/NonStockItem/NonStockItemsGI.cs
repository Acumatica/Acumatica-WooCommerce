using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.NonStockItem;
using GeneratedWrappers.Acumatica;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;

namespace ACSC.Tests.Extensions.NonStockItem
{
    public class NonStockItemsGI : IN2020PL_PXGenericInqGrph
    {
        public c_results_grid.c_grid_header ResultsGridHeader => Results_grid.Columns;
        public c_results_grid Details => Results_grid;
        public ResultsRow ResultsGridRow => new ResultsRow(this);

        public class ResultsRow
        {
            private readonly NonStockItemsGI _parent;
            private readonly c_results_grid.c_grid_row _row;

            public ResultsRow(NonStockItemsGI parent)
            {
                _parent = parent;
                _row = _parent.Details.Row;
            }

            public Selector InventoryCD => _row.InventoryItem_InventoryCD;
            public Selector Description => _row.InventoryItem_descr;
            public DropDown ItemType => _row.InventoryItem_itemType;
            public DropDown ItemStatus => _row.InventoryItem_itemStatus;
        }

        public NonStockItemGI Get()
        {
            var visitor = VisitorsManager.GetSingle<INonStockItemGIVisitor>(typeof(NonStockItemGIVisitor));
            return visitor.Get(this);
        }
    }
}