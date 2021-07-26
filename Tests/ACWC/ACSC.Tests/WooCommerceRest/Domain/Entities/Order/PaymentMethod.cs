using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
    public class PaymentMethod : IPaymentMethod
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("test_mode")]
        public string Test_Mode { get; set; }
    }
}