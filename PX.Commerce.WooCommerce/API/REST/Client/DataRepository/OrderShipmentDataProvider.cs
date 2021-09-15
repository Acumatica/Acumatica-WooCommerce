using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class OrderShipmentDataProvider : RestDataProvider, IChildRestDataProvider<OrdersShipmentData>
    {
        private const string SHIPMENT_DETAIL = "Provider : {0}{1}Tracking No : {2}";

        protected override string GetListUrl { get; } = "/orders/{parent_id}/notes";
        protected override string GetSingleUrl { get; } = "/orders/{parent_id}/notes/{id}";

        public OrderShipmentDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<OrdersShipmentData> Get(IFilter filter = null)
        {
            return base.Get<OrdersShipmentData, List<OrdersShipmentData>>(filter);
        }

        public IEnumerable<OrdersShipmentData> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public OrdersShipmentData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id, parentId);
            return GetByID<OrdersShipmentData>(segments);
        }

        public bool Delete(OrdersShipmentData productRefundData, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public OrdersShipmentData Create(OrdersShipmentData note)
        {
            throw new System.NotImplementedException();
        }

        public OrdersShipmentData Update(OrdersShipmentData category, int id)
        {
            throw new System.NotImplementedException();
        }

        public List<OrdersShipmentData> GetByParentId(string parentId)
        {
            var segments = MakeParentUrlSegments(parentId);
            return base.Get<OrdersShipmentData, List<OrdersShipmentData>>(null, segments);
        }

        public OrdersShipmentData Create(OrdersShipmentData entity, string parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            var noteEntity = new NoteData
            {
                Author = "ERP",
                CustomerNote = true,
                Note = string.Format(SHIPMENT_DETAIL, entity?.TrackingCompany, Environment.NewLine,
                                    entity?.TrackingNumbers?.First())
            };
            var note = base.Create<NoteData>(noteEntity, segments);
            entity.Id = note.Id;
            entity.DateCreatedUT = note.DateCreated;
            entity.DateModified = note.DateModified;
            return entity;
        }

        public OrdersShipmentData Update(OrdersShipmentData entity, string id, string parentId)
        {
            var segments = MakeUrlSegments(parentId, id);
            var noteEntity = new NoteData
            {
                Author = "ERP",
                CustomerNote = true,
                Note = string.Format(SHIPMENT_DETAIL, entity?.TrackingCompany, Environment.NewLine,
                                    entity?.TrackingNumbers?.First())
            };
            var note = base.Update<NoteData>(noteEntity, segments);
            entity.Id = note.Id;
            entity.DateCreatedUT = note.DateCreated;
            entity.DateModified = note.DateModified;
            return entity;
        }

        public bool Delete(string id, string parentId)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}
