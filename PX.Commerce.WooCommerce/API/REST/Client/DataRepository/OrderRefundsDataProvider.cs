using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class OrderRefundsDataProvider : RestDataProvider, IChildReadOnlyRestDataProvider<RefundData>
    {
        protected override string GetListUrl { get; } = "/orders/{parent_id}/refunds";
        protected override string GetSingleUrl { get; } = "orders/{parent_id}/refunds/{id}";

        public OrderRefundsDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<RefundData> Get(IFilter filter = null)
        {
            return base.Get<RefundData, List<RefundData>>(filter);
        }

        public List<RefundData> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public RefundData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<RefundData>(segments);
        }

        public bool Delete(RefundData productRefundData, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public RefundData Create(RefundData category)
        {
            throw new System.NotImplementedException();
        }

        public RefundData Update(RefundData category, int id)
        {
            throw new System.NotImplementedException();
        }

        public List<RefundData> GetByParentId(string parentId)
        {
            var segments = MakeParentUrlSegments(parentId);
            return base.Get<RefundData, List<RefundData>>(null, segments);
        }
        #endregion

    }
}
