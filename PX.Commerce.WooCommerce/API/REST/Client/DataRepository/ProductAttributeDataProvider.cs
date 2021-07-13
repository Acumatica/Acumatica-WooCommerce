using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class ProductAttributeDataProvider : RestDataProvider
    {
        protected override string GetListUrl { get; } = "/products/attributes";
        protected override string GetSingleUrl { get; } = "/products/attributes/{id}";

        public ProductAttributeDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<AttributeData> Get(IFilter filter = null)
        {
            return base.Get<AttributeData, List<AttributeData>>(filter);
        }

        public IEnumerable<AttributeData> GetAll(IFilter filter = null)
        {
            return GetAll<AttributeData, List<AttributeData>>(filter);
        }

        public AttributeData GetByID(string id)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<AttributeData>(segments);
        }

        public bool Delete(AttributeData AttributeData, int id)
        {
            return Delete(id);
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public AttributeData Create(AttributeData category)
        {
            return Create<AttributeData>(category);
        }

        public AttributeData Update(AttributeData category, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Update<AttributeData>(category, segments);
        }
        #endregion

    }
}
