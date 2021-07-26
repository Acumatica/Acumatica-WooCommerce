using ACSC.Tests.Entity.SalesPrices;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.SalesPrices;
using GeneratedWrappers.Acumatica;
using Controls.CheckBox;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Input;

namespace ACSC.Tests.Extensions.SalesPrices
{
    public class ACSalesPricePage : AR202000_ARSalesPriceMaint
    {
        public c_filter_form Summary => Filter_form;
        public c_records_grid Details => Records_grid;
        public DetailsGridRow DetailsRow => new DetailsGridRow(this);
        public class DetailsGridRow
        {
            private readonly ACSalesPricePage _parent;
            private readonly c_records_grid.c_grid_row _row;

            public DetailsGridRow(ACSalesPricePage parent)
            {
                _parent = parent;
                _row = _parent.Details.Row;
            }

            public DropDown PriceType => _row.PriceType;
            public Selector PriceCode => _row.PriceCode;
            public Selector InventoryID => _row.InventoryID;
            public InputLocalizable Description => _row.Description;
            public Selector UOM => _row.UOM;
            public Selector Warehouse => _row.SiteID;
            public PXNumberEdit BreakQty => _row.BreakQty;
            public PXNumberEdit Price => _row.SalesPrice;
            public Selector Currency => _row.CuryID;
            public Selector Tax => _row.TaxID;
            public CheckBox IsPromotionalPrice => _row.IsPromotionalPrice;
            public DateSelector EffectiveDate => _row.EffectiveDate;
            public DateSelector ExpirationDate  => _row.ExpirationDate;
        }
        internal void Full(ISalesPriceVisitor visitor)
        {
            visitor.Full(this);
        }
        public SalesPriceEntity Get()
        {
            var visitor = VisitorsManager.GetSingle<ISalesPriceVisitor>(typeof(SalesPriceVisitor));
            return visitor.Get(this);
        }
    }
}
