using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product Variant")]
    public class ProductsVariantData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }


        [JsonProperty("description")]
        [CommerceDescription(WCCaptions.ProductDescription, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Description { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("sku")]
        [CommerceDescription(WCCaptions.StockKeepingUnit, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Sku { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("regular_price")]
        [CommerceDescription(WCCaptions.RegularPrice, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        [CommerceDescription(WCCaptions.SalePrice, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string SalePrice { get; set; }

        [JsonProperty("date_on_sale_from")]
        [CommerceDescription(WCCaptions.DateOnSaleFrom, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public object DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_to")]
        [CommerceDescription(WCCaptions.DateOnSaleTo, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public object DateOnSaleTo { get; set; }

        [JsonProperty("date_on_sale_from_gmt")]
        [CommerceDescription(WCCaptions.DateOnSaleFromGmt, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public object DateOnSaleFromGmt { get; set; }

        [JsonProperty("date_on_sale_to_gmt")]
        [CommerceDescription(WCCaptions.DateOnSaleToGmt, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public object DateOnSaleToGmt { get; set; }

        [JsonProperty("manage_stock")]
        [CommerceDescription(WCCaptions.ManageStock, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        [ShouldNotDeserialize]
        public bool? ManageStock { get; set; }

        //public bool? manage_stock { get { return bool.TryParse(ManageStock, out bool? x) ? x : true; } }

        [JsonProperty("on_sale")]
        public bool? OnSale { get; set; }

        [JsonProperty("status")]
        [CommerceDescription(WCCaptions.Status, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Status { get; set; }

        [JsonProperty("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonProperty("virtual")]
        [CommerceDescription(WCCaptions.Virtual, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? Virtual { get; set; }

        [JsonProperty("downloadable")]
        [CommerceDescription(WCCaptions.Downloadable, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? Downloadable { get; set; }

        [JsonProperty("downloads")]
        [CommerceDescription(WCCaptions.Downloads, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<object> Downloads { get; set; }

        [JsonProperty("download_limit")]
        [CommerceDescription(WCCaptions.DownloadLimit, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? DownloadLimit { get; set; }

        [JsonProperty("download_expiry")]
        [CommerceDescription(WCCaptions.DownloadExpiry, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? DownloadExpiry { get; set; }

        [JsonProperty("tax_status")]
        [CommerceDescription(WCCaptions.TaxStatus, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string TaxStatus { get; set; }//taxable, shipping and none

        [JsonProperty("tax_class")]
        [CommerceDescription(WCCaptions.TaxClass, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string TaxClass { get; set; }

        [JsonProperty("stock_quantity")]
        public decimal? StockQuantity { get; set; }

        [JsonProperty("stock_status")]
        [CommerceDescription(WCCaptions.StockStatus, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string StockStatus { get; set; }//instock, outofstock, onbackorder. Default is instock

        [JsonProperty("backorders")]
        [CommerceDescription(WCCaptions.Backorders, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Backorders { get; set; }

        [JsonProperty("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool? Backordered { get; set; }

        [JsonProperty("low_stock_amount")]
        public object LowStockAmount { get; set; }

        [JsonProperty("weight")]
        [CommerceDescription(WCCaptions.Weight, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        [CommerceDescription(WCCaptions.Dimensions, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public DimentionData Dimensions { get; set; }

        [JsonProperty("shipping_class")]
        [CommerceDescription(WCCaptions.ShippingClass, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        [JsonProperty("image")]
        [CommerceDescription(WCCaptions.Image, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public object Image { get; set; }

        [JsonProperty("attributes")]
        [CommerceDescription(WCCaptions.Attribute, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<AttributeData> Attributes { get; set; }

        [JsonProperty("menu_order")]
        [CommerceDescription(WCCaptions.MenuOrder, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? MenuOrder { get; set; }

        [JsonProperty("meta_data")]
        public List<Common.Metadata> MetaData { get; set; }
        public Guid? LocalID { get; internal set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }
        public int? ProductId { get; internal set; }
        public object OptionValues { get; internal set; }
        public int? InventoryLevel { get; internal set; }
    }
}