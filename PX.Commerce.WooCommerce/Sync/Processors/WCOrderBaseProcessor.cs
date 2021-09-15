using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.WC;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using PX.Objects.IN;

namespace PX.Commerce.WooCommerce.Sync.Processors
{
    public abstract class WCOrderBaseProcessor<TGraph, TEntityBucket, TPrimaryMapped> : BCProcessorSingleBase<TGraph, TEntityBucket, TPrimaryMapped>, IProcessor
        where TGraph : PXGraph
        where TEntityBucket : class, IEntityBucket, new()
        where TPrimaryMapped : class, IMappedEntity, new()
    {
        public WCHelper helper = PXGraph.CreateInstance<WCHelper>();

        protected WooRestClient client;
        protected OrderRestDataProvider orderDataProvider;
        protected OrderRefundsDataProvider orderRefundsRestDataProvider;
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {
            base.Initialise(iconnector, operation);

            client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());
            orderDataProvider = new OrderRestDataProvider(client);
            orderRefundsRestDataProvider = new OrderRefundsDataProvider(client);
            

            helper.Initialize(this);
        }

        public virtual SalesOrderDetail InsertRefundAmountItem(decimal amount, StringValue branch)
        {
            var refundItem = GetBindingExt<BCBindingExt>()?.RefundAmountItemID != null ?
                InventoryItem.PK.Find((PXGraph)this, GetBindingExt<BCBindingExt>()?.RefundAmountItemID)
                : throw new PXException(WCMessages.NoRefundItem);
            decimal quantity = 1;
            if (string.IsNullOrWhiteSpace(GetBindingExt<BCBindingExt>().ReasonCode))
                throw new PXException(WCMessages.ReasonCodeRequired);

            SalesOrderDetail detail = new SalesOrderDetail();
            detail.InventoryID = refundItem.InventoryCD?.TrimEnd().ValueField();
            detail.OrderQty = quantity.ValueField();
            detail.UOM = refundItem.BaseUnit.ValueField();
            detail.Branch = branch;
            detail.UnitPrice = amount.ValueField();
            detail.ManualPrice = true.ValueField();
            detail.ReasonCode = GetBindingExt<BCBindingExt>()?.ReasonCode?.ValueField();
            return detail;
        }
    }
}
