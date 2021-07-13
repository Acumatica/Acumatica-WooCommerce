using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class TaxClasesProvider : IChildReadOnlyRestDataProvider<TaxClass>
    {
        private readonly IWooRestClient _restClient;

        public TaxClasesProvider(IWooRestClient restClient)
        {
            _restClient = restClient;
        }

        public int Count(string parentId)
        {
            throw new System.NotImplementedException();
        }

        public List<TaxClass> GetAll()
        {
            const string resourceUrl = "/taxes/classes";

            var request = _restClient.MakeRequest(resourceUrl);
            var country = _restClient.Get<List<TaxClass>>(request);
            return country;
        }

        public List<TaxClass> Get(string parentId)
        {
            throw new System.NotImplementedException();
        }

        public TaxClass GetByID(string id, string parentId)
        {
            throw new System.NotImplementedException();
        }

        public List<TaxClass> GetByParentId(string parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}