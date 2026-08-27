
#nullable enable

namespace Audra
{
    /// <summary>
    /// Per-segment delivery energy. Maps to a small speed multiplier on the segment<br/>
    /// (e.g. high ≈ +8% speed). Omit or use neutral for default pacing.<br/>
    /// Default Value: neutral
    /// </summary>
    public enum BatchSegmentEnergy
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchSegmentEnergyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchSegmentEnergy value)
        {
            return value switch
            {
                BatchSegmentEnergy.High => "high",
                BatchSegmentEnergy.Low => "low",
                BatchSegmentEnergy.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchSegmentEnergy? ToEnum(string value)
        {
            return value switch
            {
                "high" => BatchSegmentEnergy.High,
                "low" => BatchSegmentEnergy.Low,
                "neutral" => BatchSegmentEnergy.Neutral,
                _ => null,
            };
        }
    }
}