
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial class KeycloakClient
    {


        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement s_GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[] s_GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionSecurityRequirements =
            new global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[]
            {                s_GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionSecurityRequirement0,
            };
        partial void PrepareGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? fields,
            ref int? first,
            ref int? max,
            ref string? name,
            ref string? owner,
            ref bool? permission,
            ref string? policyId,
            ref string? resource,
            ref string? resourceType,
            ref string? scope,
            ref string? type,
            ref string realm,
            ref string clientUuid);
        partial void PrepareGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? fields,
            int? first,
            int? max,
            string? name,
            string? owner,
            bool? permission,
            string? policyId,
            string? resource,
            string? resourceType,
            string? scope,
            string? type,
            string realm,
            string clientUuid);
        partial void ProcessGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        ///
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="first"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="permission"></param>
        /// <param name="policyId"></param>
        /// <param name="resource"></param>
        /// <param name="resourceType"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync(
            string realm,
            string clientUuid,
            string? fields = default,
            int? first = default,
            int? max = default,
            string? name = default,
            string? owner = default,
            bool? permission = default,
            string? policyId = default,
            string? resource = default,
            string? resourceType = default,
            string? scope = default,
            string? type = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsResponseAsync(
                realm: realm,
                clientUuid: clientUuid,
                fields: fields,
                first: first,
                max: max,
                name: name,
                owner: owner,
                permission: permission,
                policyId: policyId,
                resource: resource,
                resourceType: resourceType,
                scope: scope,
                type: type,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="first"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="permission"></param>
        /// <param name="policyId"></param>
        /// <param name="resource"></param>
        /// <param name="resourceType"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsResponseAsync(
            string realm,
            string clientUuid,
            string? fields = default,
            int? first = default,
            int? max = default,
            string? name = default,
            string? owner = default,
            bool? permission = default,
            string? policyId = default,
            string? resource = default,
            string? resourceType = default,
            string? scope = default,
            string? type = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionArguments(
                httpClient: HttpClient,
                fields: ref fields,
                first: ref first,
                max: ref max,
                name: ref name,
                owner: ref owner,
                permission: ref permission,
                policyId: ref policyId,
                resource: ref resource,
                resourceType: ref resourceType,
                scope: ref scope,
                type: ref type,
                realm: ref realm,
                clientUuid: ref clientUuid);


            var __authorizations = global::Loud.Technology.Keycloak.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionSecurityRequirements,
                operationName: "GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync");

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
                                path: $"/admin/realms/{realm}/clients/{clientUuid}/authz/resource-server/permission",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("fields", fields)
                                .AddOptionalParameter("first", first?.ToString())
                                .AddOptionalParameter("max", max?.ToString())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("owner", owner)
                                .AddOptionalParameter("permission", permission?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("policyId", policyId)
                                .AddOptionalParameter("resource", resource)
                                .AddOptionalParameter("resourceType", resourceType)
                                .AddOptionalParameter("scope", scope)
                                .AddOptionalParameter("type", type)
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
                PrepareGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    fields: fields,
                    first: first,
                    max: max,
                    name: name,
                    owner: owner,
                    permission: permission,
                    policyId: policyId,
                    resource: resource,
                    resourceType: resourceType,
                    scope: scope,
                    type: type,
                    realm: realm!,
                    clientUuid: clientUuid!);

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
                                operationId: "getAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermission",
                                methodName: "GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}/authz/resource-server/permission\"",
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
                                operationId: "getAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermission",
                                methodName: "GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}/authz/resource-server/permission\"",
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
                                operationId: "getAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermission",
                                methodName: "GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}/authz/resource-server/permission\"",
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
                ProcessGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermission",
                                methodName: "GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}/authz/resource-server/permission\"",
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
                                operationId: "getAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermission",
                                methodName: "GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}/authz/resource-server/permission\"",
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
                                ProcessGetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>>(
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

                                    var __value = (global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AbstractPolicyRepresentation>>(
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