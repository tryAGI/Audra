
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSpeechXAudraCommercialUse
    {
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        True,
        /// <summary>
        ///
        /// </summary>
        Yes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechXAudraCommercialUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechXAudraCommercialUse value)
        {
            return value switch
            {
                CreateSpeechXAudraCommercialUse.x1 => "1",
                CreateSpeechXAudraCommercialUse.True => "true",
                CreateSpeechXAudraCommercialUse.Yes => "yes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechXAudraCommercialUse? ToEnum(string value)
        {
            return value switch
            {
                "1" => CreateSpeechXAudraCommercialUse.x1,
                "true" => CreateSpeechXAudraCommercialUse.True,
                "yes" => CreateSpeechXAudraCommercialUse.Yes,
                _ => null,
            };
        }
    }
}