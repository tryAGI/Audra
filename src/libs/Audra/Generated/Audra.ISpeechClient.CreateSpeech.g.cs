#nullable enable

namespace Audra
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Synthesize speech
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(

            global::Audra.SpeechRequest request,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateSpeechAsStreamAsync(

            global::Audra.SpeechRequest request,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<byte[]>> CreateSpeechAsResponseAsync(

            global::Audra.SpeechRequest request,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="model">
        /// Default Value: audra-essential
        /// </param>
        /// <param name="text">
        /// Plain text, SSML subset, Audra pause tags (`[pause:1.5s]`),<br/>
        /// or inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.
        /// </param>
        /// <param name="voice">
        /// Voice slug from the catalog (150 voices / 10 Essential languages — list with<br/>
        /// `GET /v2/voices`) or weighted mix e.g. `june(2)+wren(1)`.<br/>
        /// Premium packs use product slugs (e.g. aurora-lead) when enabled.<br/>
        /// Default Value: june
        /// </param>
        /// <param name="speed">
        /// Default Value: 1.0
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="deliveryProfile">
        /// Podcast pacing profile (slower speed + paragraph/sentence pauses)
        /// </param>
        /// <param name="normalize">
        /// When true (default), normalize URLs, emails, currency, and percent signs before synthesis.<br/>
        /// Set false to pass text through unchanged (except pronunciation lexicon).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="language">
        /// BCP-47 language code for the requested voice. When omitted the service<br/>
        /// infers the language from the voice slug prefix (en-us, en-gb, ja, zh,<br/>
        /// es, pt-br, hi, it, fr-fr, de, nl). Provide this field explicitly when<br/>
        /// using designed/community voices that don't carry an unambiguous prefix,<br/>
        /// or when you want to force a specific G2P backend regardless of voice name.<br/>
        /// Example: fr-fr
        /// </param>
        /// <param name="renderMode">
        /// `fast` (default) = Modal GPU. `standard` = Modal CPU.<br/>
        /// Aliases `gpu` / `cpu` accepted.
        /// </param>
        /// <param name="mode">
        /// `standard` — default queue placement. `fast` — queue priority, 1.25× credits.<br/>
        /// `economy` (0.75× credits, deferred) exists but is **not valid here** — it is<br/>
        /// only accepted on `POST /v2/speech/jobs` (async). Sending `mode: "economy"`<br/>
        /// or `economy: true` on this synchronous endpoint returns 400.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            string text,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechXAudraCommercialUse? xAudraCommercialUse = default,
            string? model = default,
            string? voice = default,
            double? speed = default,
            global::Audra.SpeechRequestFormat? format = default,
            global::Audra.SpeechRequestDeliveryProfile? deliveryProfile = default,
            bool? normalize = default,
            string? language = default,
            global::Audra.SpeechRequestRenderMode? renderMode = default,
            global::Audra.SpeechRequestMode? mode = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}