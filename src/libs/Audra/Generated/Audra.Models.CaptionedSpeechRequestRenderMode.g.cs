
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum CaptionedSpeechRequestRenderMode
    {
        /// <summary>
        ///
        /// </summary>
        Cpu,
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Gpu,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionedSpeechRequestRenderModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionedSpeechRequestRenderMode value)
        {
            return value switch
            {
                CaptionedSpeechRequestRenderMode.Cpu => "cpu",
                CaptionedSpeechRequestRenderMode.Fast => "fast",
                CaptionedSpeechRequestRenderMode.Gpu => "gpu",
                CaptionedSpeechRequestRenderMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionedSpeechRequestRenderMode? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => CaptionedSpeechRequestRenderMode.Cpu,
                "fast" => CaptionedSpeechRequestRenderMode.Fast,
                "gpu" => CaptionedSpeechRequestRenderMode.Gpu,
                "standard" => CaptionedSpeechRequestRenderMode.Standard,
                _ => null,
            };
        }
    }
}