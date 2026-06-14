
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordTimestamp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamp" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="start">
        /// Start time in seconds
        /// </param>
        /// <param name="end">
        /// End time in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordTimestamp(
            string? word,
            double? start,
            double? end)
        {
            this.Word = word;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamp" /> class.
        /// </summary>
        public WordTimestamp()
        {
        }

    }
}