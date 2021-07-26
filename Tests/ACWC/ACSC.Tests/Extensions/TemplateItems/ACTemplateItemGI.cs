using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.TemplateItem;
using GeneratedWrappers.Acumatica;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;

namespace ACSC.Tests.Extensions.TemplateItems
{
    public class ACTemplateItemGI : IN2030PL_PXGenericInqGrph
    {
        public c_filter_form FilterForm => Filter_form;
        public c_results_grid.c_grid_header ResultsGridHeader => Results_grid.Columns;
        public c_results_grid ResultsGrid => Results_grid;
        public ResultsRow ResultsGridRow => new ResultsRow(this);

        public class ResultsRow
        {
            private readonly ACTemplateItemGI _parent;
            private readonly c_results_grid.c_grid_row _row;

            public ResultsRow(ACTemplateItemGI parent)
            {
                _parent = parent;
                _row = _parent.ResultsGrid.Row;
            }

            public Selector InventoryCD => _row.InventoryItem_inventoryCD;
            public Selector Description => _row.InventoryItem_descr;
            public DropDown ItemType => _row.InventoryItem_itemType;
            public Selector ItemClass => _row.InventoryItem_itemClassID;
            public PXTextEdit PostingClass => _row.InventoryItem_postClassID;
            public Selector TaxCategory => _row.InventoryItem_taxCategoryID;
            public Selector DefWarehouse => _row.InventoryItem_dfltSiteID;
            public Selector BaseUnit => _row.InventoryItem_baseUnit;
            public PXNumberEdit BasePrice => _row.InventoryItem_basePrice;
            public DropDown ItemStatus => _row.InventoryItem_itemStatus;
        }

        public TemplateItemGI Get()
        {
            var visitor = VisitorsManager.GetSingle<ITemplateItemGIVisitor>(typeof(TemplateItemGIVisitor));
            return visitor.Get(this);
        }
    }
}