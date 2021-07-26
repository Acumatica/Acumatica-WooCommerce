using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Shipping;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository
{
    public class StoreRestDataProvider : RestDataProviderBase
	{
        public StoreRestDataProvider(IWooCommerceRestClient restClient)
        {
            ShopifyRestClient = restClient;
		}
		protected override string GetListUrl => throw new NotImplementedException();

		protected override string GetSingleUrl => "shop.json";

		protected override string GetCountUrl => throw new NotImplementedException();

		protected override string GetSearchUrl => throw new NotImplementedException();
		private string GetShippingZoneUrl => "shipping_zones.json";

		public StoreData Get()
        {
			var request = BuildRequest(GetSingleUrl, nameof(this.Get));
			StoreData data = ShopifyRestClient.Get<StoreData,StoreResponse>(request, out var headers).Data;
			var responseTime = headers.FirstOrDefault(x => x.Name.Equals("Date", StringComparison.OrdinalIgnoreCase));
			if (responseTime != null && responseTime.Value != null && DateTime.TryParse(responseTime.Value.ToString(), out var serverTime))
			{
				data.ResponseTime = serverTime;
			}

			var paraLimit = headers.FirstOrDefault(x => x.Name.Equals("X-Shopify-Shop-Api-Call-Limit", StringComparison.OrdinalIgnoreCase));
			if (paraLimit != null && paraLimit.Value != null)
			{
				var numStr = paraLimit.Value.ToString().Split('/');
				if (numStr != null && numStr.Length == 2)
				{
					data.ApiCapacity = int.Parse(numStr[1]);
					data.ApiAvailable = data.ApiCapacity - int.Parse(numStr[0]);
				}
			}

			var apiVersion = headers.FirstOrDefault(x => x.Name.Equals("X-Shopify-API-Version", StringComparison.OrdinalIgnoreCase));
			if (apiVersion != null && apiVersion.Value != null)
			{
				data.ApiVersion = apiVersion.Value.ToString();
			}
			return data;
		}

		public List<ShippingZoneData> GetShippingZones()
		{
			var request = BuildRequest(GetShippingZoneUrl, nameof(GetShippingZones));
			return ShopifyRestClient.GetAll<ShippingZoneData, ShippingZonesResponse>(request);
		}

	}
}
