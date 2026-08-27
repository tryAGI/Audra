
#nullable enable

namespace Audra
{
    /// <summary>
    /// `standard` — default queue placement. `fast` — queue priority, 1.25× credits.<br/>
    /// `economy` (0.75× credits, deferred) exists but is **not valid here** — it is<br/>
    /// only accepted on `POST /v2/speech/jobs` (async). Sending `mode: "economy"`<br/>
    /// or `economy: true` on this synchronous endpoint returns 400.<br/>
    /// Default Value: standard
    /// </summary>
    public enum SpeechRequestMode
    {
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
    public static class SpeechRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestMode value)
        {
            return value switch
            {
                SpeechRequestMode.Fast => "fast",
                SpeechRequestMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => SpeechRequestMode.Fast,
                "standard" => SpeechRequestMode.Standard,
                _ => null,
            };
        }
    }
}