
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechJobsRequest2
    {
        /// <summary>
        /// Optional HTTPS callback on completion or failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechJobsRequest2" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Optional HTTPS callback on completion or failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechJobsRequest2(
            string? webhookUrl)
        {
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechJobsRequest2" /> class.
        /// </summary>
        public CreateSpeechJobsRequest2()
        {
        }

    }
}