using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.TemplateItems
{
    public class ACBigCommerceStore : BC201000_BCBigCommerceStoreMaint
    {
        public c_entities_cstpxgrid60 EntitySettings => base.Entities_CstPXGrid60;
        public c_bindings_form Stores => base.Bindings_form;
        public c_entities_cstpxgrid60 Entities => base.Entities_CstPXGrid60;
        public c_currentstore_tab StoreSettings => base.CurrentStore_tab;
        public c_exportlocations_gridexportlocations WarehousesLocations => base.ExportLocations_gridExportLocations;
        public c_shippingmappings_shippingmappings ShippingMappings => base.ShippingMappings_ShippingMappings;
        public c_paymentmethods_paymentsmethods PaymentMethods => base.PaymentMethods_PaymentsMethods;

        public void SetEntitySettings(string entity, string direction, string primarySystem)
        {
            EntitySettings.Columns.EntityType.Equals(entity);
            EntitySettings.Row.Direction.Select(direction);
            EntitySettings.Row.PrimarySystem.Select(primarySystem);
        }

        public void ActivateEntity(string [] entity)
        {
            OpenScreen();
            EntitySettings.Columns.EntityType.Equals(entity);
            EntitySettings.RowsCount();
            for (var i = 1; i <= EntitySettings.RowsCount(); i++)
            {
                EntitySettings.SelectRow(i);
                EntitySettings.Row.IsActive.SetTrue();
            }
            Save();
        }
    }
}