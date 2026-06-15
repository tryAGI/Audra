#nullable enable

namespace Audra
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Rate-limited voice health sample (no credits charged)<br/>
        /// Renders a 50-character sample via CPU worker. Limited to 10 probes per account per day.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.VoiceProbeResponse> GetVoicesBySlugProbeAsync(
            string slug,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rate-limited voice health sample (no credits charged)<br/>
        /// Renders a 50-character sample via CPU worker. Limited to 10 probes per account per day.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.VoiceProbeResponse>> GetVoicesBySlugProbeAsResponseAsync(
            string slug,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}