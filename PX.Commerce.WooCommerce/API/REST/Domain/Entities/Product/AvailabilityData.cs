using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    public class AvailabilityData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("sku")]
        [CommerceDescription(WCCaptions.StockKeepingUnit, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Sku { get; set; }

        public DateTime? DateModified { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("stock_status")]
        public string Availability { get; set; }

        [JsonProperty("manage_stock")]
        public bool? ManageStock { get; set; }

        //[JsonProperty("manage_stock")]
        public string InventoryTracking { get; set; }

        public List<ProductsVariantData> Variants { get; set; }

        [JsonProperty("stock_quantity")]
        public int? InventoryLevel { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.ProductName, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get; set; }

        [JsonProperty("slug")]
        [CommerceDescription(WCCaptions.Slug, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Slug { get; set; }

        [JsonProperty("type")]
        [CommerceDescription(WCCaptions.ProductType, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Type { get; set; }

        [JsonProperty("status")]
        [CommerceDescription(WCCaptions.Status, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Status { get; set; }


        public bool? IsPriceHidden { get; set; }
    }
}
