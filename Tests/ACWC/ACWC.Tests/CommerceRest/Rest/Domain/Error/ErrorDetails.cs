using System.Collections.Generic;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Error
{
    public class ErrorDetails
    {
        [JsonProperty("conflict_reason")]
        public string ConflictReason { get; set; }

        [JsonProperty("orphaned_products")]
        public List<string> OrphanedProducts { get; set; }
    }
}
