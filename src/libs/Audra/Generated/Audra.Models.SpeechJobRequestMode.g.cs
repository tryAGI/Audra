
#nullable enable

namespace Audra
{
    /// <summary>
    /// `standard` — default queue placement, 1.0× credits.<br/>
    /// `fast` — queue priority, 1.25× credits.<br/>
    /// `economy` — deferred/best-effort, 0.75× credits (25% discount). Runs on the<br/>
    /// next scheduled sweep (default every 12h) or sooner if a worker for the<br/>
    /// requested model is already warm from other traffic. Async jobs only —<br/>
    /// rejected with 400 on synchronous endpoints (`POST /v2/speech` and similar).<br/>
    /// Default Value: standard
    /// </summary>
    public enum SpeechJobRequestMode
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
    public static class SpeechJobRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobRequestMode value)
        {
            return value switch
            {
                SpeechJobRequestMode.Economy => "economy",
                SpeechJobRequestMode.Fast => "fast",
                SpeechJobRequestMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "economy" => SpeechJobRequestMode.Economy,
                "fast" => SpeechJobRequestMode.Fast,
                "standard" => SpeechJobRequestMode.Standard,
                _ => null,
            };
        }
    }
}