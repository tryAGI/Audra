
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionedSpeechRequestDeliveryProfile
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
    public static class CaptionedSpeechRequestDeliveryProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionedSpeechRequestDeliveryProfile value)
        {
            return value switch
            {
                CaptionedSpeechRequestDeliveryProfile.Legacy => "legacy",
                CaptionedSpeechRequestDeliveryProfile.PodcastV2 => "podcast_v2",
                CaptionedSpeechRequestDeliveryProfile.PodcastV3 => "podcast_v3",
                CaptionedSpeechRequestDeliveryProfile.PodcastV4 => "podcast_v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionedSpeechRequestDeliveryProfile? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => CaptionedSpeechRequestDeliveryProfile.Legacy,
                "podcast_v2" => CaptionedSpeechRequestDeliveryProfile.PodcastV2,
                "podcast_v3" => CaptionedSpeechRequestDeliveryProfile.PodcastV3,
                "podcast_v4" => CaptionedSpeechRequestDeliveryProfile.PodcastV4,
                _ => null,
            };
        }
    }
}