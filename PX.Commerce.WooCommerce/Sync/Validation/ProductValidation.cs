using PX.Commerce.BigCommerce.API.REST;
using PX.Commerce.Core;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;
using System;

namespace PX.Commerce.WooCommerce
{
    public class ProductValidator : BCBaseValidator, ISettingsValidator, IExternValidator
    {
        public int Priority { get { return 0; } }

        public virtual void Validate(IProcessor iproc)
        {
            Validate<WCStockItemProcessor>(iproc, (processor) =>
            {
                BCEntity entity = processor.GetEntity();
                BCBindingExt storeExt = processor.GetBindingExt<BCBindingExt>();
                if (entity.Direction != BCSyncDirectionAttribute.Export)
                {
                    if (storeExt.InventoryNumberingID == null && BCDimensionAttribute.GetAutoNumbering(BaseInventoryAttribute.DimensionName) == null)
                        throw new PXException(WCMessages.NoStockNumbering);

                    if (storeExt.StockItemClassID == null)
                    {
                        INSetup inSetup = PXSelect<INSetup>.Select(processor);
                        if (inSetup.DfltStkItemClassID == null)
                            throw new PXException(WCMessages.NoStockItemClass);
                    }
                }
            });
            Validate<WCNonStockItemProcessor>(iproc, (processor) =>
            {
                BCEntity entity = processor.GetEntity();
                BCBindingExt storeExt = processor.GetBindingExt<BCBindingExt>();
                if (entity.Direction != BCSyncDirectionAttribute.Export)
                {
                    if (storeExt.InventoryNumberingID == null && BCDimensionAttribute.GetAutoNumbering(BaseInventoryAttribute.DimensionName) == null)
                        throw new PXException(WCMessages.NoNonStockNumbering);

                    if (storeExt.NonStockItemClassID == null)
                    {
                        INSetup inSetup = PXSelect<INSetup>.Select(processor);
                        if (inSetup.DfltNonStkItemClassID == null)
                            throw new PXException(WCMessages.NoNonStockItemClass);
                    }
                }
            });
            //Validate<WCAvailabilityProcessor>(iproc, (processor) =>
            //{
            //    BCBindingExt store = processor.GetBindingExt<BCBindingExt>();
            //});
        }

        public virtual void Validate(IProcessor iproc, IExternEntity ientity)
        {
            Validate<WCStockItemProcessor, ProductData>(iproc, ientity, (processor, entity) =>
            {
                BCBindingExt store = processor.GetBindingExt<BCBindingExt>();
                if (entity.Categories.Count <= 0)
                {
                    if (String.IsNullOrEmpty(store.StockSalesCategoriesIDs))
                        throw new PXException(WCMessages.NoStockItemCategory);
                    else throw new PXException(WCMessages.CategoriesNotSynced);
                }
            });
            Validate<WCNonStockItemProcessor, ProductData>(iproc, ientity, (processor, entity) =>
            {
                BCBindingExt store = processor.GetBindingExt<BCBindingExt>();
                if (entity.Categories.Count <= 0)
                {
                    if (String.IsNullOrEmpty(store.NonStockSalesCategoriesIDs))
                        throw new PXException(WCMessages.NoNonStockItemCategory);
                    else throw new PXException(WCMessages.CategoriesNotSynced);
                }
            });
            Validate<WCTemplateItemProcessor, ProductData>(iproc, ientity, (processor, entity) =>
            {
                if (PXAccess.FeatureInstalled<FeaturesSet.matrixItem>() == false)
                    throw new PXException(BCMessages.MatrixFeatureRequired);
                BCBindingExt store = processor.GetBindingExt<BCBindingExt>();
                if (entity.Categories.Count <= 0)
                {
                    if (entity.Type == ProductsType.Digital.ToEnumMemberAttrValue() && String.IsNullOrEmpty(store.NonStockSalesCategoriesIDs))
                        throw new PXException(WCMessages.NoNonStockItemCategory);
                    else if (entity.Type == ProductsType.Physical.ToEnumMemberAttrValue() && String.IsNullOrEmpty(store.StockSalesCategoriesIDs))
                        throw new PXException(WCMessages.NoStockItemCategory);
                    else throw new PXException(WCMessages.CategoriesNotSynced);
                }
            });
        }
    }
}
