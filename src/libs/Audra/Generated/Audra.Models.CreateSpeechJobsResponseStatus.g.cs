
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpeechJobsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechJobsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechJobsResponseStatus value)
        {
            return value switch
            {
                CreateSpeechJobsResponseStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechJobsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => CreateSpeechJobsResponseStatus.Queued,
                _ => null,
            };
        }
    }
}