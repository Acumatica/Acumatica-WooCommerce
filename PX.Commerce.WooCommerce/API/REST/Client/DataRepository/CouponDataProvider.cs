using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class CouponDataProvider : RestDataProvider, IChildReadOnlyRestDataProvider<CouponData>
    {
        protected override string GetListUrl { get; } = "/coupons";
        protected override string GetSingleUrl { get; } = "/coupons/{id}";

        public CouponDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<CouponData> Get(IFilter filter = null)
        {
            return base.Get<CouponData, List<CouponData>>(filter);
        }

        public List<CouponData> GetAll()
        {
            var request = _restClient.MakeRequest(GetListUrl);
            var coupons = _restClient.Get<List<CouponData>>(request);
            return coupons;
        }

        public CouponData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<CouponData>(segments);
        }

        public bool Delete(CouponData productRefundData, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public CouponData Create(CouponData category)
        {
            throw new System.NotImplementedException();
        }

        public CouponData Update(CouponData category, int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CouponData> GetByParentId(string parentId)
        {
            var segments = MakeParentUrlSegments(parentId);
            return base.Get<CouponData, List<CouponData>>(null, segments);
        }
        #endregion

    }
}
