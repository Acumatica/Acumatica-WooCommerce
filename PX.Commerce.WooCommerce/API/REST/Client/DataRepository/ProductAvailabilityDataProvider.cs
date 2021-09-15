using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class ProductAvailabilityDataProvider : RestDataProvider, IChildRestDataProvider<AvailabilityData>
    {
        protected override string GetListUrl { get; } = "/products";
        protected override string GetSingleUrl { get; } = "/products/{id}";

        protected override string GetBatchUrl { get; } = "/products/batch";

        public ProductAvailabilityDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<AvailabilityData> Get(IFilter filter = null)
        {
            return base.Get<AvailabilityData, List<AvailabilityData>>(filter);
        }

        public IEnumerable<AvailabilityData> GetAll()
        {
            throw new NotImplementedException();
        }

        public AvailabilityData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<AvailabilityData>(segments);
        }

        public bool Delete(AvailabilityData productRefundData, int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public AvailabilityData Create(AvailabilityData note)
        {
            throw new NotImplementedException();
        }

        public AvailabilityData Update(AvailabilityData category, int id)
        {
            throw new NotImplementedException();
        }

        public List<AvailabilityData> GetByParentId(string parentId)
        {
            var segments = MakeParentUrlSegments(parentId);
            var filter = new Filter { Limit = 10, OrderBy = "id" };
            return base.GetAll<AvailabilityData, List<AvailabilityData>>(filter, segments).ToList();
        }

        public AvailabilityData Create(AvailabilityData entity, string parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.Create(entity, segments);
        }

        public AvailabilityData Update(AvailabilityData entity, string id, string parentId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string parentId)
        {
            throw new NotImplementedException();
        }

        public BatchData<AvailabilityData> UpdateAll(BatchData<AvailabilityData> variantData)
        {
            return base.BatchUpdate<AvailabilityData, BatchData<AvailabilityData>>(variantData);
        }
        #endregion

    }
}
