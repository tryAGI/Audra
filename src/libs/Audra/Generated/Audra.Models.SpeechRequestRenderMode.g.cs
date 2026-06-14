
#nullable enable

namespace Audra
{
    /// <summary>
    /// `fast` (default) = Modal GPU. `standard` = Modal CPU.<br/>
    /// Aliases `gpu` / `cpu` accepted.
    /// </summary>
    public enum SpeechRequestRenderMode
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
    public static class SpeechRequestRenderModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestRenderMode value)
        {
            return value switch
            {
                SpeechRequestRenderMode.Cpu => "cpu",
                SpeechRequestRenderMode.Fast => "fast",
                SpeechRequestRenderMode.Gpu => "gpu",
                SpeechRequestRenderMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestRenderMode? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => SpeechRequestRenderMode.Cpu,
                "fast" => SpeechRequestRenderMode.Fast,
                "gpu" => SpeechRequestRenderMode.Gpu,
                "standard" => SpeechRequestRenderMode.Standard,
                _ => null,
            };
        }
    }
}