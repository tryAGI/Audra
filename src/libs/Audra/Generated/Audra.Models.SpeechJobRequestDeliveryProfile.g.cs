
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechJobRequestDeliveryProfile
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        PodcastV2,
        /// <summary>
        /// 
        /// </summary>
        PodcastV3,
        /// <summary>
        /// 
        /// </summary>
        PodcastV4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechJobRequestDeliveryProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobRequestDeliveryProfile value)
        {
            return value switch
            {
                SpeechJobRequestDeliveryProfile.Legacy => "legacy",
                SpeechJobRequestDeliveryProfile.PodcastV2 => "podcast_v2",
                SpeechJobRequestDeliveryProfile.PodcastV3 => "podcast_v3",
                SpeechJobRequestDeliveryProfile.PodcastV4 => "podcast_v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobRequestDeliveryProfile? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => SpeechJobRequestDeliveryProfile.Legacy,
                "podcast_v2" => SpeechJobRequestDeliveryProfile.PodcastV2,
                "podcast_v3" => SpeechJobRequestDeliveryProfile.PodcastV3,
                "podcast_v4" => SpeechJobRequestDeliveryProfile.PodcastV4,
                _ => null,
            };
        }
    }
}