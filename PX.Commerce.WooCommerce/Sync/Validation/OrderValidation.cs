using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.CS;
using PX.Objects.SO;

namespace PX.Commerce.WooCommerce
{
    public class OrderValidator : BCBaseValidator, ISettingsValidator, ILocalValidator
    {
        public int Priority { get { return 0; } }

        public virtual void Validate(IProcessor iproc)
        {
            Validate<WCSalesOrderProcessor>(iproc, (processor) =>
            {
                BCEntity entity = processor.GetEntity();
                BCBinding store = processor.GetBinding();
                BCBindingExt storeExt = processor.GetBindingExt<BCBindingExt>();

                //Branch
                if (store.BranchID == null)
                    throw new PXException(WCMessages.NoBranch);

                SOOrderType type = PXSelect<SOOrderType, Where<SOOrderType.orderType, Equal<Required<SOOrderType.orderType>>>>.Select(processor, storeExt.OrderType);
                //OrderType
                if (type == null || type.Active != true)
                    throw new PXException(WCMessages.NoSalesOrderType);
                //Order Numberings
                BCAutoNumberAttribute.CheckAutoNumbering(processor, type.OrderNumberingID);
            });
            Validate<WCPaymentProcessor>(iproc, (processor) =>
            {
                BCEntity entity = processor.GetEntity();
                BCBinding store = processor.GetBinding();
                BCBindingExt storeExt = processor.GetBindingExt<BCBindingExt>();

                //Branch
                if (store.BranchID == null)
                    throw new PXException(WCMessages.NoBranch);

                //Numberings
                ARSetup type = PXSelect<ARSetup>.Select(processor);
                BCAutoNumberAttribute.CheckAutoNumbering(processor, type.PaymentNumberingID);
            });
        }

        public void Validate(IProcessor iproc, ILocalEntity ilocal)
        {
            Validate<WCSalesOrderProcessor, SalesOrder>(iproc, ilocal, (processor, entity) =>
            {
                BCBinding store = processor.GetBinding();
                BCBindingExt storeExt = processor.GetBindingExt<BCBindingExt>();
                if (storeExt.PostDiscounts == BCPostDiscountAttribute.DocumentDiscount && entity.DiscountDetails?.Count > 0 && PXAccess.FeatureInstalled<FeaturesSet.customerDiscounts>() == false)
                    throw new PXException(BCMessages.DocumentDiscountSOMsg);
            });
        }
    }
}
