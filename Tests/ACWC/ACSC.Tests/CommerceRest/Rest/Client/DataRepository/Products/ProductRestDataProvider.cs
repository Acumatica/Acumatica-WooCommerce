using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Products;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products
{
    public class ProductRestDataProvider : RestDataProviderV3,  IParentRestDataProvider<ProductData>
    {        
        protected override string GetListUrl     { get; } = "v3/catalog/products?include=variants,images,modifiers";
        protected override string GetSingleUrl   { get; } = "v3/catalog/products/{id}?include=variants,images,modifiers";
        protected override string GetCountUrl    { get; } = "v3/catalog/products";

        public ProductRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        #region IParentRestDataProvider

        public ItemCount Count()
        {
            return GetCount<ProductData, ProductList>();                        
        }

        public ItemCount Count(IFilter filter)
        {
            return GetCount<ProductData, ProductList>(filter);   
        }

        public List<ProductData> GetAll(IFilter filter = null)
        {
            return GetAll<ProductData, ProductList>(filter).Data;
        }

        public List<ProductData> Get(IFilter filter = null)
        {
            return base.Get<ProductData, ProductList>(filter).Data;
        }
       

        public ProductData GetByID(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var result = GetByID<ProductData, Product>(segments);
            return result.Data;           
        }
        
        public ProductData Create(ProductData productData)
        {            
            var product = new Product { Data = productData };
            var result = base.Create<ProductData, Product>(product);
            return result.Data;
        }

        public bool Delete(ProductData productData, int id)
        {
            return Delete(id);
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Delete(segments);
        }
        public ProductData Update(ProductData productData, int id)
        {
            var product = new Product { Data = productData };
            var segments = MakeUrlSegments(id.ToString());
            var result = Update<ProductData, Product>(product, segments);
            return result.Data;
        }

        public ProductData GetByName(string name)
        {
            FilterProducts filter = new FilterProducts { Name = name };
            ProductData product = Get(filter)?.FirstOrDefault();
            return product;
        }

        public ProductData GetBySku(string sku)
        {
            FilterProducts filter = new FilterProducts { SKU = sku };
            ProductData product = Get(filter)?.FirstOrDefault();
            return product;
        }

        public List<ProductData> GetByCategoryID(int categoryId)
        {
            FilterProducts filter = new FilterProducts { CategoriesIn = categoryId.ToString() };
            List<ProductData> products = Get(filter);
            return products;
        }
        #endregion
    }
}
