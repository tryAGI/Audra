
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechJobRequestScriptEnhance
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        Podcast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechJobRequestScriptEnhanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobRequestScriptEnhance value)
        {
            return value switch
            {
                SpeechJobRequestScriptEnhance.Auto => "auto",
                SpeechJobRequestScriptEnhance.Off => "off",
                SpeechJobRequestScriptEnhance.Podcast => "podcast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobRequestScriptEnhance? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SpeechJobRequestScriptEnhance.Auto,
                "off" => SpeechJobRequestScriptEnhance.Off,
                "podcast" => SpeechJobRequestScriptEnhance.Podcast,
                _ => null,
            };
        }
    }
}