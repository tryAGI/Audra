#nullable enable

namespace Audra
{
    public partial interface ILexiconClient
    {
        /// <summary>
        /// Replace per-account pronunciation overrides<br/>
        /// Max 100 entries per account. Applied before shared finance lexicon on all speech renders.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.LexiconResponse> PutLexiconAsync(

            global::Audra.LexiconPutRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace per-account pronunciation overrides<br/>
        /// Max 100 entries per account. Applied before shared finance lexicon on all speech renders.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.LexiconResponse>> PutLexiconAsResponseAsync(

            global::Audra.LexiconPutRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace per-account pronunciation overrides<br/>
        /// Max 100 entries per account. Applied before shared finance lexicon on all speech renders.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.LexiconResponse> PutLexiconAsync(
            global::System.Collections.Generic.IList<global::Audra.LexiconEntry> entries,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}