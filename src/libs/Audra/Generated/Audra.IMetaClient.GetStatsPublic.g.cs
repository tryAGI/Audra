#nullable enable

namespace Audra
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Public signup and usage counters<br/>
        /// Aggregate account count and lifetime characters rendered for marketing trust strips.<br/>
        /// Real-user counts exclude internal and automation test emails.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.PublicStats> GetStatsPublicAsync(
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Public signup and usage counters<br/>
        /// Aggregate account count and lifetime characters rendered for marketing trust strips.<br/>
        /// Real-user counts exclude internal and automation test emails.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.PublicStats>> GetStatsPublicAsResponseAsync(
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}