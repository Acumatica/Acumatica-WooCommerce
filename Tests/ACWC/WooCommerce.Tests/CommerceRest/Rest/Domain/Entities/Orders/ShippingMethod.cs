using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class ShippingMethod
    {
        /// <summary>
        /// The id of the Shipping Method
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// Name of the Shipping Method
        /// 
        /// string(150)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Method Name of the Shipping Method
        /// 
        /// string(100)
        /// </summary>
        [JsonProperty("method_name")]
        public virtual string MethodName { get; set; }
    }
}
