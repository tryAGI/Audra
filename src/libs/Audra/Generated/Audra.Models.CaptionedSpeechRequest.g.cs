
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CaptionedSpeechRequest
    {
        /// <summary>
        /// Default Value: audra-essential
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

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
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.CaptionedSpeechRequestFormatJsonConverter))]
        public global::Audra.CaptionedSpeechRequestFormat? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.CaptionedSpeechRequestDeliveryProfileJsonConverter))]
        public global::Audra.CaptionedSpeechRequestDeliveryProfile? DeliveryProfile { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix. Provide explicitly for designed voices or to force<br/>
        /// a specific G2P backend.<br/>
        /// Example: fr-fr
        /// </summary>
        /// <example>fr-fr</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.CaptionedSpeechRequestRenderModeJsonConverter))]
        public global::Audra.CaptionedSpeechRequestRenderMode? RenderMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionedSpeechRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="model">
        /// Default Value: audra-essential
        /// </param>
        /// <param name="voice">
        /// Default Value: june
        /// </param>
        /// <param name="speed">
        /// Default Value: 1.0
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="normalize">
        /// Default Value: true
        /// </param>
        /// <param name="language">
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix. Provide explicitly for designed voices or to force<br/>
        /// a specific G2P backend.<br/>
        /// Example: fr-fr
        /// </param>
        /// <param name="renderMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionedSpeechRequest(
            string text,
            string? model,
            string? voice,
            double? speed,
            global::Audra.CaptionedSpeechRequestFormat? format,
            global::Audra.CaptionedSpeechRequestDeliveryProfile? deliveryProfile,
            bool? normalize,
            string? language,
            global::Audra.CaptionedSpeechRequestRenderMode? renderMode)
        {
            this.Model = model;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
            this.Speed = speed;
            this.Format = format;
            this.DeliveryProfile = deliveryProfile;
            this.Normalize = normalize;
            this.Language = language;
            this.RenderMode = renderMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionedSpeechRequest" /> class.
        /// </summary>
        public CaptionedSpeechRequest()
        {
        }

    }
}