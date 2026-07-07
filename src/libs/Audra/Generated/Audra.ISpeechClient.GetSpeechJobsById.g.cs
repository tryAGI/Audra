#nullable enable

namespace Audra
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Poll async speech job status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.SpeechJobStatusResponse> GetSpeechJobsByIdAsync(
            string id,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll async speech job status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.SpeechJobStatusResponse>> GetSpeechJobsByIdAsResponseAsync(
            string id,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}