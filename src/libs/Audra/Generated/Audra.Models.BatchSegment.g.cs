
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
        /// Per-segment delivery energy. Maps to a small speed multiplier on the segment<br/>
        /// (e.g. high ≈ +8% speed). Omit or use neutral for default pacing.<br/>
        /// Default Value: neutral
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("energy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.BatchSegmentEnergyJsonConverter))]
        public global::Audra.BatchSegmentEnergy? Energy { get; set; }

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
        /// <param name="energy">
        /// Per-segment delivery energy. Maps to a small speed multiplier on the segment<br/>
        /// (e.g. high ≈ +8% speed). Omit or use neutral for default pacing.<br/>
        /// Default Value: neutral
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchSegment(
            string text,
            double? speed,
            int? pauseAfterMs,
            global::Audra.BatchSegmentEnergy? energy)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Speed = speed;
            this.PauseAfterMs = pauseAfterMs;
            this.Energy = energy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSegment" /> class.
        /// </summary>
        public BatchSegment()
        {
        }

    }
}