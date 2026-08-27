
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignupResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_chars")]
        public int? CreditsChars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupResponse" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="creditsChars"></param>
        /// <param name="emailVerified"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignupResponse(
            string? apiKey,
            int? creditsChars,
            bool? emailVerified,
            string? message)
        {
            this.ApiKey = apiKey;
            this.CreditsChars = creditsChars;
            this.EmailVerified = emailVerified;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupResponse" /> class.
        /// </summary>
        public SignupResponse()
        {
        }

    }
}