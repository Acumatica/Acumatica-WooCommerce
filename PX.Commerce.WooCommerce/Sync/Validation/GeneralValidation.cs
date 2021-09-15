using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using PX.Objects.CS;

namespace PX.Commerce.WooCommerce
{
    public class GeneralValidator : BCBaseValidator, ISettingsValidator, IExternValidator
    {
        public int Priority { get { return int.MaxValue; } }

        public virtual void Validate(IProcessor processor)
        {
            if (PXAccess.FeatureInstalled<FeaturesSet.subItem>() == true)
                throw new PXException(WCMessages.FeatureNotSupported, "Inventory Subitems");
            if (PXAccess.FeatureInstalled<FeaturesSet.financialStandard>() == false)
                throw new PXException(WCMessages.FeatureRequired, "Standard Financials");
            if (PXAccess.FeatureInstalled<FeaturesSet.accountLocations>() == false)
                throw new PXException(WCMessages.FeatureRequired, "Business Accounts Location");
            if (PXAccess.FeatureInstalled<FeaturesSet.distributionModule>() == false)
                throw new PXException(WCMessages.FeatureRequired, " Distribution");
        }

        public virtual void Validate(IProcessor processor, IExternEntity entity)
        {
            RunAttributesValidation(processor, entity);
        }
    }
}
