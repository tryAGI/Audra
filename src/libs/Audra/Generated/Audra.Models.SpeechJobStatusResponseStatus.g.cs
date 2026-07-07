
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechJobStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechJobStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechJobStatusResponseStatus value)
        {
            return value switch
            {
                SpeechJobStatusResponseStatus.Completed => "completed",
                SpeechJobStatusResponseStatus.Failed => "failed",
                SpeechJobStatusResponseStatus.Processing => "processing",
                SpeechJobStatusResponseStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechJobStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SpeechJobStatusResponseStatus.Completed,
                "failed" => SpeechJobStatusResponseStatus.Failed,
                "processing" => SpeechJobStatusResponseStatus.Processing,
                "queued" => SpeechJobStatusResponseStatus.Queued,
                _ => null,
            };
        }
    }
}