
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionsPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Audra.WordTimestamp>? Words { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_profile")]
        public string? DeliveryProfile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("g2p_backend")]
        public string? G2pBackend { get; set; }

        /// <summary>
        /// Example: duration-weighted
        /// </summary>
        /// <example>duration-weighted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public string? Alignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment_note")]
        public string? AlignmentNote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionsPayload" /> class.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="durationSeconds"></param>
        /// <param name="voice"></param>
        /// <param name="deliveryProfile"></param>
        /// <param name="g2pBackend"></param>
        /// <param name="alignment">
        /// Example: duration-weighted
        /// </param>
        /// <param name="alignmentNote"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionsPayload(
            global::System.Collections.Generic.IList<global::Audra.WordTimestamp>? words,
            double? durationSeconds,
            string? voice,
            string? deliveryProfile,
            string? g2pBackend,
            string? alignment,
            string? alignmentNote)
        {
            this.Words = words;
            this.DurationSeconds = durationSeconds;
            this.Voice = voice;
            this.DeliveryProfile = deliveryProfile;
            this.G2pBackend = g2pBackend;
            this.Alignment = alignment;
            this.AlignmentNote = alignmentNote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionsPayload" /> class.
        /// </summary>
        public CaptionsPayload()
        {
        }

    }
}