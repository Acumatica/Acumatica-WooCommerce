using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.TemplateItems
{
    public class Warehouse : IN204000_INSiteMaint
    {
        public c_site_form Summary => Site_form;
        public c_location_grid Locations => Location_grid;
        public c_siteaccounts_tab Accounts => Siteaccounts_tab;

    }
}