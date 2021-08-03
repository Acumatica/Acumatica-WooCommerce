using ACSC.Tests.Entity.CustomerPriceClasses;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.CustomerPriceClasses;
using GeneratedWrappers.Acumatica;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;

namespace ACSC.Tests.Extensions.CustomerPriceClasses
{
    public class ACCustomerPriceClassesPage : AR208000_ARPriceClassMaint
    {
        public c_records_grid Details => Records_grid;
        public DetailsGridRow DetailsRow => new DetailsGridRow(this);

        public class DetailsGridRow
        {
            private readonly ACCustomerPriceClassesPage _parent;
            private readonly c_records_grid.c_grid_row _row;

            public DetailsGridRow(ACCustomerPriceClassesPage parent)
            {
                _parent = parent;
                _row = _parent.Details.Row;
            }

            public PXTextEdit PriceClassID => _row.PriceClassID;
            public InputLocalizable Description => _row.Description;
            public PXNumberEdit SortOrder => _row.SortOrder;
        }

        internal void Full(CustomerPriceClassesEntity customerPriceClassesEntity)
        {
            var visitor = VisitorsManager.GetSingle<ICustomerPriceClassesVisitor>(typeof(CustomerPriceClassesVisitor));
            visitor.SetData(customerPriceClassesEntity);
            visitor.Full(this);
        }
    }
}
