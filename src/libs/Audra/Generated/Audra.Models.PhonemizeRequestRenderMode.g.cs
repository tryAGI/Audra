
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhonemizeRequestRenderMode
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
    public static class PhonemizeRequestRenderModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhonemizeRequestRenderMode value)
        {
            return value switch
            {
                PhonemizeRequestRenderMode.Cpu => "cpu",
                PhonemizeRequestRenderMode.Fast => "fast",
                PhonemizeRequestRenderMode.Gpu => "gpu",
                PhonemizeRequestRenderMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhonemizeRequestRenderMode? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => PhonemizeRequestRenderMode.Cpu,
                "fast" => PhonemizeRequestRenderMode.Fast,
                "gpu" => PhonemizeRequestRenderMode.Gpu,
                "standard" => PhonemizeRequestRenderMode.Standard,
                _ => null,
            };
        }
    }
}