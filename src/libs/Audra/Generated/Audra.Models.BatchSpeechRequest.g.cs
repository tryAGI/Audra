
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchSpeechRequest
    {
        /// <summary>
        /// Default Value: audra-essential
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

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
        /// Crossfade duration between segments (ms). Pauses under 300ms use crossfade instead of inserted silence for smoother podcast beats.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossfade_ms")]
        public int? CrossfadeMs { get; set; }

        /// <summary>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.BatchSpeechRequestFormatJsonConverter))]
        public global::Audra.BatchSpeechRequestFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.BatchSpeechRequestDeliveryProfileJsonConverter))]
        public global::Audra.BatchSpeechRequestDeliveryProfile? DeliveryProfile { get; set; }

        /// <summary>
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix.<br/>
        /// Example: es
        /// </summary>
        /// <example>es</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audra.BatchSegment> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSpeechRequest" /> class.
        /// </summary>
        /// <param name="segments"></param>
        /// <param name="model">
        /// Default Value: audra-essential
        /// </param>
        /// <param name="voice">
        /// Default Value: june
        /// </param>
        /// <param name="speed">
        /// Default Value: 1.0
        /// </param>
        /// <param name="crossfadeMs">
        /// Crossfade duration between segments (ms). Pauses under 300ms use crossfade instead of inserted silence for smoother podcast beats.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="language">
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix.<br/>
        /// Example: es
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchSpeechRequest(
            global::System.Collections.Generic.IList<global::Audra.BatchSegment> segments,
            string? model,
            string? voice,
            double? speed,
            int? crossfadeMs,
            global::Audra.BatchSpeechRequestFormat? format,
            global::Audra.BatchSpeechRequestDeliveryProfile? deliveryProfile,
            string? language)
        {
            this.Model = model;
            this.Voice = voice;
            this.Speed = speed;
            this.CrossfadeMs = crossfadeMs;
            this.Format = format;
            this.DeliveryProfile = deliveryProfile;
            this.Language = language;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSpeechRequest" /> class.
        /// </summary>
        public BatchSpeechRequest()
        {
        }

    }
}