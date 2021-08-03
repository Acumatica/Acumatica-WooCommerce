using System.Collections.Generic;
using System.Linq;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Products;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.DataRepository.Products
{
    public class ProductCategoryRestDataProvider : RestDataProviderV3, IParentRestDataProvider<ProductCategoryData>
    {
        private const string id_string = "id";

        protected override string GetListUrl { get; }   = "v3/catalog/categories";
        protected override string GetSingleUrl { get; } = "v3/catalog/categories/{id}";
        protected override string GetCountUrl { get; }  = "v3/catalog/categories";

        public ProductCategoryRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public ItemCount Count()
        {
            return GetCount<ProductCategoryData, ProductCategoryList>();
        }
        public ItemCount Count(IFilter filter)
        {
            return GetCount<ProductCategoryData, ProductCategoryList>(filter);
        }

        public List<ProductCategoryData> Get(IFilter filter = null)
        {
            return Get<ProductCategoryData, ProductCategoryList>(filter)?.Data;
        }

        public List<ProductCategoryData> GetAll(IFilter filter = null)
        {
            return GetAll<ProductCategoryData, ProductCategoryList>()?.Data;
        }

        public ProductCategoryData GetByID(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return GetByID<ProductCategoryData, ProductCategory>(segments)?.Data;
        }

        public ProductCategoryData GetByName(string name)
        {
            FilterProductCategories filter = new FilterProductCategories { Name = name };
            ProductCategoryData category = Get(filter)?.FirstOrDefault();
            return category;
        }

        public List<ProductCategoryData> GetByParentId(int? id)
        {
            FilterProductCategories filter = new FilterProductCategories { ParentId = id };
            List<ProductCategoryData> categories = Get(filter);
            return categories;
        }

        public bool Delete(ProductCategoryData productCategoryData, int id)
        {
            return Delete(id);
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public ProductCategoryData Create(ProductCategoryData category)
        {
            var productCategory  = new ProductCategory{Data = category};
            return Create<ProductCategoryData, ProductCategory>(productCategory)?.Data;
        }

        public ProductCategoryData Update(ProductCategoryData category, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var productCategory  = new ProductCategory{Data = category};
            return Update<ProductCategoryData, ProductCategory>(productCategory, segments)?.Data;
        }
        #endregion

    }
}
