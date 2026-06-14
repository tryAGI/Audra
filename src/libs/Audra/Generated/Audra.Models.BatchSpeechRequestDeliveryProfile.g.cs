
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchSpeechRequestDeliveryProfile
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
    public static class BatchSpeechRequestDeliveryProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchSpeechRequestDeliveryProfile value)
        {
            return value switch
            {
                BatchSpeechRequestDeliveryProfile.Legacy => "legacy",
                BatchSpeechRequestDeliveryProfile.PodcastV2 => "podcast_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchSpeechRequestDeliveryProfile? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => BatchSpeechRequestDeliveryProfile.Legacy,
                "podcast_v2" => BatchSpeechRequestDeliveryProfile.PodcastV2,
                _ => null,
            };
        }
    }
}