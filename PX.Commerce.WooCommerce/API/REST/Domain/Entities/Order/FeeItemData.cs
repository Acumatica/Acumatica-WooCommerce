using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Sales Order->FeeLines")]
    public class FeeItemData
    {
        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Name { get; set; }

        [JsonProperty("tax_class")]
        [CommerceDescription(WCCaptions.TaxClass, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string TaxClass { get; set; }

        [JsonProperty("tax_status")]
        [CommerceDescription(WCCaptions.TaxStatus, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string TaxStatus { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("total")]
        [CommerceDescription(WCCaptions.Total, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Total { get; set; }

        [JsonProperty("total_tax")]
        [CommerceDescription(WCCaptions.TotalTax, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string TotalTax { get; set; }

        [JsonProperty("taxes")]
        [CommerceDescription(WCCaptions.Taxes, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public List<object> Taxes { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }
    }
}
