#nullable enable

namespace Audra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Create Stripe Checkout session for credit pack
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.CreateBillingCheckoutResponse> CreateBillingCheckoutAsync(

            global::Audra.CreateBillingCheckoutRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Stripe Checkout session for credit pack
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.CreateBillingCheckoutResponse>> CreateBillingCheckoutAsResponseAsync(

            global::Audra.CreateBillingCheckoutRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Stripe Checkout session for credit pack
        /// </summary>
        /// <param name="pack"></param>
        /// <param name="amountUsd">
        /// Custom prepaid amount in USD ($5–$500). Mutually exclusive with pack.
        /// </param>
        /// <param name="promoCode">
        /// WELCOME20 — 50% off your first pack on this account.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.CreateBillingCheckoutResponse> CreateBillingCheckoutAsync(
            global::Audra.CreateBillingCheckoutRequestPack? pack = default,
            double? amountUsd = default,
            string? promoCode = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}