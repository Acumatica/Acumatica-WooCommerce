using GeneratedWrappers.Acumatica;
using ACSC.Tests.Extensions.Customer;

namespace ACSC.Tests.Extensions.Taxes
{
    public class Tax : TX205000_SalesTaxMaint
    {
        public c_tax_tab Settings => Tax_tab;
        public c_taxrevisions_grid1 Details => TaxRevisions_grid1;
        public c_currenttax_glaccountslocation Accounts => CurrentTax_GLAccountsLocation;

        TaxZone TaxZones = new TaxZone();

        public void AddNewTax()
        {
            OpenScreen();
            Insert();
            Settings.TaxID.Type("NYSTATE");
            Settings.Descr.Type("NY State Tax");
            Settings.TaxType.Select("Sales");
            Details.New();
            Details.Row.TaxRate.Type("9.975");
            Details.Row.TaxBucketID.Select("Default Input Group");
            Details.New();
            Details.Row.TaxRate.Type("9.975");
            Details.Row.TaxBucketID.Select("Default Output Group");
            Accounts.SalesTaxAcctID.Select("24100");
            Accounts.SalesTaxSubID.Type("000-000");
            Accounts.ReportExpenseToSingleAccount.SetFalse();
            Save();

            Insert();
            Settings.TaxID.Type("NYSTATE New");
            Settings.Descr.Type("NY State Tax");
            Settings.TaxType.Select("Sales");
            Details.New();
            Details.Row.TaxRate.Type("9.975");
            Details.Row.TaxBucketID.Select("Default Input Group");
            Details.New();
            Details.Row.TaxRate.Type("9.975");
            Details.Row.TaxBucketID.Select("Default Output Group");
            Accounts.SalesTaxAcctID.Select("24100");
            Accounts.SalesTaxSubID.Type("000-000");
            Accounts.ReportExpenseToSingleAccount.SetFalse();
            Save();
        }

        public void AddNewTaxZone()
        {
            //Add Tax Zone
            TaxZones.OpenScreen();
            TaxZones.Insert();
            TaxZones.Summary.TaxZoneID.Select();
            TaxZones.Summary.TaxZoneID.Type("NYSTATE");
            TaxZones.Summary.Descr.Type("NY State Tax");
            TaxZones.Summary.DfltTaxCategoryID.Type("TAXABLE");
            TaxZones.Details.New();
            TaxZones.Details.Row.TaxID.Type("NYSTATE");
            // TaxesPage.Save();
            TaxZones.Details.New();
            TaxZones.Details.Row.TaxID.Type("NYSTATE New");
            Save();
        }
    }
}