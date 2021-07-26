using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.Taxes
{
    public class Tax : TX205000_SalesTaxMaint
    {
        public c_tax_tab Settings => Tax_tab;
        public c_taxrevisions_grid1 Details => TaxRevisions_grid1;
        public c_currenttax_glaccountslocation Accounts => CurrentTax_GLAccountsLocation;
    }
}