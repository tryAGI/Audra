
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
        /// Custom prepaid amount in USD ($5–$500). Mutually exclusive with pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_usd")]
        public double? AmountUsd { get; set; }

        /// <summary>
        /// WELCOME20 — 50% off your first pack on this account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promo_code")]
        public string? PromoCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBillingCheckoutRequest" /> class.
        /// </summary>
        /// <param name="pack"></param>
        /// <param name="amountUsd">
        /// Custom prepaid amount in USD ($5–$500). Mutually exclusive with pack.
        /// </param>
        /// <param name="promoCode">
        /// WELCOME20 — 50% off your first pack on this account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBillingCheckoutRequest(
            global::Audra.CreateBillingCheckoutRequestPack? pack,
            double? amountUsd,
            string? promoCode)
        {
            this.Pack = pack;
            this.AmountUsd = amountUsd;
            this.PromoCode = promoCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBillingCheckoutRequest" /> class.
        /// </summary>
        public CreateBillingCheckoutRequest()
        {
        }

    }
}