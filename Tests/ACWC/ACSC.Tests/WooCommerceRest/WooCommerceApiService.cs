using ACSC.Tests.ShopifyRest.Client;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Client.DataRepository;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Customers;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Discount;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Inventory;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Order;
using ACSC.Tests.ShopifyRest.Client.DataRepository.PriceRule;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Products;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Shipping;
using ACSC.Tests.ShopifyRest.Configuration;
using ACSC.Tests.ShopifyRest.Interfaces;
using ACSC.Tests.ShopifyRest.Logger;
using Newtonsoft.Json;
using System;

namespace ACSC.Tests.ShopifyRest
{
    public class WooCommerceApiService
    {
        #region Singleton

        private static readonly Lazy<WooCommerceApiService> _service = new Lazy<WooCommerceApiService>(() => new WooCommerceApiService());
        public static WooCommerceApiService Instance { get { return _service.Value; } }
        private WooCommerceApiService()
        {
            _client = GetClient();
        }

        #endregion

        private readonly IWooCommerceRestClient _client;

        #region Customers
        public CustomerRestDataProvider CustomerRestDataProvider => Get<CustomerRestDataProvider>();
        public CustomerAddressRestDataProvider CustomerAddressRestDataProvider => Get<CustomerAddressRestDataProvider>();
        #endregion

        #region Inventory
        public InventoryItemRestDataProvider InventoryItemRestDataProvider => Get<InventoryItemRestDataProvider>();
        public InventoryLevelRestDataProvider InventoryLevelRestDataProvider => Get<InventoryLevelRestDataProvider>();
        public InventoryLocationRestDataProvider InventoryLocationRestDataProvider => Get<InventoryLocationRestDataProvider>();
        #endregion

        #region Order
        public OrderRestDataProvider OrderRestDataProvider => Get<OrderRestDataProvider>();
        public DraftOrderRestDataProvider DraftOrderRestDataProvider => Get<DraftOrderRestDataProvider>();
        #endregion

        #region Products
        public ProductRestDataProvider ProductRestDataProvider => Get<ProductRestDataProvider>();
        public ProductImageRestDataProvider ProductImageRestDataProvider => Get<ProductImageRestDataProvider>();
        public ProductVariantRestDataProvider ProductVariantRestDataProvider => Get<ProductVariantRestDataProvider>();
        #endregion

        #region Discount
        
        public DiscountRestDataProvider DiscountRestDataProvider => Get<DiscountRestDataProvider>();
        public PriceRuleRestDataProvider PriceRuleRestDataProvider => Get<PriceRuleRestDataProvider>();

        #endregion


        #region Shipping
        public FulfillmentRestDataProvider FulfillmentRestDataProvider => Get<FulfillmentRestDataProvider>(); 
        #endregion

        #region Common
        public StoreRestDataProvider StoreRestDataProvider => Get<StoreRestDataProvider>(); 
        #endregion

        #region Private
        private IWooCommerceRestClient GetClient()
        {
            var jsonSerializer = new JsonSerializer()
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Unspecified
            };

            var serializer = new RestJsonSerializer(jsonSerializer);
            var deserializer = new RestJsonSerializer(jsonSerializer);
            var logger = new ShopifyClientLogger();
            var config = new ShopifyRestConfig();
            var options = new RestOptions(config);

            return new SPRestClient(serializer, deserializer, options, logger);
        }

        private T Get<T>()
        {
            var type = typeof(T);
            var obj = Activator.CreateInstance(type, _client);
            return new Lazy<T>(() => (T)obj).Value;
        }

        #endregion
    }
}