using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Net;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class ProductRestDataProvider : RestDataProvider
    {
        protected override string GetListUrl { get; } = "/products";

        protected override string GetSingleUrl { get; } = "/products/{id}";

        public ProductRestDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

		public IEnumerable<ProductData> GetAll(IFilter filter = null)
		{
			var localFilter = filter ?? new Filter();
			localFilter.OrderBy = "date";
			return GetAll<ProductData, List<ProductData>>(localFilter);
		}

		public List<ProductData> Get(IFilter filter = null)
		{
			var localFilter = filter ?? new Filter();
			localFilter.OrderBy = "date";

			return base.Get<ProductData, List<ProductData>>(filter);
		}

		public ProductData GetByID(string id, IFilter filter = null)
		{
			var segments = MakeUrlSegments(id);
			var result = GetByID<ProductData>(segments, filter);
			return result;
		}

		public ProductData Create(ProductData product)
		{
			try
			{
				var result = base.Create(product);
				return result;
			}
			catch (BigCommerce.API.REST.RestException ex)
			{
				if (ex.ResponceStatusCode.Equals(HttpStatusCode.Conflict.ToString()))
                    throw new PXException(WCMessages.MultipleEntitiesWithUniqueField,
						PXMessages.LocalizeNoPrefix(WCCaptions.SyncDirectionExport),
						BCCaptions.StockItem, String.IsNullOrEmpty(product.Name) ? product.Sku : product.Sku + ", " + product.Name);
				throw ex;
			}
		}

		public bool Delete(int id)
		{
			var segments = MakeUrlSegments(id.ToString());
			return Delete(segments);
		}

		public ProductData Update(ProductData productData, int id)
		{
			var segments = MakeUrlSegments(id.ToString());
			var result = Update(productData, segments);
			return result;
		}
	}
}
