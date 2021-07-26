using BCApiClient.Rest.Domain.Entities.Common;
using BigCommerce.Process.REST.Domain.Enumerations;
using Newtonsoft.Json;

namespace BigCommerce.Process.REST.Domain.Options
{
    public class Option
    {
        /// <summary>
        /// The unique ID of the Option.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// Unique reference name for the option.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Unique reference name for the option.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("display_name")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The type of option.
        ///
        ///C - Checkbox
        ///D - Date
        ///F - File
        ///N - Numbers Only Text
        ///T - Text
        ///MT - Multi-line Text
        ///P - Product list
        ///PI - Product list with images
        ///RB - Radio List
        ///RT - Rectangle List
        ///S - Select box
        ///CS - Swatch
        /// 
        /// enum
        /// </summary>
        [JsonProperty("type")]
        public virtual OptionType OptionType { get; set; }

        /// <summary>
        /// The values (if applicable) for the option. See the Option Values resource for details
        /// 
        /// resource
        /// </summary>
        [JsonProperty("values")]
        public virtual Resource ResourceOptionValues { get; set; }
    }
}