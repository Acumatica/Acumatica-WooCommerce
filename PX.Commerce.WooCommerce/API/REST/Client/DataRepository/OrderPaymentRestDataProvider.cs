using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class OrderPaymentRestDataProvider : RestDataProvider
    {
        protected override string GetListUrl { get; } = "/Orders";

        protected override string GetSingleUrl { get; } = "/Orders/{id}";

        public OrderPaymentRestDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        public IEnumerable<OrdersTransactionData> GetAll(IFilter filter = null)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";
            return GetAll<OrdersTransactionData, List<OrdersTransactionData>>(localFilter);
        }

        public List<OrdersTransactionData> Get(IFilter filter = null)
        {
            var localFilter = filter ?? new Filter();
            localFilter.OrderBy = "modified";

            return base.Get<OrdersTransactionData, List<OrdersTransactionData>>(filter);
        }

        public OrdersTransactionData GetByID(string id, IFilter filter = null)
        {
            var segments = MakeUrlSegments(id);
            var result = GetByID<OrdersTransactionData>(segments, filter);
            return result;
        }

        public OrdersTransactionData Create(OrdersTransactionData Order)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrdersTransactionData Update(OrdersTransactionData OrdersTransactionData, int id)
        {
            throw new NotImplementedException();
        }
    }
}
