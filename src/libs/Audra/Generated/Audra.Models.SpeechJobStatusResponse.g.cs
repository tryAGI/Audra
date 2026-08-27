
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechJobStatusResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobStatusResponseStatusJsonConverter))]
        public global::Audra.SpeechJobStatusResponseStatus? Status { get; set; }

        /// <summary>
        ///
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.SpeechJobStatusResponseModeJsonConverter))]
        public global::Audra.SpeechJobStatusResponseMode? Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechJobStatusResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status"></param>
        /// <param name="chars"></param>
        /// <param name="inputChars"></param>
        /// <param name="model"></param>
        /// <param name="mode"></param>
        /// <param name="voice"></param>
        /// <param name="format"></param>
        /// <param name="error"></param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="audioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechJobStatusResponse(
            string? jobId,
            global::Audra.SpeechJobStatusResponseStatus? status,
            int? chars,
            int? inputChars,
            string? model,
            global::Audra.SpeechJobStatusResponseMode? mode,
            string? voice,
            string? format,
            string? error,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? audioUrl)
        {
            this.JobId = jobId;
            this.Status = status;
            this.Chars = chars;
            this.InputChars = inputChars;
            this.Model = model;
            this.Mode = mode;
            this.Voice = voice;
            this.Format = format;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechJobStatusResponse" /> class.
        /// </summary>
        public SpeechJobStatusResponse()
        {
        }

    }
}