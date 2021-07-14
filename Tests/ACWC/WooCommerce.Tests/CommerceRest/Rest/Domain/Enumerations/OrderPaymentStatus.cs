using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BCApiClient.Rest.Domain.Enumerations
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderPaymentStatus
    {
        [EnumMember(Value = "ok")]
        Ok,

        [EnumMember(Value = "error")]
        Error
    }
}
