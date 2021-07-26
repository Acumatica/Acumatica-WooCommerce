using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BCApiClient.Rest.Domain.Enumerations
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatus
    {
        [EnumMember(Value = "")]
        Unknown = 0,
        
        [EnumMember(Value = "authorized")]
        Authorized = 1,
        
        [EnumMember(Value = "captured")]
        Captured = 2,
        
        [EnumMember(Value = "refunded")]
        Refunded = 3,
        
        [EnumMember(Value = "partially refunded")]
        PartiallyRefunded = 4,
        
        [EnumMember(Value = "void")]
        Voided = 5
    }
}
