using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Interfaces;
using System;
using System.Collections.Generic;

namespace BCApiClient.Rest.Client.DataRepository.Orders
{
    public class OrderTransactionsRestDataProvider : RestDataProviderV3, IChildReadOnlyRestDataProvider<OrderTransaction>
    {
        protected override string GetListUrl { get; } = "v3/orders/{parent_id}/transactions";

        protected override string GetSingleUrl => string.Empty;
        protected override string GetCountUrl => string.Empty;

        public OrderTransactionsRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        public int Count(string parentId)
        {
            return 1;
        }

        public List<OrderTransaction> Get(int id)
        {
            var segments = MakeParentUrlSegments(id.ToString());
            return base.Get<OrderTransaction, OrderTransactionData>(null, segments).Data;
        }

        #region Not implemented 

        public int Count(int parentId)
        {
            throw new NotImplementedException();
        }

        public OrderTransaction GetByID(int id, int parentId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
