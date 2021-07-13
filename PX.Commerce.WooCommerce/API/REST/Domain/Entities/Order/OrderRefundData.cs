using Newtonsoft.Json;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class OrderRefundData
    {
        private decimal totalDecimal;

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        public decimal TotalDecimal
        {
            get
            {
                decimal val;
                totalDecimal = decimal.TryParse(Total, out val) ? val : 0;
                return totalDecimal;
            }
        }
    }
}
