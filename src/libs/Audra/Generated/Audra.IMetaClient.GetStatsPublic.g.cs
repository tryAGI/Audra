#nullable enable

namespace Audra
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Public signup and usage counters<br/>
        /// Marketing-trust metrics for the landing page and agent crawlers.<br/>
        /// `accounts` and `chars_rendered` exclude automated test signups.<br/>
        /// `accounts_all` and `chars_rendered_all` include non-`@audra.dev` totals.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.PublicStats> GetStatsPublicAsync(
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Public signup and usage counters<br/>
        /// Marketing-trust metrics for the landing page and agent crawlers.<br/>
        /// `accounts` and `chars_rendered` exclude automated test signups.<br/>
        /// `accounts_all` and `chars_rendered_all` include non-`@audra.dev` totals.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.PublicStats>> GetStatsPublicAsResponseAsync(
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}