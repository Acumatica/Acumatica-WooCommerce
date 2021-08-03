using System.Collections.Generic;
using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Customers
{
    public class CustomerAddressResponse : IEntityResponse<CustomerAddressData>
    {
        [JsonProperty("customer_address")]
        public CustomerAddressData Data { get; set; }
    }

    public class CustomerAddressesResponse : IEntitiesResponse<CustomerAddressData>
    {
        [JsonProperty("addresses")]
        public List<CustomerAddressData> Data { get; set; }
    }

    //[JsonObject(Description = "Customer -> Customer Address")]
    [JsonObject("Customer Address")]
    [Description(ShopifyCaptions.CustomerAddressData)]
    public class CustomerAddressData
    {
        /// <summary>
        /// A unique identifier for the address.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.LocationId)]
        public virtual long? Id { get; set; }

        /// <summary>
        /// A unique identifier for the customer where the address attaches to
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.CustomerId)]
        public virtual long? CustomerId { get; set; }

        /// <summary>
        /// The customer’s first name.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.FirstName)]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// The customer’s last name.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.LastName)]
        public virtual string LastName { get; set; }

        /// <summary>
        /// The customer’s first and last names.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Name)]
        public virtual string Name { get; set; }

        /// <summary>
        /// The customer’s Email Address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Email)]
        public virtual string Email { get; set; }

        /// <summary>
        /// The customer’s company.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.CompanyName)]
        public virtual string Company { get; set; }

        /// <summary>
        /// The customer's mailing address
        /// </summary>
        [JsonProperty("address_1", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.AddressLine1)]
        public string Address1 { get; set; }

        /// <summary>
        /// An additional field for the customer's mailing address.
        /// </summary>
        [JsonProperty("address_2", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.AddressLine2)]
        [ValidateRequired(AutoDefault = true)]
        public string Address2 { get; set; }

        /// <summary>
        /// The customer's city, town, or village.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.City)]
        [ValidateRequired(AutoDefault = true)]
        public virtual string City { get; set; }

        /// <summary>
        /// The customer’s region name. Typically a province, a state, or a prefecture.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.State)]
        [ValidateRequired(AutoDefault = true)]
        public virtual string State { get; set; }

        /// <summary>
        /// The customer’s postal code, also known as zip, postcode, Eircode, etc.
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Zipcode)]
        [ValidateRequired(AutoDefault = true)]
        public virtual string ZipCode { get; set; }

        /// <summary>
        /// The customer's country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Country)]
        [ValidateRequired()]
        public virtual string Country { get; set; }

        /// <summary>
        /// The customer’s normalized country name.
        /// </summary>
        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.CountryName)]
        [ValidateRequired()]
        public virtual string CountryName { get; set; }

        ///// <summary>
        ///// The two-letter country code corresponding to the customer's country.
        ///// </summary>
        //[JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        //[Description(ShopifyCaptions.CountryISOCode)]
        //public string CountryCode { get; set; }

        /// <summary>
        /// The customer’s phone number at this address.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.PhoneNumber)]
        [ValidateRequired(AutoDefault = true)]
        public virtual string Phone { get; set; }

        /// <summary>
        /// Whether this address is the default address for the customer.
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.IsDefault)]
        public virtual bool? Default { get; set; }

        public bool Equals(CustomerAddressData newObject)
        {
            var oldObject = this;
            if (ReferenceEquals(newObject, oldObject)) return true;
            if (newObject == null || oldObject == null) return false;

            if (newObject.GetType() != oldObject.GetType()) return false;

            var result = true;

            foreach (var property in newObject.GetType().GetProperties())
            {
                var objValue = property.GetValue(newObject);
                var anotherValue = property.GetValue(oldObject);
                if (objValue == null || anotherValue == null)
                    result = objValue == anotherValue;
                else if (!objValue.Equals(anotherValue)) result = false;

                if (!result && !(property.Name == nameof(newObject.Phone) || property.Name == nameof(newObject.Email)))
                    return result;
            }

            return result;
        }

    }
}