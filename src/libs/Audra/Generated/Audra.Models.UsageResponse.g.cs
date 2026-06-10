
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_chars")]
        public int? CreditsChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetime_chars")]
        public int? LifetimeChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_chars")]
        public int? MonthlyChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_1k_chars")]
        public double? PricePer1kChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_1m_chars")]
        public double? PricePer1mChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commercial")]
        public bool? Commercial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upgrade_url")]
        public string? UpgradeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_mode")]
        public string? StripeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium_voicepacks_enabled")]
        public bool? PremiumVoicepacksEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        /// <param name="creditsChars"></param>
        /// <param name="lifetimeChars"></param>
        /// <param name="monthlyChars"></param>
        /// <param name="pricePer1kChars"></param>
        /// <param name="pricePer1mChars"></param>
        /// <param name="commercial"></param>
        /// <param name="emailVerified"></param>
        /// <param name="upgradeUrl"></param>
        /// <param name="stripeMode"></param>
        /// <param name="premiumVoicepacksEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageResponse(
            int? creditsChars,
            int? lifetimeChars,
            int? monthlyChars,
            double? pricePer1kChars,
            double? pricePer1mChars,
            bool? commercial,
            bool? emailVerified,
            string? upgradeUrl,
            string? stripeMode,
            bool? premiumVoicepacksEnabled)
        {
            this.CreditsChars = creditsChars;
            this.LifetimeChars = lifetimeChars;
            this.MonthlyChars = monthlyChars;
            this.PricePer1kChars = pricePer1kChars;
            this.PricePer1mChars = pricePer1mChars;
            this.Commercial = commercial;
            this.EmailVerified = emailVerified;
            this.UpgradeUrl = upgradeUrl;
            this.StripeMode = stripeMode;
            this.PremiumVoicepacksEnabled = premiumVoicepacksEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        public UsageResponse()
        {
        }

    }
}