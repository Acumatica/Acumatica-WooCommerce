using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class ProductVariantDataProvider : RestDataProvider, IChildRestDataProvider<ProductsVariantData>
    {
        protected override string GetListUrl { get; } = "/products/{parent_id}/variations";
        protected override string GetSingleUrl { get; } = "/products/{parent_id}/variations/{id}";

        protected override string GetBatchUrl { get; } = "/products/{parent_id}/variations/batch";

        public ProductVariantDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<ProductsVariantData> Get(IFilter filter = null)
        {
            return base.Get<ProductsVariantData, List<ProductsVariantData>>(filter);
        }

        public IEnumerable<ProductsVariantData> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductsVariantData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<ProductsVariantData>(segments);
        }

        public List<ProductsVariantData> GetByParentId(string parentId)
        {
            var segments = MakeParentUrlSegments(parentId);
            var filter = new Filter { Limit = 10, OrderBy = "id" };
            return base.GetAll<ProductsVariantData, List<ProductsVariantData>>(filter, segments).ToList();
        }

        public ProductsVariantData Create(ProductsVariantData entity, string parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.Create(entity, segments);
        }

        public ProductsVariantData Update(ProductsVariantData entity, string id, string parentId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string parentId)
        {
            throw new NotImplementedException();
        }

        public BatchData<ProductsVariantData> UpdateAll(BatchData<ProductsVariantData> variantData, int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.BatchUpdate<ProductsVariantData, BatchData<ProductsVariantData>>(variantData, segments);
        }
        #endregion

    }
}
