using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Net;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class OrderRestDataProvider : RestDataProvider
    {
        protected override string GetListUrl { get; } = "/Orders";

        protected override string GetSingleUrl { get; } = "/Orders/{id}";

        public OrderRestDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        public IEnumerable<OrderData> GetAll(IFilter filter = null)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";
            return GetAll<OrderData, List<OrderData>>(localFilter);
        }


        public IEnumerable<OrderData> GetAllToDate(IFilter filter = null, int maxDays = 0)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";
            if(maxDays == 0)
                return GetAll<OrderData, List<OrderData>>(localFilter);

            return GetAllUptoDate<OrderData, List<OrderData>>(localFilter, null, maxDays);
        }

        public List<OrderData> Get(IFilter filter = null)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";

            return base.Get<OrderData, List<OrderData>>(filter);
        }

        public OrderData GetByID(string id, IFilter filter = null)
        {
            var segments = MakeUrlSegments(id);
            var result = GetByID<OrderData>(segments, filter);
            return result;
        }

        public OrderData Create(OrderData Order)
        {
            try
            {
                var result = base.Create(Order);
                return result;
            }
            catch (BigCommerce.API.REST.RestException ex)
            {
                if (ex.ResponceStatusCode.Equals(HttpStatusCode.Conflict.ToString()))
                    throw new PXException(WCMessages.MultipleEntitiesWithUniqueField,
                        PXMessages.LocalizeNoPrefix(WCCaptions.SyncDirectionExport),
                        BCCaptions.Order, String.IsNullOrEmpty(Order.Number) ? Order.OrderKey : Order.OrderKey + ", " + Order.Number);
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Delete(segments);
        }

        public OrderData Update(OrderData OrderData, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var result = Update(OrderData, segments);
            return result;
        }
    }
}
