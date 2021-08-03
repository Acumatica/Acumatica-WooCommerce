using GeneratedWrappers.Acumatica;
using ACSC.Tests.Extensions.Taxes;
using ACSC.Tests.TestsSalesOrder;

namespace ACSC.Tests.Extensions.Customer
{
    public class TaxZone : TX206000_TaxZoneMaint
    {
        public c_txzone_form Summary => TxZone_form;
        public c_details_grid Details => Details_grid;
    }
}
