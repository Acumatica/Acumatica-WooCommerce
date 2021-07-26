using Newtonsoft.Json;
using PX.Commerce.Core;
using System;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{

    public class NoteData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("customer_note")]
        public bool? CustomerNote { get; set; }

        public DateTime? DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
