
#nullable enable

namespace Audra
{
    /// <summary>
    /// Audra-native text-to-speech API with credit-based billing.<br/>
    /// **Models:** `audra-essential` (Essential), `audra-plus` (Plus), `audra-pro` (Pro), `audra-conversations` (Conversations).<br/>
    /// Legacy ids (`audra-essential`, `audra-studio-lite`, `audra-studio`, `audra-studio-dialogue`) remain accepted and resolve to the canonical ids above.<br/>
    /// **Commercial use:** Free trial is evaluation-only. After purchasing credits, send<br/>
    /// `X-Audra-Commercial-Use: true` on production renders. Paid accounts receive<br/>
    /// `X-Commercial-Allowed: true` on successful speech responses.<br/>
    /// **Legacy v1:** `/v1/*` remains available with `Deprecation` and `Sunset` headers until sunset.<br/>
    /// See `/docs/v2` and `docs/MIGRATION_V1_V2.md`.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAudraClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Audra.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Audra.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Audra.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Audra.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// Creates idempotency keys for generated idempotent requests when the caller does not provide one.
        /// </summary>
        public global::System.Func<string> CreateIdempotencyKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public LexiconClient Lexicon { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetaClient Meta { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechClient Speech { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices { get; }

    }
}