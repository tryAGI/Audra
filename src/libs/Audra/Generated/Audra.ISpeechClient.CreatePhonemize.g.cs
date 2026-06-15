#nullable enable

namespace Audra
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Preview phoneme output for text (debug / tuning)<br/>
        /// Returns the phoneme string Audra Phonetics would use for the given voice.<br/>
        /// Supports inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.<br/>
        /// Max **10,000** characters. Does not consume credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.PhonemizeResponse> CreatePhonemizeAsync(

            global::Audra.PhonemizeRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview phoneme output for text (debug / tuning)<br/>
        /// Returns the phoneme string Audra Phonetics would use for the given voice.<br/>
        /// Supports inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.<br/>
        /// Max **10,000** characters. Does not consume credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.PhonemizeResponse>> CreatePhonemizeAsResponseAsync(

            global::Audra.PhonemizeRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview phoneme output for text (debug / tuning)<br/>
        /// Returns the phoneme string Audra Phonetics would use for the given voice.<br/>
        /// Supports inline IPA markup `[word](/ipa/)` when Audra Phonetics is active.<br/>
        /// Max **10,000** characters. Does not consume credits.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="voice">
        /// Default Value: june
        /// </param>
        /// <param name="renderMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.PhonemizeResponse> CreatePhonemizeAsync(
            string text,
            string? voice = default,
            global::Audra.PhonemizeRequestRenderMode? renderMode = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}