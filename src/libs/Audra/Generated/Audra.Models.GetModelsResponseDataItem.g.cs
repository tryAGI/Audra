
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelsResponseDataItem
    {
        /// <summary>
        /// Example: audra-core
        /// </summary>
        /// <example>audra-core</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.IList<string>? Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: audra-core
        /// </param>
        /// <param name="tier">
        /// Example: standard
        /// </param>
        /// <param name="features"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponseDataItem(
            string? id,
            string? tier,
            global::System.Collections.Generic.IList<string>? features)
        {
            this.Id = id;
            this.Tier = tier;
            this.Features = features;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseDataItem" /> class.
        /// </summary>
        public GetModelsResponseDataItem()
        {
        }

    }
}