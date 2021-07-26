using System.Collections.Generic;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Interfaces;
using BCApiClient.Rest.Domain.Entities.Products;

namespace BCApiClient.Rest.Client.DataRepository.Products
{
    public class ProductImagesDataProvider : RestDataProviderV3, IChildRestDataProvider<ProductsImageData>
    {
        protected override string GetListUrl { get; } = "v3/catalog/products/{parent_id}/images";
        protected string GetListUrlV2 { get; } = "v2/products/{parent_id}/images";
        protected override string GetSingleUrl { get; } = "v3/catalog/products/{parent_id}/images/{id}";
        protected override string GetCountUrl { get; } = string.Empty;

        public ProductImagesDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        public ProductsImageData Create(ProductsImageData productsImageData, int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            var productsImage = new ProductsImage { Data = productsImageData };
            return Create<ProductsImageData, ProductsImage>(productsImage, segments).Data;
        }

        public bool Delete(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            var request = _restClient.MakeRequest(GetListUrlV2, segments.GetUrlSegments());
            return _restClient.Delete(request);
        }

        public List<ProductsImageData> Get(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.Get<ProductsImageData, ProductsImageList>(null, segments).Data;
        }

        #region Not implemented 

        public ProductsImageData Update(ProductsImageData productsImageFileData, int id, int parentId)
        {
            throw new System.NotImplementedException();
        }

        public int Count(int parentId)
        {
            throw new System.NotImplementedException();
        }

        public ProductsImageData GetByID(int id, int parentId)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
