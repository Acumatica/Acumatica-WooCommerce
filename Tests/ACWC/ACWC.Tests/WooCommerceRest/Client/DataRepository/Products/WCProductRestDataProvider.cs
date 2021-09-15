using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Products
{
    public class ProductRestDataProvider : RestDataProviderBase, IParentRestDataProvider<ProductData>
    {
        protected override string GetListUrl { get; } = "products";
        protected override string GetSingleUrl { get; } = "products/{id}";
        //private string GetMetafieldsUrl { get; } = "products/{id}/metafields";

       // protected override string GetCountUrl { get; } = "products/count";
       // protected override string GetCountUrl { get; } = throw new NotImplementedException();
        protected override string GetSearchUrl => throw new NotImplementedException();

        protected override string GetCountUrl => throw new NotImplementedException();

        // private string GetMetafieldsUrl { get; } = throw new NotImplementedException();


        public ProductRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            WooCommerceRestClient = restClient;
        }

        public ProductData Create(ProductData entity)
        {
            return base.Create<ProductData, ProductResponse>(entity);
        }

        public ProductData Update(ProductData entity) => Update(entity, entity.Id.ToString());

        public ProductData Update(ProductData entity, string productId)
        {
            var segments = MakeUrlSegments(productId);
            return base.Update<ProductData, ProductResponse>(entity, segments);
        }

        public bool Delete(ProductData entity, string productId) => Delete(productId);

        public bool Delete(string productId)
        {
            var segments = MakeUrlSegments(productId);
            return Delete(segments);
        }

        public List<ProductData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            return GetCurrentList<ProductData, ProductsResponse>(out previousList, out nextList, filter);
        }

        public List<ProductData> GetAll(IFilter filter = null)
        {
            return GetAll<ProductData, ProductsResponse>(filter);
        }

        public ProductData GetByID(string productId)
        {
            var segments = MakeUrlSegments(productId);
            var entity = base.GetByID<ProductData, ProductResponse>(segments);
            //entity.Metafields = GetMetafieldsByProductId(productId);
            return entity;
        }

        public ItemCount Count()
        {
            return base.GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return base.GetCount(filter);
        }

        //public List<MetafieldData> GetMetafieldsByProductId(string productId)
        //{
        //    var request = BuildRequest(GetMetafieldsUrl, nameof(GetMetafieldsByProductId), MakeUrlSegments(productId), null);
        //    return ShopifyRestClient.GetAll<MetafieldData, MetafieldsResponse>(request);
        //}
    }
}