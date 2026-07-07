#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Audra
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Create an async speech render job<br/>
        /// Queues text for background rendering — poll `status_url` until `status`<br/>
        /// is `completed`, then download `audio_url`. Use for long-form text where a<br/>
        /// synchronous response would time out (auto-triggered above ~8k chars on<br/>
        /// `POST /v2/speech` unless `X-Audra-Sync: true` is set).<br/>
        /// Supports three delivery modes via `mode` (or the `fast_mode`/`priority`/`economy`<br/>
        /// boolean aliases): `standard` (default), `fast` (queue priority, 1.25× credits),<br/>
        /// and `economy` (deferred/best-effort, 0.75× credits — see `SpeechJobRequest.mode`).<br/>
        /// `economy` is **only** available on this async endpoint; `POST /v2/speech` and<br/>
        /// other synchronous endpoints reject it with 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.SpeechJobResponse> CreateSpeechJobsAsync(

            global::Audra.SpeechJobRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async speech render job<br/>
        /// Queues text for background rendering — poll `status_url` until `status`<br/>
        /// is `completed`, then download `audio_url`. Use for long-form text where a<br/>
        /// synchronous response would time out (auto-triggered above ~8k chars on<br/>
        /// `POST /v2/speech` unless `X-Audra-Sync: true` is set).<br/>
        /// Supports three delivery modes via `mode` (or the `fast_mode`/`priority`/`economy`<br/>
        /// boolean aliases): `standard` (default), `fast` (queue priority, 1.25× credits),<br/>
        /// and `economy` (deferred/best-effort, 0.75× credits — see `SpeechJobRequest.mode`).<br/>
        /// `economy` is **only** available on this async endpoint; `POST /v2/speech` and<br/>
        /// other synchronous endpoints reject it with 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.SpeechJobResponse>> CreateSpeechJobsAsResponseAsync(

            global::Audra.SpeechJobRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async speech render job<br/>
        /// Queues text for background rendering — poll `status_url` until `status`<br/>
        /// is `completed`, then download `audio_url`. Use for long-form text where a<br/>
        /// synchronous response would time out (auto-triggered above ~8k chars on<br/>
        /// `POST /v2/speech` unless `X-Audra-Sync: true` is set).<br/>
        /// Supports three delivery modes via `mode` (or the `fast_mode`/`priority`/`economy`<br/>
        /// boolean aliases): `standard` (default), `fast` (queue priority, 1.25× credits),<br/>
        /// and `economy` (deferred/best-effort, 0.75× credits — see `SpeechJobRequest.mode`).<br/>
        /// `economy` is **only** available on this async endpoint; `POST /v2/speech` and<br/>
        /// other synchronous endpoints reject it with 400.
        /// </summary>
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
        /// <param name="webhookUrl">
        /// Optional callback POSTed with `{ job_id, status, chars }` on completion or failure.
        /// </param>
        /// <param name="mode">
        /// `standard` — default queue placement, 1.0× credits.<br/>
        /// `fast` — queue priority, 1.25× credits.<br/>
        /// `economy` — deferred/best-effort, 0.75× credits (25% discount). Runs on the<br/>
        /// next scheduled sweep (default every 12h) or sooner if a worker for the<br/>
        /// requested model is already warm from other traffic. Async jobs only —<br/>
        /// rejected with 400 on synchronous endpoints (`POST /v2/speech` and similar).<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="fastMode">
        /// Alias for mode: "fast".
        /// </param>
        /// <param name="economy">
        /// Alias for mode: "economy".
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="scriptEnhance"></param>
        /// <param name="audioPost"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audra.SpeechJobResponse> CreateSpeechJobsAsync(
            string text,
            string? model = default,
            string? voice = default,
            double? speed = default,
            global::Audra.SpeechJobRequestFormat? format = default,
            string? webhookUrl = default,
            global::Audra.SpeechJobRequestMode? mode = default,
            bool? fastMode = default,
            bool? economy = default,
            global::Audra.SpeechJobRequestDeliveryProfile? deliveryProfile = default,
            global::Audra.SpeechJobRequestScriptEnhance? scriptEnhance = default,
            global::Audra.SpeechJobRequestAudioPost? audioPost = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}