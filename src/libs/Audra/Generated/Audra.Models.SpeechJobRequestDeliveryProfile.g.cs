
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
    public static class SpeechJobRequestDeliveryProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobRequestDeliveryProfile value)
        {
            return value switch
            {
                SpeechJobRequestDeliveryProfile.Auto => "auto",
                SpeechJobRequestDeliveryProfile.Off => "off",
                SpeechJobRequestDeliveryProfile.Podcast => "podcast",
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
                "auto" => SpeechJobRequestDeliveryProfile.Auto,
                "off" => SpeechJobRequestDeliveryProfile.Off,
                "podcast" => SpeechJobRequestDeliveryProfile.Podcast,
                _ => null,
            };
        }
    }
}