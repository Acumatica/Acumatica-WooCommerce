using ACSC.Tests.Entity.Customer;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Customer;
using GeneratedWrappers.Acumatica;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Input.PXTextEdit;

namespace ACSC.Tests.Extensions.Customer
{
    public class CustomersGI : AR3030PL_PXGenericInqGrph
    {
        public c_results_grid.c_grid_header ResultsGridHeader => Results_grid.Columns;
        public c_results_grid Results => Results_grid;
        public ResultsRow ResultsGridRow => new ResultsRow(this);

        public CustomerGI Get()
        {
            var visitor = VisitorsManager.GetSingle<ICustomerGIVisitor>(typeof(CustomerGIVisitor));
            return visitor.Get(this);
        }

        public class ResultsRow
        {
            private readonly CustomersGI _parent;
            private readonly c_results_grid.c_grid_row _row;

            public ResultsRow(CustomersGI parent)
            {
                _parent = parent;
                _row = _parent.Results.Row;
            }

            public Selector CustomerID  => _row.Customer_acctCD;
            public Selector CustomerName => _row.Customer_acctName;
            public Selector CustomerClass => _row.Customer_customerClassID;
            public Selector Country => _row.Address_countryID;
            public PXTextEdit City => _row.Address_city;
            public Selector CurrentcyID => _row.Customer_curyID;
            public Selector Terms => _row.Customer_termsID;
            public DropDown Status => _row.Customer_status;
           
        }
    }
}