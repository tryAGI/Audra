#nullable enable

namespace Audra
{
    public partial interface ILexiconClient
    {
        /// <summary>
        /// List per-account pronunciation overrides
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.LexiconResponse> GetLexiconAsync(
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List per-account pronunciation overrides
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.LexiconResponse>> GetLexiconAsResponseAsync(
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}