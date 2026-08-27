
#nullable enable

namespace Audra
{
    /// <summary>
    /// Default Value: mp3
    /// </summary>
    public enum BatchSpeechRequestFormat
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
    public static class BatchSpeechRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchSpeechRequestFormat value)
        {
            return value switch
            {
                BatchSpeechRequestFormat.Mp3 => "mp3",
                BatchSpeechRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchSpeechRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => BatchSpeechRequestFormat.Mp3,
                "wav" => BatchSpeechRequestFormat.Wav,
                _ => null,
            };
        }
    }
}