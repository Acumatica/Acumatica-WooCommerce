using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class CountriesDataProvider : IChildReadOnlyRestDataProvider<Country>
    {
        private readonly IWooRestClient _restClient;

        public CountriesDataProvider(IWooRestClient restClient)
        {
            _restClient = restClient;
        }


        public List<Country> GetAll()
        {
            const string resourceUrl = "/data/countries";

            var request = _restClient.MakeRequest(resourceUrl);
            var country = _restClient.Get<List<Country>>(request);
            return country;
        }

        public Country GetByID(string id, string parentId)
        {
            throw new System.NotImplementedException();
        }

        public List<Country> GetByParentId(string parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}