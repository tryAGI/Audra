
#nullable enable

namespace Audra
{
    /// <summary>
    /// Default Value: mp3
    /// </summary>
    public enum CaptionedSpeechRequestFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionedSpeechRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionedSpeechRequestFormat value)
        {
            return value switch
            {
                CaptionedSpeechRequestFormat.Mp3 => "mp3",
                CaptionedSpeechRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionedSpeechRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CaptionedSpeechRequestFormat.Mp3,
                "wav" => CaptionedSpeechRequestFormat.Wav,
                _ => null,
            };
        }
    }
}