
#nullable enable

namespace Audra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBillingCheckoutRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pack")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audra.JsonConverters.CreateBillingCheckoutRequestPackJsonConverter))]
        public global::Audra.CreateBillingCheckoutRequestPack? Pack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBillingCheckoutRequest" /> class.
        /// </summary>
        /// <param name="pack"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBillingCheckoutRequest(
            global::Audra.CreateBillingCheckoutRequestPack? pack)
        {
            this.Pack = pack;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBillingCheckoutRequest" /> class.
        /// </summary>
        public CreateBillingCheckoutRequest()
        {
        }

    }
}