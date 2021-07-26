using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions
{
    public class ACWooCommerceStore : BC201010_BCShopifyStoreMaint
    {
        public c_entities_cstpxgrid60 EntitySettings => base.Entities_CstPXGrid60;
        public c_bindings_form Stores => base.Bindings_form;
        public c_entities_cstpxgrid60 Entities => base.Entities_CstPXGrid60;
        public c_currentstore_tab StoreSettings => base.CurrentStore_tab;
        public c_exportlocations_gridexportlocations WarehousesLocations => base.ExportLocations_gridExportLocations;
        public c_shippingmappings_pxgrid1 ShippingMappings => base.ShippingMappings_PXGrid1;
        public c_paymentmethods_paymentsmethods PaymentMethods => base.PaymentMethods_PaymentsMethods;

        public void SetEntitySettings(string entity, string direction, string primarySystem)
        {
            EntitySettings.Columns.EntityType.Equals(entity);
            EntitySettings.Row.Direction.Select(direction);
            EntitySettings.Row.PrimarySystem.Select(primarySystem);
        }

    }
}