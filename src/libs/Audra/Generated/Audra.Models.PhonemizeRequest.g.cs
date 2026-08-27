
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhonemizeRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Default Value: june
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.PhonemizeRequestRenderModeJsonConverter))]
        public global::Audra.PhonemizeRequestRenderMode? RenderMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemizeRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="voice">
        /// Default Value: june
        /// </param>
        /// <param name="renderMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhonemizeRequest(
            string text,
            string? voice,
            global::Audra.PhonemizeRequestRenderMode? renderMode)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
            this.RenderMode = renderMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemizeRequest" /> class.
        /// </summary>
        public PhonemizeRequest()
        {
        }

    }
}