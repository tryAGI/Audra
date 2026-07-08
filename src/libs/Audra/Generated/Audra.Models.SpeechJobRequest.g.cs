
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechJobRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobRequestFormatJsonConverter))]
        public global::Audra.SpeechJobRequestFormat? Format { get; set; }

        /// <summary>
        /// Optional callback POSTed with `{ job_id, status, chars }` on completion or failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// `standard` — default queue placement, 1.0× credits.<br/>
        /// `fast` — queue priority, 1.25× credits.<br/>
        /// `economy` — deferred/best-effort, 0.75× credits (25% discount). Runs on the<br/>
        /// next scheduled sweep (default every 12h) or sooner if a worker for the<br/>
        /// requested model is already warm from other traffic. Async jobs only —<br/>
        /// rejected with 400 on synchronous endpoints (`POST /v2/speech` and similar).<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobRequestModeJsonConverter))]
        public global::Audra.SpeechJobRequestMode? Mode { get; set; }

        /// <summary>
        /// Alias for mode: "fast".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fast_mode")]
        public bool? FastMode { get; set; }

        /// <summary>
        /// @deprecated use mode: "fast".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Priority { get; set; }

        /// <summary>
        /// Alias for mode: "economy".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("economy")]
        public bool? Economy { get; set; }

        /// <summary>
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix. Provide this field explicitly for designed voices<br/>
        /// or to force a specific G2P backend.<br/>
        /// Example: fr-fr
        /// </summary>
        /// <example>fr-fr</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobRequestDeliveryProfileJsonConverter))]
        public global::Audra.SpeechJobRequestDeliveryProfile? DeliveryProfile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_post")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobRequestAudioPostJsonConverter))]
        public global::Audra.SpeechJobRequestAudioPost? AudioPost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechJobRequest" /> class.
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
        /// <param name="webhookUrl">
        /// Optional callback POSTed with `{ job_id, status, chars }` on completion or failure.
        /// </param>
        /// <param name="mode">
        /// `standard` — default queue placement, 1.0× credits.<br/>
        /// `fast` — queue priority, 1.25× credits.<br/>
        /// `economy` — deferred/best-effort, 0.75× credits (25% discount). Runs on the<br/>
        /// next scheduled sweep (default every 12h) or sooner if a worker for the<br/>
        /// requested model is already warm from other traffic. Async jobs only —<br/>
        /// rejected with 400 on synchronous endpoints (`POST /v2/speech` and similar).<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="fastMode">
        /// Alias for mode: "fast".
        /// </param>
        /// <param name="economy">
        /// Alias for mode: "economy".
        /// </param>
        /// <param name="language">
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix. Provide this field explicitly for designed voices<br/>
        /// or to force a specific G2P backend.<br/>
        /// Example: fr-fr
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="audioPost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechJobRequest(
            string text,
            string? model,
            string? voice,
            double? speed,
            global::Audra.SpeechJobRequestFormat? format,
            string? webhookUrl,
            global::Audra.SpeechJobRequestMode? mode,
            bool? fastMode,
            bool? economy,
            string? language,
            global::Audra.SpeechJobRequestDeliveryProfile? deliveryProfile,
            global::Audra.SpeechJobRequestAudioPost? audioPost)
        {
            this.Model = model;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
            this.Speed = speed;
            this.Format = format;
            this.WebhookUrl = webhookUrl;
            this.Mode = mode;
            this.FastMode = fastMode;
            this.Economy = economy;
            this.Language = language;
            this.DeliveryProfile = deliveryProfile;
            this.AudioPost = audioPost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechJobRequest" /> class.
        /// </summary>
        public SpeechJobRequest()
        {
        }

    }
}