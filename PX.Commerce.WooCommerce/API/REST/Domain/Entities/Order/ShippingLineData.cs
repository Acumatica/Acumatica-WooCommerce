using Newtonsoft.Json;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class ShippingLineData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("method_title")]
        public string MethodTitle { get; set; }

        [JsonProperty("method_id")]
        public string MethodId { get; set; }

        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        public decimal TotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(Total, out val) ? val : 0;
            }
        }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        public decimal TotalTaxinDecimal {
            get
            {
                decimal val;
                return decimal.TryParse(TotalTax, out val) ? val : 0;
            }
        }

        [JsonProperty("taxes")]
        public List<TaxData> Taxes { get; set; }
    }
}
