
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSpeechCaptionedXAudraCommercialUse
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
    public static class CreateSpeechCaptionedXAudraCommercialUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechCaptionedXAudraCommercialUse value)
        {
            return value switch
            {
                CreateSpeechCaptionedXAudraCommercialUse.x1 => "1",
                CreateSpeechCaptionedXAudraCommercialUse.True => "true",
                CreateSpeechCaptionedXAudraCommercialUse.Yes => "yes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechCaptionedXAudraCommercialUse? ToEnum(string value)
        {
            return value switch
            {
                "1" => CreateSpeechCaptionedXAudraCommercialUse.x1,
                "true" => CreateSpeechCaptionedXAudraCommercialUse.True,
                "yes" => CreateSpeechCaptionedXAudraCommercialUse.Yes,
                _ => null,
            };
        }
    }
}