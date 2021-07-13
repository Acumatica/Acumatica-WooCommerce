using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class OrderStatusRestDataProvider : RestDataProvider
    {
        protected override string GetListUrl { get; } = "/Orders";

        protected override string GetSingleUrl { get; } = "/Orders/{id}";

        public OrderStatusRestDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        public IEnumerable<OrderStatusData> GetAll(IFilter filter = null)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";
            return GetAll<OrderStatusData, List<OrderStatusData>>(localFilter);
        }

        public List<OrderStatusData> Get(IFilter filter = null)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";

            return base.Get<OrderStatusData, List<OrderStatusData>>(filter);
        }

        public OrderStatusData GetByID(string id, IFilter filter = null)
        {
            var segments = MakeUrlSegments(id);
            var result = GetByID<OrderStatusData>(segments, filter);
            return result;
        }

        public OrderStatusData Create(OrderStatusData Order)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Delete(segments);
        }

        public OrderStatusData Update(OrderStatusData OrderStatusData, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var result = Update(OrderStatusData, segments);
            return result;
        }
    }
}
