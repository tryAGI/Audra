#nullable enable

namespace Audra
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Synthesize speech from pre-chunked segments
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechBatchAsync(

            global::Audra.BatchSpeechRequest request,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechBatchXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech from pre-chunked segments
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateSpeechBatchAsStreamAsync(

            global::Audra.BatchSpeechRequest request,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechBatchXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech from pre-chunked segments
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<byte[]>> CreateSpeechBatchAsResponseAsync(

            global::Audra.BatchSpeechRequest request,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechBatchXAudraCommercialUse? xAudraCommercialUse = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech from pre-chunked segments
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="xAudraCommercialUse"></param>
        /// <param name="model">
        /// Default Value: audra-core
        /// </param>
        /// <param name="voice">
        /// Default Value: june
        /// </param>
        /// <param name="speed">
        /// Default Value: 1.0
        /// </param>
        /// <param name="crossfadeMs">
        /// Crossfade duration between segments (ms). Pauses under 300ms use crossfade instead of inserted silence for smoother podcast beats.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="segments"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechBatchAsync(
            global::System.Collections.Generic.IList<global::Audra.BatchSegment> segments,
            string? idempotencyKey = default,
            global::Audra.CreateSpeechBatchXAudraCommercialUse? xAudraCommercialUse = default,
            string? model = default,
            string? voice = default,
            double? speed = default,
            int? crossfadeMs = default,
            global::Audra.BatchSpeechRequestFormat? format = default,
            global::Audra.BatchSpeechRequestDeliveryProfile? deliveryProfile = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}