using PX.Commerce.Core;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Customer;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using PX.Objects.AR;
using System;

namespace PX.Commerce.WooCommerce
{
    public class CustomerValidator : BCBaseValidator, ISettingsValidator, IExternValidator
    {
        public int Priority { get { return 0; } }

        public virtual void Validate(IProcessor iproc)
        {
            Validate<WCCustomerProcessor>(iproc, (processor) =>
            {
                BCBindingExt storeExt = processor.GetBindingExt<BCBindingExt>();
                if (storeExt.CustomerNumberingID == null && BCDimensionMaskAttribute.GetAutoNumbering(CustomerRawAttribute.DimensionName) == null)
                    throw new PXException(WCMessages.NoCustomerNumbering);

                if (storeExt.CustomerClassID == null)
                {
                    ARSetup arSetup = PXSelect<ARSetup>.Select(processor);
                    if (arSetup.DfltCustomerClassID == null)
                        throw new PXException(WCMessages.NoCustomerClass);
                }

            });
        }

        public virtual void Validate(IProcessor iproc, IExternEntity ientity)
        {
            Validate<WCCustomerProcessor, CustomerData>(iproc, ientity, (processor, entity) =>
            {
                if (String.IsNullOrWhiteSpace(entity.Username))
                    throw new PXException(WCMessages.NoRequiredField, "Email", "Username");

                if (String.IsNullOrWhiteSpace(entity.LastName) || String.IsNullOrWhiteSpace(entity.LastName))
                    throw new PXException(WCMessages.NoRequiredField, "Last Name", "Customer");
            });
        }
    }
}
