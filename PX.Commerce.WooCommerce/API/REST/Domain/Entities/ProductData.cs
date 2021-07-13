using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities
{
    public class ProductData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.ProductName, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get; set; }

        [JsonProperty("type")]
        [CommerceDescription(WCCaptions.ProductType, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Type { get; set; }

        [JsonProperty("sku")]
        [CommerceDescription(WCCaptions.StockKeepingUnit, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Sku { get; set; }

        [JsonProperty("description")]
        [CommerceDescription(WCCaptions.ProductDescription, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Description { get; set; }

        [JsonProperty("weight")]
        [CommerceDescription(WCCaptions.Weight, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        public DimentionData Dimensions { get; set; }

        [JsonProperty("price")]
        [CommerceDescription(WCCaptions.Price, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Price { get; set; }

        public decimal PriceInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(Price, out val) ? val : 0;
            }
        }

        [JsonProperty("regular_price")]
        [CommerceDescription(WCCaptions.RegularPrice, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        [CommerceDescription(WCCaptions.SalePrice, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string SalePrice { get; set; }

        [JsonProperty("tax_class")]
        [CommerceDescription(WCCaptions.TaxClassId, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string TaxClass { get; set; }

        [JsonProperty("slug")]
        [CommerceDescription(WCCaptions.Slug, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Slug { get; set; }

        [JsonProperty("permalink")]
        [CommerceDescription(WCCaptions.Permalink, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Permalink { get; set; }

        [JsonProperty("date_created")]
        [CommerceDescription(WCCaptions.DateCreatedUT, FieldFilterStatus.Skipped, FieldMappingStatus.Skipped)]
        public DateTime DateCreatedUT { get; set; }

        [JsonProperty("date_modified")]
        [CommerceDescription(WCCaptions.DateModifiedUT, FieldFilterStatus.Skipped, FieldMappingStatus.Skipped)]
        public DateTime DateModifiedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime DateCreatedGmt { get; set; } = DateTime.UtcNow;

        [JsonProperty("date_modified_gmt")]
        public DateTime DateModifiedGmt { get; set; } = DateTime.UtcNow;

        [JsonProperty("status")]
        [CommerceDescription(WCCaptions.Status, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Status { get; set; }

        [JsonProperty("featured")]
        [CommerceDescription(WCCaptions.IsFeatured, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool Featured { get; set; }

        [JsonProperty("catalog_visibility")]
        [CommerceDescription(WCCaptions.Availability, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string CatalogVisibility { get; set; }

        [JsonProperty("short_description")]
        [CommerceDescription(WCCaptions.ProductDescription, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string ShortDescription { get; set; }

        [JsonProperty("date_on_sale_from")]
        public object DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_from_gmt")]
        public object DateOnSaleFromGmt { get; set; }

        [JsonProperty("date_on_sale_to")]
        public object DateOnSaleTo { get; set; }

        [JsonProperty("date_on_sale_to_gmt")]
        public object DateOnSaleToGmt { get; set; }

        [JsonProperty("on_sale")]
        [CommerceDescription(WCCaptions.OnSale, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool OnSale { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }

        [JsonProperty("total_sales")]
        public int TotalSales { get; set; }

        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("downloads")]
        public List<object> Downloads { get; set; }

        [JsonProperty("download_limit")]
        public int DownloadLimit { get; set; }

        [JsonProperty("download_expiry")]
        public int DownloadExpiry { get; set; }

        [JsonProperty("external_url")]
        public string ExternalUrl { get; set; }
        //TODO: None Stock items

        [JsonProperty("button_text")]
        public string ButtonText { get; set; }//Only for external products

        [JsonProperty("tax_status")]
        public string TaxStatus { get; set; }//taxable, shipping and none

        [JsonProperty("manage_stock")]
        public bool ManageStock { get; set; } //Stock management at product level. Default is false

        [JsonProperty("stock_quantity")]
        public object StockQuantity { get; set; }

        [JsonProperty("backorders")]
        public string Backorders { get; set; } //Options: no, notify and yes. Default is no.

        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool Backordered { get; set; }

        [JsonProperty("sold_individually")]
        public bool SoldIndividually { get; set; }

        [JsonProperty("shipping_required")]
        public bool ShippingRequired { get; set; }

        [JsonProperty("shipping_taxable")]
        public bool ShippingTaxable { get; set; }

        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public int ShippingClassId { get; set; }

        [JsonProperty("reviews_allowed")]
        public bool ReviewsAllowed { get; set; }

        [JsonProperty("average_rating")]
        public string AverageRating { get; set; }

        [JsonProperty("rating_count")]
        public int RatingCount { get; set; }

        [JsonProperty("upsell_ids")]
        public List<int> UpsellIds { get; set; }

        [JsonProperty("cross_sell_ids")]
        public List<int> CrossSellIds { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("purchase_note")]
        public string PurchaseNote { get; set; }

        [JsonProperty("categories")]
        public List<CategoryData> Categories { get; set; }

        [JsonProperty("tags")]
        public List<TagData> Tags { get; set; }

        [JsonProperty("attributes")]
        [CommerceDescription(WCCaptions.Attribute)]
        public List<AttributeData> Attributes { get; set; }

        [JsonProperty("grouped_products")]
        public List<int> GroupedProducts { get; set; }

        [JsonProperty("menu_order")]
        public int MenuOrder { get; set; }

        [JsonProperty("price_html")]
        public string PriceHtml { get; set; }

        [JsonProperty("related_ids")]
        public List<int> RelatedIds { get; set; }

        [JsonProperty("meta_data")]
        public List<Meta.Metadata> MetaData { get; set; }

        [JsonProperty("stock_status")]
        public string StockStatus { get; set; }//instock, outofstock, onbackorder. Default is instock
        public DateTime? DateModified { get; set; }
    }
}
