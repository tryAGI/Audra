
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechRequest
    {
        /// <summary>
        /// Default Value: audra-essential
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Plain text, SSML subset, Audra pause tags (`[pause:1.5s]`),<br/>
        /// or inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Voice slug (june, clara, arthur, …) or weighted mix e.g. `june(2)+wren(1)`.<br/>
        /// Premium packs use product slugs (e.g. aurora-lead) when enabled.<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechRequestFormatJsonConverter))]
        public global::Audra.SpeechRequestFormat? Format { get; set; }

        /// <summary>
        /// Podcast pacing profile (slower speed + paragraph/sentence pauses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechRequestDeliveryProfileJsonConverter))]
        public global::Audra.SpeechRequestDeliveryProfile? DeliveryProfile { get; set; }

        /// <summary>
        /// When true (default), normalize URLs, emails, currency, and percent signs before synthesis.<br/>
        /// Set false to pass text through unchanged (except pronunciation lexicon).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// `fast` (default) = Modal GPU. `standard` = Modal CPU.<br/>
        /// Aliases `gpu` / `cpu` accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechRequestRenderModeJsonConverter))]
        public global::Audra.SpeechRequestRenderMode? RenderMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Plain text, SSML subset, Audra pause tags (`[pause:1.5s]`),<br/>
        /// or inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.
        /// </param>
        /// <param name="model">
        /// Default Value: audra-essential
        /// </param>
        /// <param name="voice">
        /// Voice slug (june, clara, arthur, …) or weighted mix e.g. `june(2)+wren(1)`.<br/>
        /// Premium packs use product slugs (e.g. aurora-lead) when enabled.<br/>
        /// Default Value: june
        /// </param>
        /// <param name="speed">
        /// Default Value: 1.0
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="deliveryProfile">
        /// Podcast pacing profile (slower speed + paragraph/sentence pauses)
        /// </param>
        /// <param name="normalize">
        /// When true (default), normalize URLs, emails, currency, and percent signs before synthesis.<br/>
        /// Set false to pass text through unchanged (except pronunciation lexicon).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="renderMode">
        /// `fast` (default) = Modal GPU. `standard` = Modal CPU.<br/>
        /// Aliases `gpu` / `cpu` accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequest(
            string text,
            string? model,
            string? voice,
            double? speed,
            global::Audra.SpeechRequestFormat? format,
            global::Audra.SpeechRequestDeliveryProfile? deliveryProfile,
            bool? normalize,
            global::Audra.SpeechRequestRenderMode? renderMode)
        {
            this.Model = model;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
            this.Speed = speed;
            this.Format = format;
            this.DeliveryProfile = deliveryProfile;
            this.Normalize = normalize;
            this.RenderMode = renderMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        public SpeechRequest()
        {
        }

    }
}