
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceProbeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        public bool? Ok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qa_passed")]
        public bool? QaPassed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_backend")]
        public string? RenderBackend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProbeResponse" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="ok"></param>
        /// <param name="durationMs"></param>
        /// <param name="qaPassed"></param>
        /// <param name="renderBackend"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceProbeResponse(
            string? slug,
            bool? ok,
            int? durationMs,
            bool? qaPassed,
            string? renderBackend,
            string? code,
            string? message)
        {
            this.Slug = slug;
            this.Ok = ok;
            this.DurationMs = durationMs;
            this.QaPassed = qaPassed;
            this.RenderBackend = renderBackend;
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProbeResponse" /> class.
        /// </summary>
        public VoiceProbeResponse()
        {
        }

    }
}