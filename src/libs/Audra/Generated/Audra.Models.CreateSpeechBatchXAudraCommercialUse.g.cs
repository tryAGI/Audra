
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSpeechBatchXAudraCommercialUse
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
    public static class CreateSpeechBatchXAudraCommercialUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechBatchXAudraCommercialUse value)
        {
            return value switch
            {
                CreateSpeechBatchXAudraCommercialUse.x1 => "1",
                CreateSpeechBatchXAudraCommercialUse.True => "true",
                CreateSpeechBatchXAudraCommercialUse.Yes => "yes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechBatchXAudraCommercialUse? ToEnum(string value)
        {
            return value switch
            {
                "1" => CreateSpeechBatchXAudraCommercialUse.x1,
                "true" => CreateSpeechBatchXAudraCommercialUse.True,
                "yes" => CreateSpeechBatchXAudraCommercialUse.Yes,
                _ => null,
            };
        }
    }
}