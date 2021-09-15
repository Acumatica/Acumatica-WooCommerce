using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.Common
{
    public class BatchData<T> :IWooEntity where T : IWooEntity
    {
        [JsonProperty("create")]
        public List<T> Create { get; set; }

        [JsonProperty("update")]
        public List<T> Update { get; set; }

        [JsonProperty("delete")]
        [ShouldNotDeserialize]
        public List<int> Delete { get; set; }
        public DateTime? DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
