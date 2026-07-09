#nullable enable

namespace Audra
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Synthesize speech with word-level caption timestamps<br/>
        /// Returns MP3/WAV plus estimated word timestamps in the `X-Captions-Json` response header.<br/>
        /// Timestamps are duration-weighted estimates (not forced alignment). Max **50,000** characters.
        /// </summary>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechCaptionedAsync(

            global::Audra.CaptionedSpeechRequest request,
            global::Audra.CreateSpeechCaptionedXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech with word-level caption timestamps<br/>
        /// Returns MP3/WAV plus estimated word timestamps in the `X-Captions-Json` response header.<br/>
        /// Timestamps are duration-weighted estimates (not forced alignment). Max **50,000** characters.
        /// </summary>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateSpeechCaptionedAsStreamAsync(

            global::Audra.CaptionedSpeechRequest request,
            global::Audra.CreateSpeechCaptionedXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech with word-level caption timestamps<br/>
        /// Returns MP3/WAV plus estimated word timestamps in the `X-Captions-Json` response header.<br/>
        /// Timestamps are duration-weighted estimates (not forced alignment). Max **50,000** characters.
        /// </summary>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<byte[]>> CreateSpeechCaptionedAsResponseAsync(

            global::Audra.CaptionedSpeechRequest request,
            global::Audra.CreateSpeechCaptionedXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech with word-level caption timestamps<br/>
        /// Returns MP3/WAV plus estimated word timestamps in the `X-Captions-Json` response header.<br/>
        /// Timestamps are duration-weighted estimates (not forced alignment). Max **50,000** characters.
        /// </summary>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="model">
        /// Default Value: audra-essential
        /// </param>
        /// <param name="text"></param>
        /// <param name="voice">
        /// Default Value: june
        /// </param>
        /// <param name="speed">
        /// Default Value: 1.0
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="normalize">
        /// Default Value: true
        /// </param>
        /// <param name="language">
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix. Provide explicitly for designed voices or to force<br/>
        /// a specific G2P backend.<br/>
        /// Example: fr-fr
        /// </param>
        /// <param name="renderMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechCaptionedAsync(
            string text,
            global::Audra.CreateSpeechCaptionedXAudraCommercialUse? xAudraCommercialUse = default,
            string? model = default,
            string? voice = default,
            double? speed = default,
            global::Audra.CaptionedSpeechRequestFormat? format = default,
            global::Audra.CaptionedSpeechRequestDeliveryProfile? deliveryProfile = default,
            bool? normalize = default,
            string? language = default,
            global::Audra.CaptionedSpeechRequestRenderMode? renderMode = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}