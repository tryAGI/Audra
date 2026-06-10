
#nullable enable

namespace Audra
{
    /// <summary>
    /// Default Value: mp3
    /// </summary>
    public enum SpeechRequestFormat
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
    public static class SpeechRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestFormat value)
        {
            return value switch
            {
                SpeechRequestFormat.Mp3 => "mp3",
                SpeechRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => SpeechRequestFormat.Mp3,
                "wav" => SpeechRequestFormat.Wav,
                _ => null,
            };
        }
    }
}