using System.Collections.Generic;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Interfaces;
using BigCommerce.Process.REST.Domain.Entities.Products;
using BigCommerce.REST.Domain.Entities.Products;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products
{
    public class ProductVariantRestDataProvider : RestDataProviderV3, IChildRestDataProvider<ProductsVariantData>
    {
        private const string id_string = "id";
        private const string parent_id_string = "parent_id";
        protected override string GetListUrl { get; }   = "v3/catalog/products/{id}/variants";
        protected override string GetSingleUrl { get; } = "v3/catalog/products/{parent_id}/variants/{id}";
        protected override string GetCountUrl { get; }  = "v3/catalog/categories/count";
        
        public ProductVariantRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        
        public List<ProductsVariantData>Get(string id)
        {
            var segments = new UrlSegments();
            segments.Add(id_string, id);

            return base.Get<ProductsVariantData, ProductVariantList>(null, segments).Data;
        }

        public int Count(string productId)
        {
            var segments = MakeUrlSegments(productId);
            var result = GetCount<ProductsVariantData, ProductVariantList>(segments);

            return result.Count;
        }

        public ProductsVariantData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id, parentId);
            return GetByID<ProductsVariantData, ProductsVariant>(segments).Data;
        }

        public ProductsVariantData Create(ProductsVariantData productsVariantData, string parentId)
        {
            var productsVariant = new ProductsVariant { Data = productsVariantData };
            var segments = MakeParentUrlSegments(parentId);
            return Create<ProductsVariantData, ProductsVariant>(productsVariant, segments).Data;
        }
        
        public ProductsVariantData Update(ProductsVariantData productsVariantData, string id, string parentId)
        {
            var segments = MakeUrlSegments(id, parentId);
            var productVariant = new ProductsVariant {Data = productsVariantData};
            return Update<ProductsVariantData, ProductsVariant>(productVariant, segments).Data;
        }
        
        public bool Delete(string id, string parentId)
        {
            var segments = MakeUrlSegments(id, parentId);
            return base.Delete(segments);
        }

        public int Count(int parentId)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductsVariantData> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProductsVariantData GetByID(int id, int parentId)
        {
            throw new System.NotImplementedException();
        }

        public ProductsVariantData Create(ProductsVariantData entity, int parentId)
        {
            throw new System.NotImplementedException();
        }

        public ProductsVariantData Update(ProductsVariantData entity, int id, int parentId)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
