using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Products
{
    public class ProductVariantRestDataProvider : RestDataProviderBase, IChildRestDataProvider<ProductVariantData>
    {
        protected override string GetListUrl { get; } = "products/{parent_id}/variants";
        protected override string GetSingleUrl { get; } = "products/{parent_id}/variants/{id}"; //The same API url : variants/{id}.json
        protected override string GetCountUrl { get; } = "products/{parent_id}/variants/count";
        protected string GetAllUrl { get; } = "variants.json";
        protected override string GetSearchUrl => throw new NotImplementedException();

        public ProductVariantRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            WooCommerceRestClient = restClient;
        }

        public ProductVariantData Create(ProductVariantData entity, string productId)
        {
            var segments = MakeParentUrlSegments(productId);
            return base.Create<ProductVariantData, ProductVariantResponse>(entity, segments);
        }

        public ProductVariantData Update(ProductVariantData entity, string productId, string variantId)
        {
            var segments = MakeUrlSegments(variantId, productId);
            return Update<ProductVariantData, ProductVariantResponse>(entity, segments);
        }

        public bool Delete(string productId, string variantId)
        {
            var segments = MakeUrlSegments(variantId, productId);
            return Delete(segments);
        }

        public int Count(string productId)
        {
            var segments = MakeParentUrlSegments(productId);
            return GetCount(segments).Count;
        }

        public List<ProductVariantData> GetCurrentList(string productId, out string previousList, out string nextList, IFilter filter = null)
        {
            var segments = MakeParentUrlSegments(productId);
            return GetCurrentList<ProductVariantData, ProductVariantsResponse>(out previousList, out nextList, filter, segments);
        }

        public List<ProductVariantData> GetAll(string productId, IFilter filter = null)
        {
            var segments = MakeParentUrlSegments(productId);
            return GetAll<ProductVariantData, ProductVariantsResponse>(filter, segments);
        }

        public ProductVariantData GetByID(string productId, string variantId)
        {
            var segments = MakeUrlSegments(variantId, productId);
            return GetByID<ProductVariantData, ProductVariantResponse>(segments);
        }

        public List<ProductVariantData> GetAllWithoutParent(IFilter filter = null)
        {
            var request = BuildRequest(GetAllUrl, nameof(GetAllWithoutParent), null, filter);
            return WooCommerceRestClient.GetAll<ProductVariantData, ProductVariantsResponse>(request);
        }
    }
}