
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechJobStatusResponseMode
    {
        /// <summary>
        ///
        /// </summary>
        Economy,
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechJobStatusResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobStatusResponseMode value)
        {
            return value switch
            {
                SpeechJobStatusResponseMode.Economy => "economy",
                SpeechJobStatusResponseMode.Fast => "fast",
                SpeechJobStatusResponseMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobStatusResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "economy" => SpeechJobStatusResponseMode.Economy,
                "fast" => SpeechJobStatusResponseMode.Fast,
                "standard" => SpeechJobStatusResponseMode.Standard,
                _ => null,
            };
        }
    }
}