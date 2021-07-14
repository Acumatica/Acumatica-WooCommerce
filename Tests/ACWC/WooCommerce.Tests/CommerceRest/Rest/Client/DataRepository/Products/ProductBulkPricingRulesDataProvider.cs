using System.Collections.Generic;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Products;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products
{
    public class ProductBulkPricingRulesDataProvider : RestDataProviderV3, IParentRestDataProvider<ProductsBulkPricingRulesData>
    {
        protected override string GetListUrl { get; } =  "v3/catalog/products/{id}/bulk-pricing-rules";
        protected override string GetSingleUrl { get; }
        protected override string GetCountUrl { get; }

        public ProductBulkPricingRulesDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        public ProductsBulkPricingRulesData Create(ProductsBulkPricingRulesData entity)
        {
            throw new System.NotImplementedException();
        }

        public ProductsBulkPricingRulesData Update(ProductsBulkPricingRulesData entity, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductsBulkPricingRulesData> Get(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductsBulkPricingRulesData> GetAll(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductsBulkPricingRulesData> Get(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var orderData = GetAll<ProductsBulkPricingRulesData, ProductsBulkPricingRuleList>(null, segments).Data;
            return orderData;
        }
        
        public ProductsBulkPricingRulesData GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProductsBulkPricingRulesData GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public ItemCount Count()
        {
            throw new System.NotImplementedException();
        }

        public ItemCount Count(IFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}