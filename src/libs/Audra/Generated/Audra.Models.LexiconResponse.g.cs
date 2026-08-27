
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LexiconResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::Audra.LexiconEntry>? Entries { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_entries")]
        public int? MaxEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LexiconResponse" /> class.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="maxEntries">
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LexiconResponse(
            global::System.Collections.Generic.IList<global::Audra.LexiconEntry>? entries,
            int? maxEntries)
        {
            this.Entries = entries;
            this.MaxEntries = maxEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LexiconResponse" /> class.
        /// </summary>
        public LexiconResponse()
        {
        }

    }
}