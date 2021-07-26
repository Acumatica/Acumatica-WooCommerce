using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.Sync;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Common;
using PX.Data;
using PX.Data.BQL;
using PX.Data.BQL.Fluent;
using PX.Objects.AR;
using PX.Objects.Common;
using PX.Objects.IN;
using PX.Objects.PO;
using PX.Objects.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce
{
    public class WCShipmentEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Shipment;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary }.Concat(Orders).ToArray();

        public MappedShipment Shipment;
        public List<MappedOrder> Orders = new List<MappedOrder>();
    }

    public class SPShipmentsRestrictor : BCBaseRestrictor, IRestrictor
    {
        public virtual FilterResult RestrictExport(IProcessor processor, IMappedEntity mapped)
        {
            #region Shipments
            return base.Restrict(mapped, delegate (MappedShipment obj)
            {
                if (obj.Local != null)
                {
                    if (obj.Local.Confirmed?.Value == false)
                    {
                        return new FilterResult(FilterStatus.Invalid,
                                PXMessages.Localize(BCMessages.LogShipmentSkippedNotConfirmed));
                    }

                    if (obj.Local.OrderNoteIds != null)
                    {
                        BCBindingExt binding = processor.GetBindingExt<BCBindingExt>();

                        Boolean anyFound = false;
                        foreach (var orderNoeId in obj.Local?.OrderNoteIds)
                        {
                            if (processor.SelectStatus(BCEntitiesAttribute.Order, orderNoeId) == null) continue;

                            anyFound = true;
                        }
                        if (!anyFound)
                        {
                            return new FilterResult(FilterStatus.Ignore,
                                PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogShipmentSkippedNoOrder, obj.Local.ShipmentNumber?.Value ?? obj.Local.SyncID.ToString()));
                        }
                    }

                }

                return null;
            });
            #endregion
        }

        public virtual FilterResult RestrictImport(IProcessor processor, IMappedEntity mapped)
        {
            return null;
        }
    }

    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.Shipment, BCCaptions.Shipment,
        IsInternal = false,
        Direction = SyncDirection.Export,
        PrimaryDirection = SyncDirection.Export,
        PrimarySystem = PrimarySystem.Local,
        ExternTypes = new Type[] { typeof(OrdersShipmentData) },
        LocalTypes = new Type[] { typeof(BCShipments) },
        DetailTypes = new String[] { BCEntitiesAttribute.ShipmentLine, BCCaptions.ShipmentLine, BCEntitiesAttribute.ShipmentBoxLine, BCCaptions.ShipmentLineBox },
        AcumaticaPrimaryType = typeof(SOShipment),
        AcumaticaPrimarySelect = typeof(SOShipment.shipmentNbr),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.Order }
    )]
    public class WCShipmentProcessor : BCProcessorSingleBase<WCShipmentProcessor, WCShipmentEntityBucket, MappedShipment>, IProcessor
    {
        private const string SHIPMENT_DETAIL = "Provider : {0}{1}Tracking No : {2}";

        protected OrderRestDataProvider orderDataProvider;
        protected OrderStatusRestDataProvider orderStatusRestDataProvider;
        protected OrderShipmentDataProvider shipmentDataProvider;
        protected OrderNotesDataProvider orderNotesDataProvider;
        protected List<BCShippingMappings> shippingMappings;
        protected BCBinding currentBinding;
        protected BCBindingExt currentBindingExt;
        protected BCBindingWooCommerce currentWooCommerceSettings;

        #region Constructor
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {
            base.Initialise(iconnector, operation);
            currentBinding = GetBinding();
            currentBindingExt = GetBindingExt<BCBindingExt>();
            currentWooCommerceSettings = GetBindingExt<BCBindingWooCommerce>();

            var client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());

            orderDataProvider = new OrderRestDataProvider(client);
            shipmentDataProvider = new OrderShipmentDataProvider(client);
            orderNotesDataProvider = new OrderNotesDataProvider(client);
            orderStatusRestDataProvider = new OrderStatusRestDataProvider(client);

            shippingMappings = PXSelectReadonly<BCShippingMappings,
                Where<BCShippingMappings.bindingID, Equal<Required<BCShippingMappings.bindingID>>>>
                .Select(this, Operation.Binding).Select(x => x.GetItem<BCShippingMappings>()).ToList();
        }
        #endregion

        public override void NavigateLocal(IConnector connector, ISyncStatus status)
        {
            SOOrderShipment orderShipment = PXSelect<SOOrderShipment, Where<SOOrderShipment.shippingRefNoteID, Equal<Required<SOOrderShipment.shippingRefNoteID>>>>.Select(this, status?.LocalID);
            if (orderShipment.ShipmentType == SOShipmentType.DropShip)//dropshipment
            {
                POReceiptEntry extGraph = PXGraph.CreateInstance<POReceiptEntry>();
                EntityHelper helper = new EntityHelper(extGraph);
                helper.NavigateToRow(extGraph.GetPrimaryCache().GetItemType().FullName, status.LocalID, PXRedirectHelper.WindowMode.NewWindow);

            }
            if (orderShipment.ShipmentType == SOShipmentType.Issue && orderShipment.ShipmentNoteID == null) //Invoice
            {
                POReceiptEntry extGraph = PXGraph.CreateInstance<POReceiptEntry>();
                EntityHelper helper = new EntityHelper(extGraph);
                helper.NavigateToRow(extGraph.GetPrimaryCache().GetItemType().FullName, status.LocalID, PXRedirectHelper.WindowMode.NewWindow);

            }
            else//shipment
            {
                SOShipmentEntry extGraph = PXGraph.CreateInstance<SOShipmentEntry>();
                EntityHelper helper = new EntityHelper(extGraph);
                helper.NavigateToRow(extGraph.GetPrimaryCache().GetItemType().FullName, status.LocalID, PXRedirectHelper.WindowMode.NewWindow);

            }

        }

        #region Pull
        public override MappedShipment PullEntity(Guid? localID, Dictionary<string, object> externalInfo)
        {
            BCShipments giResult = cbapi.Put(new BCShipments() { ShippingNoteID = localID.ValueField() });
            if (giResult?.Results == null) return null;
            MapFilterFields(giResult?.Results, giResult);
            GetOrderShipment(giResult);
            if (giResult.Shipment == null && giResult.POReceipt == null) return null;
            MappedShipment obj = new MappedShipment(giResult, giResult.ShippingNoteID.Value, giResult.LastModified.Value);
            return obj;


        }
        public override MappedShipment PullEntity(String externID, String externalInfo)
        {
            OrdersShipmentData data = shipmentDataProvider.GetByID(externID.KeySplit(0), externID.KeySplit(1));
            if (data == null) return null;

            MappedShipment obj = new MappedShipment(data, new Object[] { data.OrderId, data.Id }.KeyCombine(), data.DateCreatedUT.ToDate(false), data.CalculateHash());

            return obj;
        }
        #endregion

        #region Import
        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
        }
        public override EntityStatus GetBucketForImport(WCShipmentEntityBucket bucket, BCSyncStatus syncstatus)
        {
            bucket.Shipment = bucket.Shipment.Set(new OrdersShipmentData(), syncstatus.ExternID, syncstatus.ExternTS);

            return EntityStatus.None;
        }

        public override void MapBucketImport(WCShipmentEntityBucket bucket, IMappedEntity existing)
        {
        }
        public override void SaveBucketImport(WCShipmentEntityBucket bucket, IMappedEntity existing, String operation)
        {
        }
        #endregion

        #region Export
        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            BCShipments giResult = cbapi.Put(new BCShipments()
            {
                LastModified = minDateTime.HasValue ? minDateTime.Value.ValueField() : null
            });

            if (giResult.Results != null)
            {
                foreach (var result in giResult.Results.GroupBy(x => new { x.NoteID?.Value }).ToDictionary(d => d.Key, d => d.ToList()))
                {
                    var shipment = cbapi.GetByID<Shipment>(result.Key.Value);
                    if (shipment == null)
                        continue;
                    BCShipments bCShipments = new BCShipments();
                    MapFilterFields(result.Value, bCShipments);

                    MappedShipment obj = new MappedShipment(bCShipments, bCShipments.ShippingNoteID.Value, bCShipments.LastModified.Value);
                    EntityStatus status = EnsureStatus(obj, SyncDirection.Export);
                }
            }
        }

        protected virtual void MapFilterFields(List<BCShipmentsResult> results, BCShipments impl)
        {
            impl.OrderNoteIds = new List<Guid?>();
            foreach (var result in results)
            {
                impl.ShippingNoteID = result.NoteID;
                impl.VendorRef = result.VendorRef;
                impl.ShipmentNumber = result.ShipmentNumber;
                impl.ShipmentType = result.ShipmentType;
                impl.LastModified = result.LastModifiedDateTime;
                impl.Confirmed = result.Confirmed;
                impl.OrderNoteIds.Add(result.OrderNoteID.Value);
            }
        }

        public override EntityStatus GetBucketForExport(WCShipmentEntityBucket bucket, BCSyncStatus syncstatus)
        {
            SOOrderShipments impl = new SOOrderShipments();
            BCShipments giResult = cbapi.Put(new BCShipments()
            {
                ShippingNoteID = syncstatus.LocalID.ValueField(),
                BindingID = syncstatus.BindingID.ValueField(),
                Results = new List<BCShipmentsResult>() { new BCShipmentsResult() { Custom = GetCustomFieldsForExport() } }
            });
            if (giResult?.Results == null) return EntityStatus.None;

            MapFilterFields(giResult?.Results, giResult);
            if (giResult.ShipmentType.Value == SOShipmentType.DropShip)
            {
                return GetDropShipment(bucket, giResult);
            }
            else if (giResult.ShipmentType.Value == SOShipmentType.Invoice)
            {
                return GetInvoice(bucket, giResult);
            }
            else
            {
                return GetShipment(bucket, giResult);
            }
        }


        public override void MapBucketExport(WCShipmentEntityBucket bucket, IMappedEntity existing)
        {
            MappedShipment obj = bucket.Shipment;
            if (obj.Local?.Confirmed?.Value == false) throw new PXException(BCMessages.ShipmentNotConfirmed);
            List<BCLocations> locationMappings = new List<BCLocations>();
            if (currentBindingExt.WarehouseMode == BCWarehouseModeAttribute.SpecificWarehouse)
            {
                foreach (PXResult<BCLocations, INSite, INLocation> result in PXSelectJoin<BCLocations,
                    InnerJoin<INSite, On<INSite.siteID, Equal<BCLocations.siteID>>,
                    InnerJoin<INLocation, On<INLocation.siteID, Equal<BCLocations.siteID>, And<BCLocations.locationID, IsNull, Or<BCLocations.locationID, Equal<INLocation.locationID>>>>>>,
                    Where<BCLocations.bindingID, Equal<Required<BCLocations.bindingID>>, And<BCLocations.mappingDirection, Equal<BCMappingDirectionAttribute.import>>>,
                    OrderBy<Desc<BCLocations.mappingDirection>>>.Select(this, currentBinding.BindingID))
                {
                    var bl = (BCLocations)result;
                    var site = (INSite)result;
                    var iNLocation = (INLocation)result;
                    bl.SiteCD = site.SiteCD.Trim();
                    bl.LocationCD = bl.LocationID == null ? null : iNLocation.LocationCD.Trim();
                    locationMappings.Add(bl);
                }
            }
            if (obj.Local.ShipmentType.Value == SOShipmentType.DropShip)
            {
                PurchaseReceipt impl = obj.Local.POReceipt;
                MapDropShipment(bucket, obj, impl, locationMappings);
            }
            else if (obj.Local.ShipmentType.Value == SOShipmentType.Issue)
            {
                Shipment impl = obj.Local.Shipment;
                MapShipment(bucket, obj, impl, locationMappings);
            }
            else
            {

                Shipment impl = obj.Local.Shipment;
                MapInvoice(bucket, obj, impl, locationMappings);
            }
        }

        public override CustomField GetLocalCustomField(WCShipmentEntityBucket bucket, string viewName, string fieldName)
        {
            MappedShipment obj = bucket.Shipment;
            BCShipments impl = obj.Local;
            if (impl?.Results?.Count() > 0)
                return impl.Results[0].Custom?.Where(x => x.ViewName == viewName && x.FieldName == fieldName).FirstOrDefault();
            else return null;
        }

        public override void SaveBucketExport(WCShipmentEntityBucket bucket, IMappedEntity existing, String operation)
        {
            MappedShipment obj = bucket.Shipment;

            StringBuilder key = new StringBuilder();
            String origExternId = obj.ExternID;
            var ShipmentItems = obj.Extern.LineItems;
            string errorMsg = string.Empty;
            List<DetailInfo> existingDetails = new List<DetailInfo>(obj.Details);

            obj.ClearDetails();

            Dictionary<MappedOrder, (string EntitiesAttribute, List<OrdersShipmentData> OrderOrdersShipmentData)> shipmentsToCreate 
                = new Dictionary<MappedOrder, (string EntitiesAttribute, List<OrdersShipmentData> OrderOrdersShipmentData)>();
            foreach (MappedOrder order in bucket.Orders)
            {
                OrdersShipmentData shipmentData = obj.Extern.Сlone();
                shipmentData.Id = order.ExternID.ToInt();
                shipmentData.LineItems = ShipmentItems?.Where(x => x.OrderId == order.ExternID.ToLong())?.ToList();

                if (shipmentData.LineItems.All(x => x.PackageId != null))
                {
                    shipmentData.TrackingNumbers.Clear();
                    var packages = shipmentData.LineItems.GroupBy(x => x.PackageId).ToDictionary(x => x.Key, x => x.ToList());
                    List<OrdersShipmentData> packageShipmentOfSameOrder = new List<OrdersShipmentData>();

                    foreach (var package in packages)
                    {
                        shipmentData.LineItems = package.Value;
                        shipmentData.TrackingNumbers = new List<string>();
                        var trackingNumber = obj.Local.Shipment.Packages != null && obj.Local.Shipment.Packages.Any() ?
                            obj.Local.Shipment.Packages.FirstOrDefault()?.TrackingNbr?.Value : "";
                        if (!string.IsNullOrEmpty(trackingNumber)) shipmentData.TrackingNumbers.Add(trackingNumber);
                        //Check the fulfillments in the extern order
                        packageShipmentOfSameOrder.Add(shipmentData.Сlone(true));

                    }
                    shipmentsToCreate.Add(order, (BCEntitiesAttribute.ShipmentBoxLine, packageShipmentOfSameOrder));

                }
                else
                {
                    shipmentsToCreate.Add(order, (BCEntitiesAttribute.ShipmentLine, new List<OrdersShipmentData>()
                        {
                            { shipmentData }
                        }));
                }
            }

            //Validation: tracking numbers matching and delitiong of matched shipments in BC
            Dictionary<string, (bool Fulfilled, bool Errored, string ErrorMsg)> fulfillmentStatuses = ValidateAllShipmentsCanExport(shipmentsToCreate);

            //Create all shipments for given order
            foreach (KeyValuePair<MappedOrder, (string EntitiesAttribute, List<OrdersShipmentData> OrderOrdersShipmentData)> pair in shipmentsToCreate)
            {
                if (fulfillmentStatuses[pair.Key.ExternID].Errored == true)
                    continue;
                DateTime lastModifiedOrderAt = new DateTime();
                foreach (OrdersShipmentData shipmentData in pair.Value.OrderOrdersShipmentData)
                {
                    OrdersShipmentData data = SaveFullfillment(pair.Key, shipmentData);
                    if (fulfillmentStatuses[pair.Key.ExternID].Fulfilled != true && lastModifiedOrderAt < data.DateModified)
                        lastModifiedOrderAt = (DateTime)data.DateModified;
                    var shipmentId = Guid.NewGuid().ToString().Split('-')[4];
                    obj.With(_ => { _.ExternID = null; return _; }).AddExtern(data, new object[] { data.OrderId, obj.SyncID }.KeyCombine(), data.DateCreatedUT.ToDate());
                    obj.AddDetail(pair.Value.EntitiesAttribute, pair.Key.LocalID, new object[] { data.OrderId, obj.SyncID }.KeyCombine());
                    key.Append(key.Length > 0 ? "|" + obj.ExternID : obj.ExternID);
                }
                //If all items shipped and order changed status we need to take the timestamp again
                if (fulfillmentStatuses[pair.Key.ExternID].Fulfilled == true)
                    lastModifiedOrderAt = (DateTime)orderDataProvider.GetByID(pair.Key.ExternID).DateModified;
                pair.Key.AddExtern(null, pair.Key.ExternID?.ToString(), lastModifiedOrderAt.ToDate(false));
                UpdateStatus(pair.Key, null);
            }

            obj.ExternID = key.ToString()?.TrimExternID();
            if (fulfillmentStatuses.Any(i => i.Value.Errored == true))
                UpdateStatus(obj, BCSyncOperationAttribute.ExternFailed, String.Join("", fulfillmentStatuses.Values.Where(i => i.Errored == true).Select(i => i.ErrorMsg)));
            else
                UpdateStatus(obj, operation);
        }

        public virtual Dictionary<string, (bool Fulfilled, bool Errored, string ErrorMsg)> ValidateAllShipmentsCanExport(Dictionary<MappedOrder,
            (string EntitiesAttribute, List<OrdersShipmentData> OrderOrdersShipmentData)> shipmentsToCreate)
        {
            //To track if order entirely fulfilled (for ts update of order) and 
            Dictionary<string, (bool Fulfilled, bool Errored, string ErrorMsg)> fulFillmentStatuses = 
                new Dictionary<string, (bool Fulfilled, bool Errored, string ErrorMsg)>();
            foreach (KeyValuePair<MappedOrder, (string EntitiesAttribute, List<OrdersShipmentData> OrderOrdersShipmentData)> pair in shipmentsToCreate)
            {
                string errorMsg = string.Empty;
                bool fulfillmentStatus = true, errored = false;
                fulFillmentStatuses.Add(pair.Key.ExternID, (fulfillmentStatus, errored, errorMsg));
            }
            return fulFillmentStatuses;
        }

        private OrdersShipmentData SaveFullfillment(MappedOrder order, OrdersShipmentData ordersShipmentData)
        {
            if (ordersShipmentData.TrackingNumbers.Any())
            {
                var noteEntity = new NoteData
                {
                    Author = "ERP",
                    CustomerNote = true,
                    Note = string.Format(SHIPMENT_DETAIL, ordersShipmentData?.TrackingCompany, Environment.NewLine,
                           ordersShipmentData?.TrackingNumbers?.First())
                };

                var note = orderNotesDataProvider.Create(noteEntity, order.ExternID);
                if (note == null) throw new PXException(WCMessages.ExternalOrderNotFound, order.ExternID);

                //Update external shipdata audit details (every time, it creates a record in the Note) 
                ordersShipmentData.DateCreatedUT = note.DateCreated;
                ordersShipmentData.DateModified = note.DateModified;
            }
            if (order.Local.Status.Value != PX.Objects.SO.Messages.BackOrder)
            {
                var externalOrder = orderStatusRestDataProvider.GetByID(order.ExternID);
                externalOrder.Status = OrderStatuses.Completed;
                orderStatusRestDataProvider.Update(externalOrder, externalOrder.Id.Value);
                ordersShipmentData.DateCreatedUT = DateTime.UtcNow;
            }
            else
            {
                ordersShipmentData.DateCreatedUT = DateTime.UtcNow;
            }
            return ordersShipmentData;
        }

        protected virtual void GetOrderShipment(BCShipments bCShipments)
        {
            if (bCShipments.ShipmentType.Value == SOShipmentType.DropShip)
                GetDropShipmentByShipmentNbr(bCShipments);
            else
                bCShipments.Shipment = cbapi.GetByID<Shipment>(bCShipments.ShippingNoteID.Value);

        }

        protected virtual void GetDropShipmentByShipmentNbr(BCShipments bCShipments)
        {
            bCShipments.POReceipt = new PurchaseReceipt();
            bCShipments.POReceipt.ShipmentNbr = bCShipments.ShipmentNumber;
            bCShipments.POReceipt.VendorRef = bCShipments.VendorRef;
            bCShipments.POReceipt.Details = new List<PurchaseReceiptDetail>();

            foreach (PXResult<SOLineSplit, POOrder, SOOrder> item in PXSelectJoin<SOLineSplit,
                InnerJoin<POOrder, On<POOrder.orderNbr, Equal<SOLineSplit.pONbr>>,
                InnerJoin<SOOrder, On<SOLineSplit.orderNbr, Equal<SOOrder.orderNbr>>>>,
                Where<SOLineSplit.pOReceiptNbr, Equal<Required<SOLineSplit.pOReceiptNbr>>>>
            .Select(this, bCShipments.ShipmentNumber.Value))
            {
                SOLineSplit lineSplit = item.GetItem<SOLineSplit>();
                SOOrder line = item.GetItem<SOOrder>();
                POOrder poOrder = item.GetItem<POOrder>();
                PurchaseReceiptDetail detail = new PurchaseReceiptDetail();
                detail.SOOrderNbr = lineSplit.OrderNbr.ValueField();
                detail.SOLineNbr = lineSplit.LineNbr.ValueField();
                detail.SOOrderType = lineSplit.OrderType.ValueField();
                detail.ReceiptQty = lineSplit.ShippedQty.ValueField();
                detail.ShipVia = poOrder.ShipVia.ValueField();
                detail.SONoteID = line.NoteID.ValueField();
                bCShipments.POReceipt.Details.Add(detail);
            }
        }

        protected virtual EntityStatus GetDropShipment(WCShipmentEntityBucket bucket, BCShipments bCShipments)
        {
            if (bCShipments.ShipmentNumber == null) return EntityStatus.None;
            GetDropShipmentByShipmentNbr(bCShipments);
            if (bCShipments.POReceipt == null || bCShipments.POReceipt?.Details?.Count == 0)
                return EntityStatus.None;

            MappedShipment obj = bucket.Shipment = bucket.Shipment.Set(bCShipments, bCShipments.ShippingNoteID.Value, bCShipments.LastModified.Value);
            EntityStatus status = EnsureStatus(obj, SyncDirection.Export);

            IEnumerable<PurchaseReceiptDetail> lines = bCShipments.POReceipt.Details
                .GroupBy(r => new { OrderType = r.SOOrderType.Value, OrderNbr = r.SOOrderNbr.Value })
                .Select(r => r.First());
            foreach (PurchaseReceiptDetail line in lines)
            {
                SalesOrder orderImpl = cbapi.Get(new SalesOrder() { OrderType = line.SOOrderType.Value.SearchField(), OrderNbr = line.SOOrderNbr.Value.SearchField() });
                if (orderImpl == null) throw new PXException(BCMessages.OrderNotFound, bCShipments.POReceipt.ShipmentNbr.Value);

                MappedOrder orderObj = new MappedOrder(orderImpl, orderImpl.SyncID, orderImpl.SyncTime);
                EntityStatus orderStatus = EnsureStatus(orderObj);

                if (orderObj.ExternID == null) throw new PXException(BCMessages.OrderNotSyncronized, orderImpl.OrderNbr.Value);

                bucket.Orders.Add(orderObj);
            }
            return status;
        }

        protected virtual EntityStatus GetShipment(WCShipmentEntityBucket bucket, BCShipments bCShipment)
        {
            if (bCShipment.ShippingNoteID == null || bCShipment.ShippingNoteID.Value == Guid.Empty) return EntityStatus.None;
            bCShipment.Shipment = cbapi.GetByID<Shipment>(bCShipment.ShippingNoteID.Value);
            if (bCShipment.Shipment == null || bCShipment.Shipment?.Details?.Count == 0)
                return EntityStatus.None;

            MappedShipment obj = bucket.Shipment = bucket.Shipment.Set(bCShipment, bCShipment.ShippingNoteID.Value, bCShipment.LastModified.Value);
            EntityStatus status = EnsureStatus(obj, SyncDirection.Export);

            IEnumerable<ShipmentDetail> lines = bCShipment.Shipment.Details
                .GroupBy(r => new { OrderType = r.OrderType.Value, OrderNbr = r.OrderNbr.Value })
                .Select(r => r.First());
            foreach (ShipmentDetail line in lines)
            {
                SalesOrder orderImpl = cbapi.Get(new SalesOrder() { OrderType = line.OrderType.Value.SearchField(), OrderNbr = line.OrderNbr.Value.SearchField() });
                if (orderImpl == null) throw new PXException(BCMessages.OrderNotFound, bCShipment.Shipment.ShipmentNbr.Value);
                MappedOrder orderObj = new MappedOrder(orderImpl, orderImpl.SyncID, orderImpl.SyncTime);
                EntityStatus orderStatus = EnsureStatus(orderObj);

                if (orderObj.ExternID == null) throw new PXException(BCMessages.OrderNotSyncronized, orderImpl.OrderNbr.Value);

                bucket.Orders.Add(orderObj);
            }
            return status;
        }

        protected virtual EntityStatus GetInvoice(WCShipmentEntityBucket bucket, BCShipments bCShipment)
        {
            if (bCShipment.ShipmentNumber == null) return EntityStatus.None;
            bCShipment.Shipment = new Shipment();
            bCShipment.Shipment.Details = new List<ShipmentDetail>();

            if (bCShipment.Results == null || bCShipment.Results?.Count() == 0) return EntityStatus.None;

            // line types could be multiple, making BQL return several items, this is handled by group by further down in code
            foreach (PXResult<ARTran, SOOrder> item in PXSelectJoin<ARTran,
                         InnerJoin<SOOrder, On<ARTran.sOOrderType, Equal<SOOrder.orderType>, And<ARTran.sOOrderNbr, Equal<SOOrder.orderNbr>>>>,
                         Where<ARTran.tranType, Equal<Optional<ARTran.tranType>>,
                             And<ARTran.refNbr, Equal<Required<ARTran.refNbr>>>>>
                         .Select(this, bCShipment.Results?.FirstOrDefault().InvoiceType?.Value, bCShipment.Results?.FirstOrDefault().InvoiceNbr?.Value))
            {
                ARTran line = item.GetItem<ARTran>();
                SOOrder sOOrder = item.GetItem<SOOrder>();
                ShipmentDetail detail = new ShipmentDetail();
                detail.OrderNbr = line.SOOrderNbr.ValueField();
                detail.OrderLineNbr = line.SOOrderLineNbr.ValueField();
                detail.OrderType = line.SOOrderType.ValueField();
                detail.ShippedQty = line.Qty.ValueField();
                bCShipment.Shipment.Details.Add(detail);
            }
            if (bCShipment.Shipment?.Details?.Count == 0) return EntityStatus.None;

            MappedShipment obj = bucket.Shipment = bucket.Shipment.Set(bCShipment, bCShipment.ShippingNoteID.Value, bCShipment.LastModified.Value);
            EntityStatus status = EnsureStatus(obj, SyncDirection.Export);

            IEnumerable<ShipmentDetail> lines = bCShipment.Shipment.Details
                .GroupBy(r => new { OrderType = r.OrderType.Value, OrderNbr = r.OrderNbr.Value })
                .Select(r => r.First());
            foreach (ShipmentDetail line in lines)
            {
                SalesOrder orderImpl = cbapi.Get(new SalesOrder() { OrderType = line.OrderType.Value.SearchField(), OrderNbr = line.OrderNbr.Value.SearchField() });
                if (orderImpl == null) throw new PXException(BCMessages.OrderNotFound, bCShipment.Shipment.ShipmentNbr.Value);
                MappedOrder orderObj = new MappedOrder(orderImpl, orderImpl.SyncID, orderImpl.SyncTime);
                EntityStatus orderStatus = EnsureStatus(orderObj);

                if (orderObj.ExternID == null) throw new PXException(BCMessages.OrderNotSyncronized, orderImpl.OrderNbr.Value);

                bucket.Orders.Add(orderObj);
            }
            return status;
        }

        protected virtual void MapDropShipment(WCShipmentEntityBucket bucket, MappedShipment obj, PurchaseReceipt impl, List<BCLocations> locationMappings)
        {
            OrdersShipmentData shipmentData = obj.Extern = new OrdersShipmentData();
            shipmentData.LineItems = new List<ShipmentLineItemData>();
            //shipmentData.LocationId = defaultLocationId;
            var shipvia = impl.Details.FirstOrDefault(x => !string.IsNullOrEmpty(x.ShipVia?.Value))?.ShipVia?.Value ?? string.Empty;
            shipmentData.TrackingCompany = GetCarrierName(shipvia);
            shipmentData.TrackingNumbers = new List<string>() { impl.VendorRef?.Value };

            foreach (MappedOrder order in bucket.Orders)
            {
                foreach (PurchaseReceiptDetail line in impl.Details ?? new List<PurchaseReceiptDetail>())
                {
                    SalesOrderDetail orderLine = order.Local.Details.FirstOrDefault(d =>
                        order.Local.OrderType.Value == line.SOOrderType.Value && order.Local.OrderNbr.Value == line.SOOrderNbr.Value && d.LineNbr.Value == line.SOLineNbr.Value);
                    if (orderLine == null) continue; //skip shipment that is not from this order

                    DetailInfo lineInfo = order.Details.FirstOrDefault(d => d.EntityType == BCEntitiesAttribute.OrderLine && d.LocalID == orderLine.NoteID.Value);
                    if (lineInfo == null) lineInfo = MatchOrderLineFromExtern(order?.ExternID, orderLine.InventoryID.Value); //Try to fetch line data from external system in case item was extra added but not synced to ERP
                    if (lineInfo == null) throw new PXException(BCMessages.OrderShippingLineSyncronized, orderLine.InventoryID?.Value, order.Local.OrderNbr.Value, order?.ExternID);

                    ShipmentLineItemData shipItem = new ShipmentLineItemData();
                    shipItem.Id = lineInfo.ExternID.ToInt();
                    shipItem.Quantity = (int)line.ReceiptQty.Value;
                    shipItem.OrderId = order.ExternID.ToInt();

                    shipmentData.LineItems.Add(shipItem);
                    shipmentData.OrderId = order.ExternID.ToInt().Value;

                }
            }
        }

        protected virtual void MapInvoice(WCShipmentEntityBucket bucket, MappedShipment obj, Shipment impl, List<BCLocations> locationMappings)
        {
            OrdersShipmentData shipmentData = obj.Extern = new OrdersShipmentData();
            shipmentData.LineItems = new List<ShipmentLineItemData>();

            foreach (MappedOrder order in bucket.Orders)
            {
                foreach (ShipmentDetail line in impl.Details ?? new List<ShipmentDetail>())
                {

                    SalesOrderDetail orderLine = order.Local.Details.FirstOrDefault(d =>
                        order.Local.OrderType.Value == line.OrderType.Value && order.Local.OrderNbr.Value == line.OrderNbr.Value && d.LineNbr.Value == line.OrderLineNbr.Value);
                    if (orderLine == null) continue; //skip shipment that is not from this order

                    DetailInfo lineInfo = order.Details.FirstOrDefault(d => d.EntityType == BCEntitiesAttribute.OrderLine && d.LocalID == orderLine.NoteID.Value);
                    if (lineInfo == null) lineInfo = MatchOrderLineFromExtern(order?.ExternID, orderLine.InventoryID.Value); //Try to fetch line data from external system in case item was extra added but not synced to ERP
                    if (lineInfo == null) throw new PXException(BCMessages.OrderShippingLineSyncronized, orderLine.InventoryID?.Value, order.Local.OrderNbr.Value, order?.ExternID);

                    ShipmentLineItemData shipItem = new ShipmentLineItemData();
                    shipItem.Id = lineInfo.ExternID.ToInt();
                    shipItem.Quantity = (int)line.ShippedQty.Value;
                    shipItem.OrderId = order.ExternID.ToInt();
                    shipmentData.LineItems.Add(shipItem);
                }
                shipmentData.OrderId = order.ExternID.ToInt().Value;
            }
        }

        protected virtual void MapShipment(WCShipmentEntityBucket bucket, MappedShipment obj, Shipment impl, List<BCLocations> locationMappings)
        {
            OrdersShipmentData shipmentData = obj.Extern = new OrdersShipmentData();
            shipmentData.LineItems = new List<ShipmentLineItemData>();
            //shipmentData.LocationId = GetMappedExternalLocation(locationMappings, impl.WarehouseID.Value, impl.Details.FirstOrDefault()?.LocationID.Value);
            shipmentData.TrackingCompany = GetCarrierName(impl.ShipVia?.Value ?? string.Empty);
            shipmentData.TrackingNumbers = new List<string>();
            var PackageDetails = PXSelect<SOShipLineSplitPackage,
            Where<SOShipLineSplitPackage.shipmentNbr, Equal<Required<SOShipLineSplitPackage.shipmentNbr>>
            >>.Select(this, impl.ShipmentNbr?.Value).RowCast<SOShipLineSplitPackage>().ToList();
            var packages = impl.Packages ?? new List<ShipmentPackage>();
            if (packages.Count == 1)
            {
                var trackingNumber = packages.FirstOrDefault()?.TrackingNbr?.Value;
                if (!string.IsNullOrEmpty(trackingNumber)) shipmentData.TrackingNumbers.Add(trackingNumber);
            }
            else
                foreach (ShipmentPackage package in packages)
                {
                    var detail = PackageDetails.Where(x => x.PackageLineNbr == package.LineNbr?.Value && x.PackedQty != 0)?.ToList() ?? new List<SOShipLineSplitPackage>();
                    if (detail.Count == 0)
                        throw new PXException(BCMessages.BoxesWithoutItems, impl.ShipmentNbr.Value, package.TrackingNbr?.Value);
                    package.ShipmentLineNbr.AddRange(detail.Select(x => new Tuple<int?, decimal?>(x.ShipmentLineNbr, x.PackedQty)));
                }


            foreach (MappedOrder order in bucket.Orders)
            {
                foreach (ShipmentDetail line in impl.Details ?? new List<ShipmentDetail>())
                {
                    List<ShipmentPackage> details = null;
                    if (packages.Count > 1)
                    {
                        details = packages.Where(x => (x.ShipmentLineNbr.Select(y => y.Item1)).Contains(line.LineNbr?.Value))?.ToList();
                        if (details == null || (details != null && (details.SelectMany(x => x.ShipmentLineNbr)?.Where(x => x.Item1 == line.LineNbr.Value && x.Item2 != null)?.Sum(x => x.Item2) ?? 0) != line.ShippedQty?.Value))//  check if shipped item quatity matches the  quantity of item in package 
                            throw new PXException(BCMessages.ItemsWithoutBoxes, impl.ShipmentNbr.Value, line.InventoryID?.Value);
                    }
                    SalesOrderDetail orderLine = order.Local.Details.FirstOrDefault(d =>
                        order.Local.OrderType.Value == line.OrderType.Value && order.Local.OrderNbr.Value == line.OrderNbr.Value && d.LineNbr.Value == line.OrderLineNbr.Value);
                    if (orderLine == null) continue; //skip shipment that is not from this order

                    DetailInfo lineInfo = order.Details.FirstOrDefault(d => d.EntityType == BCEntitiesAttribute.OrderLine && d.LocalID == orderLine.NoteID.Value);
                    if (lineInfo == null) lineInfo = MatchOrderLineFromExtern(order?.ExternID, orderLine.InventoryID.Value); //Try to fetch line data from external system in case item was extra added but not synced to ERP
                    if (lineInfo == null) throw new PXException(BCMessages.OrderShippingLineSyncronized, orderLine.InventoryID?.Value, order.Local.OrderNbr.Value, order?.ExternID);
                    if (details != null)
                    {
                        foreach (var detail in details)
                        {
                            ShipmentLineItemData shipItem = new ShipmentLineItemData();
                            shipItem.Id = lineInfo.ExternID.ToInt();
                            shipItem.OrderId = order.ExternID.ToInt();
                            shipItem.Quantity = (int)(detail?.ShipmentLineNbr.Where(x => x.Item1 == line.LineNbr?.Value)?.Sum(x => x.Item2) ?? 0);
                            shipItem.PackageId = detail?.NoteID?.Value ?? new Guid();
                            shipmentData.LineItems.Add(shipItem);
                        }
                    }
                    else
                    {
                        ShipmentLineItemData shipItem = new ShipmentLineItemData();
                        shipItem.Id = lineInfo.ExternID.ToInt();
                        shipItem.Quantity = (int)line.ShippedQty.Value;
                        shipItem.OrderId = order.ExternID.ToInt();
                        shipmentData.LineItems.Add(shipItem);
                    }
                }
                shipmentData.OrderId = order.ExternID.ToInt().Value;
            }
        }

        protected virtual string GetCarrierName(string shipVia)
        {
            string company = null;
            if (!string.IsNullOrEmpty(shipVia))
            {
                PX.Objects.CS.Carrier carrierData = SelectFrom<PX.Objects.CS.Carrier>.Where<PX.Objects.CS.Carrier.carrierID.IsEqual<@P.AsString>>.View.Select(this, shipVia);
                if (!string.IsNullOrEmpty(carrierData?.CarrierPluginID))
                {
                    company = carrierData?.CarrierPluginID;
                }
                else
                    company = shipVia;
                company = GetSubstituteExternByLocal(BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.Carriers), company, company);
            }

            return company;
        }

        protected DetailInfo MatchOrderLineFromExtern(string externalOrderId, string identifyKey)
        {
            DetailInfo lineInfo = null;
            if (string.IsNullOrEmpty(externalOrderId) || string.IsNullOrEmpty(identifyKey))
                return lineInfo;
            var orderLineDetails = orderDataProvider.GetByID(externalOrderId)?.LineItems;
            var matchedLine = orderLineDetails?.FirstOrDefault(x => string.Equals(x?.Sku, identifyKey, StringComparison.OrdinalIgnoreCase));
            if (matchedLine != null && matchedLine?.Id.HasValue == true)
            {
                lineInfo = new DetailInfo(BCEntitiesAttribute.OrderLine, null, matchedLine.Id.ToString());
            }
            return lineInfo;
        }
        #endregion
    }
}