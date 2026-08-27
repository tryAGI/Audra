
#nullable enable

namespace Audra
{
    /// <summary>
    /// Default Value: mp3
    /// </summary>
    public enum SpeechJobRequestFormat
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
    public static class SpeechJobRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobRequestFormat value)
        {
            return value switch
            {
                SpeechJobRequestFormat.Mp3 => "mp3",
                SpeechJobRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => SpeechJobRequestFormat.Mp3,
                "wav" => SpeechJobRequestFormat.Wav,
                _ => null,
            };
        }
    }
}