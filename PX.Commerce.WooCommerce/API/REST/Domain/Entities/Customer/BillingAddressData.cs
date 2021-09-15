using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Customer
{
    [JsonObject(Description = "Customer -> Billing Address")]
    [CommerceDescription(WCCaptions.CustomerBillingAddressData)]
    public class BillingAddressData : ShippingAddressData
    {
        [JsonProperty("phone")]
        [CommerceDescription(WCCaptions.Phone, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        [ValidateRequired(AutoDefault = true)]
        public virtual string Phone { get; set; }

        [JsonProperty("email")]
        [CommerceDescription(WCCaptions.Email, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        [ValidateRequired(AutoDefault = true)]
        public virtual string Email { get; set; }

        public bool? Equals(BillingAddressData newObject)
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

                if (!result)
                    return result;
            }

            return result;
        }


    }
}
