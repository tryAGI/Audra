
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_after_ms")]
        public int? PauseAfterMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSegment" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        /// <param name="pauseAfterMs">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchSegment(
            string text,
            double? speed,
            int? pauseAfterMs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Speed = speed;
            this.PauseAfterMs = pauseAfterMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSegment" /> class.
        /// </summary>
        public BatchSegment()
        {
        }

    }
}