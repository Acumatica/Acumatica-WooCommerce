using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product")]
    [CommerceDescription(WCCaptions.Product)]
    public class ProductData : BCAPIEntity, IWooEntity
    {
        private string name;

        public ProductData()
        {
            Categories = new List<CategoryData>();
            Attributes = new List<AttributeData>();
        }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.ProductName, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get => name; set => name = value; }

        [JsonProperty("slug")]
        [CommerceDescription(WCCaptions.Slug, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Slug { get; set; }

        [JsonProperty("type")]
        [CommerceDescription(WCCaptions.ProductType, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Type { get; set; }

        [JsonProperty("status")]
        [CommerceDescription(WCCaptions.Status, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Status { get; set; }

        [JsonProperty("featured")]
        [CommerceDescription(WCCaptions.IsFeatured, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? Featured { get; set; }

        [JsonProperty("catalog_visibility")]
        [CommerceDescription(WCCaptions.Availability, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string CatalogVisibility { get; set; }

        [JsonProperty("description")]
        [CommerceDescription(WCCaptions.ProductDescription, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Description { get; set; }

        [JsonProperty("short_description")]
        [CommerceDescription(WCCaptions.ProductDescription, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string ShortDescription { get; set; }

        [JsonProperty("sku")]
        [CommerceDescription(WCCaptions.StockKeepingUnit, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string Sku { get; set; }

        [JsonProperty("regular_price")]
        [CommerceDescription(WCCaptions.RegularPrice, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        [CommerceDescription(WCCaptions.SalePrice, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string SalePrice { get; set; }

        [JsonProperty("date_on_sale_from")]
        [CommerceDescription(WCCaptions.DateOnSaleFrom, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public DateTime? DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_to")]
        [CommerceDescription(WCCaptions.DateOnSaleTo, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public DateTime? DateOnSaleTo { get; set; }

        [JsonProperty("downloadable")]
        [CommerceDescription(WCCaptions.Downloadable, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? Downloadable { get; set; }

        [JsonProperty("downloads")]
        [CommerceDescription(WCCaptions.Downloads, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<ProductDownloadData> Downloads { get; set; }

        [JsonProperty("download_limit")]
        [CommerceDescription(WCCaptions.DownloadLimit, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? DownloadLimit { get; set; }

        [JsonProperty("download_expiry")]
        [CommerceDescription(WCCaptions.DownloadExpiry, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? DownloadExpiry { get; set; }

        [JsonProperty("external_url")]
        [CommerceDescription(WCCaptions.ExternalUrl, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string ExternalUrl { get; set; }

        [JsonProperty("button_text")]
        [CommerceDescription(WCCaptions.ButtonText, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string ButtonText { get; set; }//Only for external products

        [JsonProperty("tax_status")]
        [CommerceDescription(WCCaptions.TaxStatus, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string TaxStatus { get; set; }//taxable, shipping and none

        [JsonProperty("tax_class")]
        [CommerceDescription(WCCaptions.TaxClass, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string TaxClass { get; set; }

        [JsonProperty("manage_stock")]
        [CommerceDescription(WCCaptions.ManageStock, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? ManageStock { get; set; } //Stock management at product level. Default is false

        [JsonProperty("stock_status")]
        [CommerceDescription(WCCaptions.StockStatus, FieldFilterStatus.Filterable, FieldMappingStatus.Export)]
        public string StockStatus { get; set; }//instock, outofstock, onbackorder. Default is instock

        [JsonProperty("sold_individually")]
        [CommerceDescription(WCCaptions.SoldIndividually, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? SoldIndividually { get; set; }

        [JsonProperty("weight")]
        [CommerceDescription(WCCaptions.Weight, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        [CommerceDescription(WCCaptions.Dimensions, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public DimentionData Dimensions { get; set; }

        [JsonProperty("shipping_class")]
        [CommerceDescription(WCCaptions.ShippingClass, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string ShippingClass { get; set; }

        [JsonProperty("reviews_allowed")]
        [CommerceDescription(WCCaptions.ReviewsAllowed, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? ReviewsAllowed { get; set; }

        [JsonProperty("parent_id")]
        [CommerceDescription(WCCaptions.ParentId, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? ParentId { get; set; }

        [JsonProperty("purchase_note")]
        [CommerceDescription(WCCaptions.PurchaseNote, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string PurchaseNote { get; set; }

        [JsonProperty("categories")]
        [CommerceDescription(WCCaptions.Categories, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<CategoryData> Categories { get; set; }

        [JsonProperty("tags")]
        [CommerceDescription(WCCaptions.Tags, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<TagData> Tags { get; set; }

        [JsonProperty("images")]
        [CommerceDescription(WCCaptions.Images, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<ProductImage> Images { get; set; }

        [JsonProperty("attributes")]
        [CommerceDescription(WCCaptions.Attribute, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<AttributeData> Attributes { get; set; }

        [JsonProperty("default_attributes")]
        [CommerceDescription(WCCaptions.DefaultAttributes, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<AttributeData> DefaultAttributes { get; set; }

        [JsonProperty("menu_order")]
        [CommerceDescription(WCCaptions.MenuOrder, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? MenuOrder { get; set; }

        [JsonProperty("virtual")]
        [CommerceDescription(WCCaptions.Virtual, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? Virtual { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        public decimal? PriceInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(Price, out val) ? val : 0;
            }
        }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModifiedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; } = DateTime.UtcNow;

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; } = DateTime.UtcNow;


        [JsonProperty("date_on_sale_from_gmt")]
        public DateTime? DateOnSaleFromGmt { get; set; }

        [JsonProperty("date_on_sale_to_gmt")]
        public DateTime? DateOnSaleToGmt { get; set; }

        [JsonProperty("on_sale")]
        public bool? OnSale { get; set; }

        [JsonProperty("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonProperty("total_sales")]
        public int? TotalSales { get; set; }

        [JsonProperty("stock_quantity")]
        public decimal? StockQuantity { get; set; }

        [JsonProperty("backorders")]
        public string Backorders { get; set; } //Options: no, notify and yes. Default is no.

        [JsonProperty("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool? Backordered { get; set; }

        [JsonProperty("shipping_required")]
        public bool? ShippingRequired { get; set; }

        [JsonProperty("shipping_taxable")]
        public bool? ShippingTaxable { get; set; }

        [JsonProperty("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        [JsonProperty("average_rating")]
        public string AverageRating { get; set; }

        [JsonProperty("rating_count")]
        public int? RatingCount { get; set; }

        [JsonProperty("upsell_ids")]
        public List<int> UpsellIds { get; set; }

        [JsonProperty("cross_sell_ids")]
        public List<int> CrossSellIds { get; set; }

        [JsonProperty("grouped_products")]
        public List<int> GroupedProducts { get; set; }

        [JsonProperty("price_html")]
        public string PriceHtml { get; set; }

        [JsonProperty("related_ids")]
        public List<int> RelatedIds { get; set; }

        [JsonProperty("meta_data")]
        public List<Meta.Metadata> MetaData { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
