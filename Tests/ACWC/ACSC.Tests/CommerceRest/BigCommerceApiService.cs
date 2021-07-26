using System;
using ACSC.Tests.BigCommerceRest.Rest.Client.Common;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products;
using BCApiClient.Rest.Client;
using BCApiClient.Rest.Client.DataRepository.Customers;
using BCApiClient.Rest.Client.DataRepository.Products;
using BCApiClient.Rest.Interfaces;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Orders;
using BCApiClient.Rest.Client.DataRepository.Orders;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.PriceList;

namespace ACSC.Tests.BigCommerceRest
{
    public class BigCommerceApiService
    {
        #region Singleton

        private static readonly Lazy<BigCommerceApiService> _service = new Lazy<BigCommerceApiService>(() => new BigCommerceApiService());
        public static BigCommerceApiService Instance => _service.Value;

        private BigCommerceApiService()
        {
            _client = GetClient();
        }

        #endregion

        private readonly IBigCommerceRestClient _client;

        #region Customer

        public CustomerAddressRestDataProvider customerAddressRestDataProvider => Get<CustomerAddressRestDataProvider>();
        public CustomerRestDataProvider сustomerRestDataProvider => Get<CustomerRestDataProvider>(new object[] { _client, customerAddressRestDataProvider });
        public CustomerFormFieldValuesDataProvider customerFormFieldValuesDataProvider => Get<CustomerFormFieldValuesDataProvider>();

        #endregion

        #region PriceList

        public PriceListDataProvider PriceListRestDataProvider => Get<PriceListDataProvider>();

        #endregion

        #region Products

        public ProductRestDataProvider ProductRestDataProvider => Get<ProductRestDataProvider>();
        public ProductImagesDataProvider ProductImageRestDataProvider => Get<ProductImagesDataProvider>();
        public ProductBulkPricingRulesDataProvider ProductBulkPricingRulesRestDataProvider => Get<ProductBulkPricingRulesDataProvider>();
        public ProductVariantRestDataProvider ProductVariantsRestDataProvider => Get<ProductVariantRestDataProvider>();

        #endregion

        #region Orders

        public OrderRestDataProvider OrderDataProvider => Get<OrderRestDataProvider>();
        public OrderPaymentRestDataProvider OrderPaymentRestDataProvider => Get<OrderPaymentRestDataProvider>();

        #endregion

        private IBigCommerceRestClient GetClient()
        {
            //var restOptions = new RestOptions
            //{
            //    BaseUrl = "https://api.bigcommerce.com/stores/au0yq07lpf",
            //    XAuthClient = "17ndibgzjdrw6z90iyyo4hq7lu55dlt",
            //    XAuthToken = "54soa4mmvw0u1ll1h20w4of8zctmoq7"
            //};
            var restOptions = new RestOptions
            {
                BaseUrl = "https://api.bigcommerce.com/stores/sy4le8dl1q",
                XAuthClient = "a0z861cspd97n8oarpgj9j7yrc4g299",
                XAuthToken = "swtuytztyiyegbcjlj0vzb9mgx0t1gy"
            };

            return new BCRestClient(restOptions);
        }

        private T Get<T>(object[] args = null)
        {
            if (args == null)
            {
                args = new object[] { _client };
            }

            var type = typeof(T);
            var obj = Activator.CreateInstance(type, args);
            return new Lazy<T>(() => (T)obj).Value;
        }
    }
}