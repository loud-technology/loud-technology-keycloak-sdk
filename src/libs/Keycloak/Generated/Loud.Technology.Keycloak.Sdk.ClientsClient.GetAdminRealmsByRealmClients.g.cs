
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial class ClientsClient
    {


        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement s_GetAdminRealmsByRealmClientsSecurityRequirement0 =
            new global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Loud.Technology.Keycloak.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Loud.Technology.Keycloak.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[] s_GetAdminRealmsByRealmClientsSecurityRequirements =
            new global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[]
            {                s_GetAdminRealmsByRealmClientsSecurityRequirement0,
            };
        partial void PrepareGetAdminRealmsByRealmClientsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? clientId,
            ref int? first,
            ref int? max,
            ref string? q,
            ref bool? search,
            ref bool? viewableOnly,
            ref string realm);
        partial void PrepareGetAdminRealmsByRealmClientsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? clientId,
            int? first,
            int? max,
            string? q,
            bool? search,
            bool? viewableOnly,
            string realm);
        partial void ProcessGetAdminRealmsByRealmClientsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAdminRealmsByRealmClientsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get clients belonging to the realm.<br/>
        /// If a client can’t be retrieved from the storage due to a problem with the underlying storage, it is silently removed from the returned list. This ensures that concurrent modifications to the list don’t prevent callers from retrieving this list.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search">
        /// Default Value: false
        /// </param>
        /// <param name="viewableOnly">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>> GetAdminRealmsByRealmClientsAsync(
            string realm,
            string? clientId = default,
            int? first = default,
            int? max = default,
            string? q = default,
            bool? search = default,
            bool? viewableOnly = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAdminRealmsByRealmClientsAsResponseAsync(
                realm: realm,
                clientId: clientId,
                first: first,
                max: max,
                q: q,
                search: search,
                viewableOnly: viewableOnly,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get clients belonging to the realm.<br/>
        /// If a client can’t be retrieved from the storage due to a problem with the underlying storage, it is silently removed from the returned list. This ensures that concurrent modifications to the list don’t prevent callers from retrieving this list.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search">
        /// Default Value: false
        /// </param>
        /// <param name="viewableOnly">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>>> GetAdminRealmsByRealmClientsAsResponseAsync(
            string realm,
            string? clientId = default,
            int? first = default,
            int? max = default,
            string? q = default,
            bool? search = default,
            bool? viewableOnly = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAdminRealmsByRealmClientsArguments(
                httpClient: HttpClient,
                clientId: ref clientId,
                first: ref first,
                max: ref max,
                q: ref q,
                search: ref search,
                viewableOnly: ref viewableOnly,
                realm: ref realm);


            var __authorizations = global::Loud.Technology.Keycloak.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAdminRealmsByRealmClientsSecurityRequirements,
                operationName: "GetAdminRealmsByRealmClientsAsync");

            using var __timeoutCancellationTokenSource = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Loud.Technology.Keycloak.Sdk.PathBuilder(
                                path: $"/admin/realms/{realm}/clients",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("clientId", clientId)
                                .AddOptionalParameter("first", first?.ToString())
                                .AddOptionalParameter("max", max?.ToString())
                                .AddOptionalParameter("q", q)
                                .AddOptionalParameter("search", search?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("viewableOnly", viewableOnly?.ToString().ToLowerInvariant())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetAdminRealmsByRealmClientsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    clientId: clientId,
                    first: first,
                    max: max,
                    q: q,
                    search: search,
                    viewableOnly: viewableOnly,
                    realm: realm!);

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
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmClients",
                                methodName: "GetAdminRealmsByRealmClientsAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients\"",
                                httpMethod: "GET",
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
                        var __retryDelay = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmClients",
                                methodName: "GetAdminRealmsByRealmClientsAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients\"",
                                httpMethod: "GET",
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
                        await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmClients",
                                methodName: "GetAdminRealmsByRealmClientsAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients\"",
                                httpMethod: "GET",
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
                        await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessGetAdminRealmsByRealmClientsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmClients",
                                methodName: "GetAdminRealmsByRealmClientsAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients\"",
                                httpMethod: "GET",
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
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmClients",
                                methodName: "GetAdminRealmsByRealmClientsAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients\"",
                                httpMethod: "GET",
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
                                ProcessGetAdminRealmsByRealmClientsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
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

                                    var __value = (global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
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

                                    throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
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
    }
}