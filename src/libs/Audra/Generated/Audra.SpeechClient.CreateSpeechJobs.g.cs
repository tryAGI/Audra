
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Audra
{
    public partial class SpeechClient
    {

        private static readonly global::Audra.AutoSDKServer[] s_CreateSpeechJobsServers = new global::Audra.AutoSDKServer[]
        {            new global::Audra.AutoSDKServer(
                id: "https-audratalks-com",
                name: "Production",
                url: "https://audratalks.com/",
                description: "Production"),
            new global::Audra.AutoSDKServer(
                id: "http-localhost",
                name: "Local gateway",
                url: "http://localhost:3000/",
                description: "Local gateway"),
        };


        private static readonly global::Audra.EndPointSecurityRequirement s_CreateSpeechJobsSecurityRequirement0 =
            new global::Audra.EndPointSecurityRequirement
            {
                Authorizations = new global::Audra.EndPointAuthorizationRequirement[]
                {                    new global::Audra.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Audra.EndPointSecurityRequirement[] s_CreateSpeechJobsSecurityRequirements =
            new global::Audra.EndPointSecurityRequirement[]
            {                s_CreateSpeechJobsSecurityRequirement0,
            };
        partial void PrepareCreateSpeechJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Audra.SpeechJobRequest request);
        partial void PrepareCreateSpeechJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Audra.SpeechJobRequest request);
        partial void ProcessCreateSpeechJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpeechJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Audra.SpeechJobResponse> CreateSpeechJobsAsync(

            global::Audra.SpeechJobRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateSpeechJobsAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Audra.AutoSDKHttpResponse<global::Audra.SpeechJobResponse>> CreateSpeechJobsAsResponseAsync(

            global::Audra.SpeechJobRequest request,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateSpeechJobsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Audra.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSpeechJobsSecurityRequirements,
                operationName: "CreateSpeechJobsAsync");

            using var __timeoutCancellationTokenSource = global::Audra.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Audra.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Audra.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Audra.PathBuilder(
                                path: "/v2/speech/jobs",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateSpeechJobsServers,
                                defaultBaseUrl: "https://audratalks.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::Audra.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Audra.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateSpeechJobsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Audra.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Audra.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpeechJobs",
                                methodName: "CreateSpeechJobsAsync",
                                pathTemplate: "\"/v2/speech/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Audra.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Audra.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Audra.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpeechJobs",
                                methodName: "CreateSpeechJobsAsync",
                                pathTemplate: "\"/v2/speech/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Audra.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Audra.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Audra.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Audra.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Audra.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpeechJobs",
                                methodName: "CreateSpeechJobsAsync",
                                pathTemplate: "\"/v2/speech/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Audra.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateSpeechJobsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Audra.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Audra.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpeechJobs",
                                methodName: "CreateSpeechJobsAsync",
                                pathTemplate: "\"/v2/speech/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Audra.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Audra.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpeechJobs",
                                methodName: "CreateSpeechJobsAsync",
                                pathTemplate: "\"/v2/speech/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Audra.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::Audra.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::Audra.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateSpeechJobsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Audra.SpeechJobResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Audra.AutoSDKHttpResponse<global::Audra.SpeechJobResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Audra.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Audra.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Audra.SpeechJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Audra.AutoSDKHttpResponse<global::Audra.SpeechJobResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Audra.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Audra.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        /// <param name="language">
        /// BCP-47 language code. When omitted the service infers the language from<br/>
        /// the voice slug prefix. Provide this field explicitly for designed voices<br/>
        /// or to force a specific G2P backend.<br/>
        /// Example: fr-fr
        /// </param>
        /// <param name="deliveryProfile"></param>
        /// <param name="audioPost"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Audra.SpeechJobResponse> CreateSpeechJobsAsync(
            string text,
            string? model = default,
            string? voice = default,
            double? speed = default,
            global::Audra.SpeechJobRequestFormat? format = default,
            string? webhookUrl = default,
            global::Audra.SpeechJobRequestMode? mode = default,
            bool? fastMode = default,
            bool? economy = default,
            string? language = default,
            global::Audra.SpeechJobRequestDeliveryProfile? deliveryProfile = default,
            global::Audra.SpeechJobRequestAudioPost? audioPost = default,
            global::Audra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Audra.SpeechJobRequest
            {
                Model = model,
                Text = text,
                Voice = voice,
                Speed = speed,
                Format = format,
                WebhookUrl = webhookUrl,
                Mode = mode,
                FastMode = fastMode,
                Economy = economy,
                Language = language,
                DeliveryProfile = deliveryProfile,
                AudioPost = audioPost,
            };

            return await CreateSpeechJobsAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}