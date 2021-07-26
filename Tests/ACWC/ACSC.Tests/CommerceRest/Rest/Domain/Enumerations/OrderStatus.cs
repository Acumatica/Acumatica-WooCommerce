using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace BCApiClient.Rest.Domain.Enumerations
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderStatus
    {
        [Description(Messages.Incomplete)]
        Incomplete = 0,

        [Description(Messages.Pending)]
        Pending = 1,

        [Description(Messages.Shipped)]
        Shipped = 2,

        [Description(Messages.PartiallyShipped)]
        PartiallyShipped = 3,

        [Description(Messages.Refunded)]
        Refunded = 4,

        [Description(Messages.Cancelled)]
        Cancelled = 5,

        [Description(Messages.Declined)]
        Declined = 6,

        [Description(Messages.AwaitingPayment)]
        AwaitingPayment = 7,

        [Description(Messages.AwaitingPickup)]
        AwaitingPickup = 8,

        [Description(Messages.AwaitingShipment)]
        AwaitingShipment = 9,

        [Description(Messages.Completed)]
        Completed = 10,

        [Description(Messages.AwaitingFulfillment)]
        AwaitingFulfillment = 11,

        [Description(Messages.VerificationRequired)]
        VerificationRequired = 12,

        [Description(Messages.Disputed)]
        Disputed = 13,

        [Description(Messages.PartiallyRefunded)]
        PartiallyRefunded = 14
    }
}
