using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;
using PX.Commerce.WooCommerce.API.REST.Interfaces;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class SystemStatusProvider : IRestDataReader<SystemStatusData>
    {
        private readonly IWooRestClient _restClient;

        public SystemStatusProvider(IWooRestClient restClient)
        {
            _restClient = restClient;
        }


        public SystemStatusData Get()
        {
            const string resourceUrl = "/system_status";

            var request = _restClient.MakeRequest(resourceUrl);
            var country = _restClient.Get<SystemStatusData>(request);
            return country;
        }
    }
}