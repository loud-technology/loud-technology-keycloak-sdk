
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial class UsersClient
    {


        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement s_GetAdminRealmsByRealmUsersSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[] s_GetAdminRealmsByRealmUsersSecurityRequirements =
            new global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[]
            {                s_GetAdminRealmsByRealmUsersSecurityRequirement0,
            };
        partial void PrepareGetAdminRealmsByRealmUsersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? briefRepresentation,
            ref string? createdAfter,
            ref string? createdBefore,
            ref string? email,
            ref bool? emailVerified,
            ref bool? enabled,
            ref bool? exact,
            ref int? first,
            ref string? firstName,
            ref string? idpAlias,
            ref string? idpUserId,
            ref string? lastName,
            ref int? max,
            ref string? q,
            ref string? search,
            ref string? username,
            ref string realm);
        partial void PrepareGetAdminRealmsByRealmUsersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? briefRepresentation,
            string? createdAfter,
            string? createdBefore,
            string? email,
            bool? emailVerified,
            bool? enabled,
            bool? exact,
            int? first,
            string? firstName,
            string? idpAlias,
            string? idpUserId,
            string? lastName,
            int? max,
            string? q,
            string? search,
            string? username,
            string realm);
        partial void ProcessGetAdminRealmsByRealmUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAdminRealmsByRealmUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get users Returns a stream of users, filtered according to query parameters.<br/>
        /// Returns a stream of users. Note that the 'credentials' field in the returned UserRepresentation objects is typically not populated for performance reasons. If specific credential metadata is required, use the dedicated 'GET /admin/realms/{realm}/users/{user-id}/credentials' endpoint.
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled"></param>
        /// <param name="exact"></param>
        /// <param name="first"></param>
        /// <param name="firstName"></param>
        /// <param name="idpAlias"></param>
        /// <param name="idpUserId"></param>
        /// <param name="lastName"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>> GetAdminRealmsByRealmUsersAsync(
            string realm,
            bool? briefRepresentation = default,
            string? createdAfter = default,
            string? createdBefore = default,
            string? email = default,
            bool? emailVerified = default,
            bool? enabled = default,
            bool? exact = default,
            int? first = default,
            string? firstName = default,
            string? idpAlias = default,
            string? idpUserId = default,
            string? lastName = default,
            int? max = default,
            string? q = default,
            string? search = default,
            string? username = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAdminRealmsByRealmUsersAsResponseAsync(
                realm: realm,
                briefRepresentation: briefRepresentation,
                createdAfter: createdAfter,
                createdBefore: createdBefore,
                email: email,
                emailVerified: emailVerified,
                enabled: enabled,
                exact: exact,
                first: first,
                firstName: firstName,
                idpAlias: idpAlias,
                idpUserId: idpUserId,
                lastName: lastName,
                max: max,
                q: q,
                search: search,
                username: username,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get users Returns a stream of users, filtered according to query parameters.<br/>
        /// Returns a stream of users. Note that the 'credentials' field in the returned UserRepresentation objects is typically not populated for performance reasons. If specific credential metadata is required, use the dedicated 'GET /admin/realms/{realm}/users/{user-id}/credentials' endpoint.
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled"></param>
        /// <param name="exact"></param>
        /// <param name="first"></param>
        /// <param name="firstName"></param>
        /// <param name="idpAlias"></param>
        /// <param name="idpUserId"></param>
        /// <param name="lastName"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>>> GetAdminRealmsByRealmUsersAsResponseAsync(
            string realm,
            bool? briefRepresentation = default,
            string? createdAfter = default,
            string? createdBefore = default,
            string? email = default,
            bool? emailVerified = default,
            bool? enabled = default,
            bool? exact = default,
            int? first = default,
            string? firstName = default,
            string? idpAlias = default,
            string? idpUserId = default,
            string? lastName = default,
            int? max = default,
            string? q = default,
            string? search = default,
            string? username = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAdminRealmsByRealmUsersArguments(
                httpClient: HttpClient,
                briefRepresentation: ref briefRepresentation,
                createdAfter: ref createdAfter,
                createdBefore: ref createdBefore,
                email: ref email,
                emailVerified: ref emailVerified,
                enabled: ref enabled,
                exact: ref exact,
                first: ref first,
                firstName: ref firstName,
                idpAlias: ref idpAlias,
                idpUserId: ref idpUserId,
                lastName: ref lastName,
                max: ref max,
                q: ref q,
                search: ref search,
                username: ref username,
                realm: ref realm);


            var __authorizations = global::Loud.Technology.Keycloak.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAdminRealmsByRealmUsersSecurityRequirements,
                operationName: "GetAdminRealmsByRealmUsersAsync");

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
                                path: $"/admin/realms/{realm}/users",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("briefRepresentation", briefRepresentation?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("createdAfter", createdAfter)
                                .AddOptionalParameter("createdBefore", createdBefore)
                                .AddOptionalParameter("email", email)
                                .AddOptionalParameter("emailVerified", emailVerified?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("enabled", enabled?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("exact", exact?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("first", first?.ToString())
                                .AddOptionalParameter("firstName", firstName)
                                .AddOptionalParameter("idpAlias", idpAlias)
                                .AddOptionalParameter("idpUserId", idpUserId)
                                .AddOptionalParameter("lastName", lastName)
                                .AddOptionalParameter("max", max?.ToString())
                                .AddOptionalParameter("q", q)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("username", username)
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
                PrepareGetAdminRealmsByRealmUsersRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    briefRepresentation: briefRepresentation,
                    createdAfter: createdAfter,
                    createdBefore: createdBefore,
                    email: email,
                    emailVerified: emailVerified,
                    enabled: enabled,
                    exact: exact,
                    first: first,
                    firstName: firstName,
                    idpAlias: idpAlias,
                    idpUserId: idpUserId,
                    lastName: lastName,
                    max: max,
                    q: q,
                    search: search,
                    username: username,
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
                                operationId: "getAdminRealmsByRealmUsers",
                                methodName: "GetAdminRealmsByRealmUsersAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/users\"",
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
                                operationId: "getAdminRealmsByRealmUsers",
                                methodName: "GetAdminRealmsByRealmUsersAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/users\"",
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
                                operationId: "getAdminRealmsByRealmUsers",
                                methodName: "GetAdminRealmsByRealmUsersAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/users\"",
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
                ProcessGetAdminRealmsByRealmUsersResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmUsers",
                                methodName: "GetAdminRealmsByRealmUsersAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/users\"",
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
                                operationId: "getAdminRealmsByRealmUsers",
                                methodName: "GetAdminRealmsByRealmUsersAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/users\"",
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
                            //
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
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
                                ProcessGetAdminRealmsByRealmUsersResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>>(
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

                                    var __value = (global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>>(
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