using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    [JsonObject(Description = "Order -> Shipment -> ShipmentItem")]
    public class OrderShipmentItem : IBCEntityData
    {
        /// <summary>
        /// The ID of the Order Product the item is associated with.
        /// </summary>
        [JsonProperty("order_product_id")]
        public virtual int? OrderProductId { get; set; }

        /// <summary>
        /// The ID of the Product the item is associated with.
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The quantity of the item in the shipment.
        /// </summary>
        [JsonProperty("quantity")]
        public virtual int Quantity { get; set; }
    }
}
