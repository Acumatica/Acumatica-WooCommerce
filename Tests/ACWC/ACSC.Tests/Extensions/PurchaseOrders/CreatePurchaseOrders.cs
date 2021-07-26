using GeneratedWrappers.Acumatica;
using Controls.Editors.Selector;

namespace ACSC.Tests.Extensions.PurchaseOrders
{
    public class CreatePurchaseOrders : PO505000_POCreate
    {
        public c_fixeddemand_grid Details => FixedDemand_grid;
        public AllRecordsGridHeader AllRecordsFilter => new AllRecordsGridHeader(this);
        
        public class AllRecordsGridHeader
        {
            private readonly CreatePurchaseOrders _parent;
            private readonly c_fixeddemand_grid.c_grid_header _header;

            public AllRecordsGridHeader(CreatePurchaseOrders parent)
            {
                _parent = parent;
                _header = parent.Details.Columns;
            }

            public SelectorColumnFilter OrderNbr => _header.SOOrder__OrderNbr;
        }
    }
}
