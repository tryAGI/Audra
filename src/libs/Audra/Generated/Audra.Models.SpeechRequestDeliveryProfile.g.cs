
#nullable enable

namespace Audra
{
    /// <summary>
    /// Podcast pacing profile (slower speed + paragraph/sentence pauses)
    /// </summary>
    public enum SpeechRequestDeliveryProfile
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        PodcastV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestDeliveryProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestDeliveryProfile value)
        {
            return value switch
            {
                SpeechRequestDeliveryProfile.Legacy => "legacy",
                SpeechRequestDeliveryProfile.PodcastV2 => "podcast_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestDeliveryProfile? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => SpeechRequestDeliveryProfile.Legacy,
                "podcast_v2" => SpeechRequestDeliveryProfile.PodcastV2,
                _ => null,
            };
        }
    }
}