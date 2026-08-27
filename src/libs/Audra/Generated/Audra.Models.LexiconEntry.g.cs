
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LexiconEntry
    {
        /// <summary>
        /// Word or phrase to match (case-insensitive word boundary)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Term { get; set; }

        /// <summary>
        /// Speakable replacement text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spoken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Spoken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LexiconEntry" /> class.
        /// </summary>
        /// <param name="term">
        /// Word or phrase to match (case-insensitive word boundary)
        /// </param>
        /// <param name="spoken">
        /// Speakable replacement text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LexiconEntry(
            string term,
            string spoken)
        {
            this.Term = term ?? throw new global::System.ArgumentNullException(nameof(term));
            this.Spoken = spoken ?? throw new global::System.ArgumentNullException(nameof(spoken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LexiconEntry" /> class.
        /// </summary>
        public LexiconEntry()
        {
        }

    }
}