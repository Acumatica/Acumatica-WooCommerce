using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Customers
{
    [JsonObject(Description = Messages.CustomerCustomerAddres)]
    public class CustomerAddressData : IBCEntityData
    {
        [JsonProperty("id")]
        public virtual int? Id { get; set; }

        [JsonProperty("customer_id")]
        public virtual int? CustomerId { get; set; }

        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        [JsonProperty("company")]
        public virtual string Company { get; set; }

        [JsonProperty("street_1")]
        public virtual string Street1 { get; set; }

        [JsonProperty("street_2")]
        public virtual string Street2 { get; set; }

        [JsonProperty("city")]
        public virtual string City { get; set; }

        [JsonProperty("state")]
        public virtual string State { get; set; }

        [JsonProperty("zip")]
        public virtual string ZipCode { get; set; }

        [JsonProperty("country")]
        public virtual string Country { get; set; }

        [JsonProperty("country_iso2")]
        public virtual string CountryIso2 { get; set; }

        [JsonProperty("phone")]
        public virtual string Phone { get; set; }

        [JsonProperty("address_type")]
        public virtual string AddressType { get; set; }
    }
}
