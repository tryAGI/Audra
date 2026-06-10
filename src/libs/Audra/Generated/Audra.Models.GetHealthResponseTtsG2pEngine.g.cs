
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetHealthResponseTtsG2pEngine
    {
        /// <summary>
        /// 
        /// </summary>
        AudraPhonetics,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetHealthResponseTtsG2pEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetHealthResponseTtsG2pEngine value)
        {
            return value switch
            {
                GetHealthResponseTtsG2pEngine.AudraPhonetics => "audra-phonetics",
                GetHealthResponseTtsG2pEngine.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetHealthResponseTtsG2pEngine? ToEnum(string value)
        {
            return value switch
            {
                "audra-phonetics" => GetHealthResponseTtsG2pEngine.AudraPhonetics,
                "standard" => GetHealthResponseTtsG2pEngine.Standard,
                _ => null,
            };
        }
    }
}