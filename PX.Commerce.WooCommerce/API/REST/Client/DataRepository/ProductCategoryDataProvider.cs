using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class ProductCategoryDataProvider : RestDataProvider
    {
        protected override string GetListUrl { get; } = "/products/categories";
        protected override string GetSingleUrl { get; } = "/products/categories/{id}";

        public ProductCategoryDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<CategoryData> Get(IFilter filter = null)
        {
            return base.Get<CategoryData, List<CategoryData>>(filter);
        }

        public IEnumerable<CategoryData> GetAll(IFilter filter = null)
        {
            return GetAll<CategoryData, List<CategoryData>>(filter);
        }

        public CategoryData GetByID(string id)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<CategoryData>(segments);
        }

        public bool Delete(CategoryData productCategoryData, int id)
        {
            return Delete(id);
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public CategoryData Create(CategoryData category)
        {
            return Create<CategoryData>(category);
        }

        public CategoryData Update(CategoryData category, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Update<CategoryData>(category, segments);
        }
        #endregion

    }
}
