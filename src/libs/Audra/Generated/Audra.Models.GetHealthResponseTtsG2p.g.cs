
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetHealthResponseTtsG2p
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.GetHealthResponseTtsG2pEngineJsonConverter))]
        public global::Audra.GetHealthResponseTtsG2pEngine? Engine { get; set; }

        /// <summary>
        /// Example: v1
        /// </summary>
        /// <example>v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        public bool? Ready { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHealthResponseTtsG2p" /> class.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="version">
        /// Example: v1
        /// </param>
        /// <param name="ready"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetHealthResponseTtsG2p(
            global::Audra.GetHealthResponseTtsG2pEngine? engine,
            string? version,
            bool? ready)
        {
            this.Engine = engine;
            this.Version = version;
            this.Ready = ready;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHealthResponseTtsG2p" /> class.
        /// </summary>
        public GetHealthResponseTtsG2p()
        {
        }

    }
}