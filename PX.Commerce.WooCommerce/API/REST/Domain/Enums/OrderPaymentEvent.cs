using System.Runtime.Serialization;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Enums
{
    public enum OrderPaymentEvent
    {
        [EnumMember(Value = "purchase")]
        Purchase,

        [EnumMember(Value = "authorization")]
        Authorization,

        [EnumMember(Value = "capture")]
        Capture,

        [EnumMember(Value = "refund")]
        Refund,

        [EnumMember(Value = "void")]
        Void,

        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "settled")]
        Settled
    }
}
