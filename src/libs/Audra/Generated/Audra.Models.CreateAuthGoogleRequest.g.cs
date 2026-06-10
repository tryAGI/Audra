
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAuthGoogleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Credential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthGoogleRequest" /> class.
        /// </summary>
        /// <param name="credential"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAuthGoogleRequest(
            string credential)
        {
            this.Credential = credential ?? throw new global::System.ArgumentNullException(nameof(credential));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthGoogleRequest" /> class.
        /// </summary>
        public CreateAuthGoogleRequest()
        {
        }

    }
}