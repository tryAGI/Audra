
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechJobResponseMode
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
    public static class SpeechJobResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobResponseMode value)
        {
            return value switch
            {
                SpeechJobResponseMode.Economy => "economy",
                SpeechJobResponseMode.Fast => "fast",
                SpeechJobResponseMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "economy" => SpeechJobResponseMode.Economy,
                "fast" => SpeechJobResponseMode.Fast,
                "standard" => SpeechJobResponseMode.Standard,
                _ => null,
            };
        }
    }
}