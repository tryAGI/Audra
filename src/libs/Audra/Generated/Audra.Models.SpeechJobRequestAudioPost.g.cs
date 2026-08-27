
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechJobRequestAudioPost
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Broadcast,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Podcast,
        /// <summary>
        ///
        /// </summary>
        Warm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechJobRequestAudioPostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobRequestAudioPost value)
        {
            return value switch
            {
                SpeechJobRequestAudioPost.Auto => "auto",
                SpeechJobRequestAudioPost.Broadcast => "broadcast",
                SpeechJobRequestAudioPost.Off => "off",
                SpeechJobRequestAudioPost.Podcast => "podcast",
                SpeechJobRequestAudioPost.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobRequestAudioPost? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SpeechJobRequestAudioPost.Auto,
                "broadcast" => SpeechJobRequestAudioPost.Broadcast,
                "off" => SpeechJobRequestAudioPost.Off,
                "podcast" => SpeechJobRequestAudioPost.Podcast,
                "warm" => SpeechJobRequestAudioPost.Warm,
                _ => null,
            };
        }
    }
}