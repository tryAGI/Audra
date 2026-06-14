
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicStats
    {
        /// <summary>
        /// Real user accounts (excludes test/automation emails)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts")]
        public int? Accounts { get; set; }

        /// <summary>
        /// Lifetime chars rendered by real users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chars_rendered")]
        public int? CharsRendered { get; set; }

        /// <summary>
        /// All accounts except @audra.dev smoke signups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts_all")]
        public int? AccountsAll { get; set; }

        /// <summary>
        /// Lifetime chars including test traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chars_rendered_all")]
        public int? CharsRenderedAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicStats" /> class.
        /// </summary>
        /// <param name="accounts">
        /// Real user accounts (excludes test/automation emails)
        /// </param>
        /// <param name="charsRendered">
        /// Lifetime chars rendered by real users
        /// </param>
        /// <param name="accountsAll">
        /// All accounts except @audra.dev smoke signups
        /// </param>
        /// <param name="charsRenderedAll">
        /// Lifetime chars including test traffic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicStats(
            int? accounts,
            int? charsRendered,
            int? accountsAll,
            int? charsRenderedAll)
        {
            this.Accounts = accounts;
            this.CharsRendered = charsRendered;
            this.AccountsAll = accountsAll;
            this.CharsRenderedAll = charsRenderedAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicStats" /> class.
        /// </summary>
        public PublicStats()
        {
        }

    }
}