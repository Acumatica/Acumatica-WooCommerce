using Newtonsoft.Json;
using System.Text;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class TaxData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        [JsonProperty("rate_code")]
        public string RateCode { get; set; }
    }
}
