using System.Collections.Generic;
using BCApiClient.Rest;
using BCApiClient.Rest.Client.Common;
using Newtonsoft.Json;

namespace BigCommerce.Process.REST.Domain.Options
{
    [JsonObject(Description = Messages.ProductProductOptionOptionValue)]
    public class ProductOptionValueData
    {
        public ProductOptionValueData()
        {
            ValueData = new List<object>();
        }

        [JsonProperty("id")]
        public int? Id { get; set; }
    
        [JsonProperty("label")]                                    
        public string Label { get; set; }                          
                                                                   
 
        [JsonProperty("sort_order")]                               
        public int SortOrder { get; set; }                         
     
        [JsonProperty("value_data")]
        [JsonConverter(typeof(SingleValueArrayConverter<object>))]
        public List<object> ValueData { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
    }
}
