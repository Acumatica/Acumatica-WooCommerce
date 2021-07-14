using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Common
{
    [JsonObject(Description = "Order -> Billing Address")]
    public class OrderBillingAddressData : IBCEntityData
    {
        /// <summary>
        /// The first name of the addressee
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// The last name of the addressee.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        /// <summary>
        /// The company of the addressee.
        /// 
        /// [string(100)]
        /// </summary>
        [JsonProperty("company")]
        public virtual string Company { get; set; }

        /// <summary>
        /// The first street line of the address.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("street_1")]
        public virtual string Street1 { get; set; }

        /// <summary>
        /// The second street line of the address.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("street_2")]
        public virtual string Street2 { get; set; }

        /// <summary>
        /// The city or suburb of the address.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("city")]
        public virtual string City { get; set; }

        /// <summary>
        /// The state of the address.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The zip or postcode of the address.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("zip")]
        public virtual string ZipCode { get; set; }

        /// <summary>
        /// The country of the address.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("country")]
        public virtual string Country { get; set; }

        /// <summary>
        /// The country code of the country field.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("country_iso2")]
        public virtual string CountryIso2 { get; set; }

        /// <summary>
        /// The phone number of the addressee.
        /// 
        /// [string(50)]
        /// </summary>

        [JsonProperty("phone")]
        public virtual string Phone { get; set; }

        /// <summary>
        /// The email address of the addressee.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("email")]
        public virtual string Email { get; set; }

        
    }
}