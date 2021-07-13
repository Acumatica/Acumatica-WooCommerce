using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class OrderStatusData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreatedUT { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }
    }
}
