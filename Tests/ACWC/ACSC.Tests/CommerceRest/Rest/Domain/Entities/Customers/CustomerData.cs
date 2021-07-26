using System;
using System.Collections.Generic;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders;
using BCApiClient.Rest;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Customers;
using BCApiClient.Rest.ExtensionMethods;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers
{
    [JsonObject(Description = Messages.Customer)]
    public class CustomerData : IBCEntityData
    {

        public CustomerData()
        {
            Addresses = new List<CustomerAddressData>();
        }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("password")]
        public virtual string Password { get; set; }

        [JsonProperty("company")]
        public virtual string Company { get; set; }

        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        [JsonProperty("email")]
        public virtual string Email { get; set; }

        [JsonProperty("phone")]
        public virtual string Phone { get; set; }

        [JsonProperty("tax_exempt_category")]
        public virtual string TaxCode { get; set; }


        [JsonIgnore]
        public virtual DateTime? DateCreated { get; set; }

        [JsonProperty("date_created")]
        public virtual string DateCreatedUT
        {
            get => DateCreated.DateTimeToString();
            set => DateCreated = value.StringToDateTime();
        }

        [JsonIgnore]
        public virtual DateTime? DateModified { get; set; }

        [JsonProperty("date_modified")]
        public virtual string DateModifiedUT
        {
            get => DateModified.DateTimeToString();
            set => DateModified = value.StringToDateTime();
        }

        [JsonProperty("store_credit")]
        public virtual decimal? StoreCredit { get; set; }

        [JsonProperty("registration_ip_address")]
        public virtual string RegistrationIpAddress { get; set; }

        [JsonProperty("customer_group_id")]
        public virtual int? CustomerGroupId { get; set; }

        [JsonProperty("notes")]
        public virtual string Notes { get; set; }

        [JsonProperty("addresses")]
        public virtual Resource ResourceAddresses { get; set; }

        [JsonProperty("accepts_marketing")]
        public bool? ReceiveASCReviewEmails { get; set; }

        [JsonProperty("reset_pass_on_login")]
        public bool? ResetPassOnLogin { get; set; }

        [JsonIgnore]
        public List<CustomerAddressData> Addresses { get; set; }

        [JsonIgnore]
        public virtual IList<OrderData> Orders { get; set; }

        public void AddAddresses(CustomerAddressData address)
        {
            Addresses.Add(address);
        }

        public void AddAddresses(List<CustomerAddressData> addresses)
        {
            if (addresses != null)
            {
                ((List<CustomerAddressData>)Addresses).AddRange(addresses);
            }
        }
    }
}
