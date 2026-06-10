
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetHealthResponseTts
    {
        /// <summary>
        /// Example: healthy
        /// </summary>
        /// <example>healthy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: audra-core
        /// </summary>
        /// <example>audra-core</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public int? Voices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("g2p")]
        public global::Audra.GetHealthResponseTtsG2p? G2p { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHealthResponseTts" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: healthy
        /// </param>
        /// <param name="engine">
        /// Example: audra-core
        /// </param>
        /// <param name="voices"></param>
        /// <param name="g2p"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetHealthResponseTts(
            string? status,
            string? engine,
            int? voices,
            global::Audra.GetHealthResponseTtsG2p? g2p)
        {
            this.Status = status;
            this.Engine = engine;
            this.Voices = voices;
            this.G2p = g2p;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHealthResponseTts" /> class.
        /// </summary>
        public GetHealthResponseTts()
        {
        }

    }
}