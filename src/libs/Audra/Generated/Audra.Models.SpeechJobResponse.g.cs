
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Billable characters after model and delivery-mode multipliers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chars")]
        public int? Chars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_chars")]
        public int? InputChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobResponseModeJsonConverter))]
        public global::Audra.SpeechJobResponseMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_multiplier")]
        public double? BillingMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_url")]
        public string? StatusUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Human-readable timing guidance. Economy jobs get a sweep-interval-aware<br/>
        /// message instead of the standard/fast "typical N minutes" estimate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status">
        /// Example: queued
        /// </param>
        /// <param name="chars">
        /// Billable characters after model and delivery-mode multipliers.
        /// </param>
        /// <param name="inputChars"></param>
        /// <param name="model"></param>
        /// <param name="mode"></param>
        /// <param name="billingMultiplier"></param>
        /// <param name="statusUrl"></param>
        /// <param name="audioUrl"></param>
        /// <param name="message">
        /// Human-readable timing guidance. Economy jobs get a sweep-interval-aware<br/>
        /// message instead of the standard/fast "typical N minutes" estimate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechJobResponse(
            string? jobId,
            string? status,
            int? chars,
            int? inputChars,
            string? model,
            global::Audra.SpeechJobResponseMode? mode,
            double? billingMultiplier,
            string? statusUrl,
            string? audioUrl,
            string? message)
        {
            this.JobId = jobId;
            this.Status = status;
            this.Chars = chars;
            this.InputChars = inputChars;
            this.Model = model;
            this.Mode = mode;
            this.BillingMultiplier = billingMultiplier;
            this.StatusUrl = statusUrl;
            this.AudioUrl = audioUrl;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechJobResponse" /> class.
        /// </summary>
        public SpeechJobResponse()
        {
        }

    }
}