
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial class ClientsClient
    {


        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement s_PutAdminRealmsByRealmClientsByClientUuidSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[] s_PutAdminRealmsByRealmClientsByClientUuidSecurityRequirements =
            new global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[]
            {                s_PutAdminRealmsByRealmClientsByClientUuidSecurityRequirement0,
            };
        partial void PreparePutAdminRealmsByRealmClientsByClientUuidArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string realm,
            ref string clientUuid,
            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation request);
        partial void PreparePutAdminRealmsByRealmClientsByClientUuidRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string realm,
            string clientUuid,
            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation request);
        partial void ProcessPutAdminRealmsByRealmClientsByClientUuidResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update the client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientsByClientUuidAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await PutAdminRealmsByRealmClientsByClientUuidAsResponseAsync(
                realm: realm,
                clientUuid: clientUuid,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmClientsByClientUuidAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePutAdminRealmsByRealmClientsByClientUuidArguments(
                httpClient: HttpClient,
                realm: ref realm,
                clientUuid: ref clientUuid,
                request: request);


            var __authorizations = global::Loud.Technology.Keycloak.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PutAdminRealmsByRealmClientsByClientUuidSecurityRequirements,
                operationName: "PutAdminRealmsByRealmClientsByClientUuidAsync");

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
                                path: $"/admin/realms/{realm}/clients/{clientUuid}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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
                global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePutAdminRealmsByRealmClientsByClientUuidRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    realm: realm!,
                    clientUuid: clientUuid!,
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
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "putAdminRealmsByRealmClientsByClientUuid",
                                methodName: "PutAdminRealmsByRealmClientsByClientUuidAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}\"",
                                httpMethod: "PUT",
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
                                operationId: "putAdminRealmsByRealmClientsByClientUuid",
                                methodName: "PutAdminRealmsByRealmClientsByClientUuidAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}\"",
                                httpMethod: "PUT",
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
                                operationId: "putAdminRealmsByRealmClientsByClientUuid",
                                methodName: "PutAdminRealmsByRealmClientsByClientUuidAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}\"",
                                httpMethod: "PUT",
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
                ProcessPutAdminRealmsByRealmClientsByClientUuidResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "putAdminRealmsByRealmClientsByClientUuid",
                                methodName: "PutAdminRealmsByRealmClientsByClientUuidAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}\"",
                                httpMethod: "PUT",
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
                                operationId: "putAdminRealmsByRealmClientsByClientUuid",
                                methodName: "PutAdminRealmsByRealmClientsByClientUuidAsync",
                                pathTemplate: "$\"/admin/realms/{realm}/clients/{clientUuid}\"",
                                httpMethod: "PUT",
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


                                throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
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
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    responseBody: __content_409,
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                    return new global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
        /// <summary>
        /// Update the client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="rootUrl"></param>
        /// <param name="adminUrl"></param>
        /// <param name="baseUrl"></param>
        /// <param name="surrogateAuthRequired"></param>
        /// <param name="enabled"></param>
        /// <param name="alwaysDisplayInConsole"></param>
        /// <param name="clientAuthenticatorType"></param>
        /// <param name="secret"></param>
        /// <param name="registrationAccessToken"></param>
        /// <param name="redirectUris"></param>
        /// <param name="webOrigins"></param>
        /// <param name="notBefore"></param>
        /// <param name="bearerOnly"></param>
        /// <param name="consentRequired"></param>
        /// <param name="standardFlowEnabled"></param>
        /// <param name="implicitFlowEnabled"></param>
        /// <param name="directAccessGrantsEnabled"></param>
        /// <param name="serviceAccountsEnabled"></param>
        /// <param name="authorizationServicesEnabled"></param>
        /// <param name="publicClient"></param>
        /// <param name="frontchannelLogout"></param>
        /// <param name="protocol"></param>
        /// <param name="attributes"></param>
        /// <param name="authenticationFlowBindingOverrides"></param>
        /// <param name="fullScopeAllowed"></param>
        /// <param name="nodeReRegistrationTimeout"></param>
        /// <param name="registeredNodes"></param>
        /// <param name="protocolMappers"></param>
        /// <param name="defaultClientScopes"></param>
        /// <param name="optionalClientScopes"></param>
        /// <param name="authorizationSettings"></param>
        /// <param name="access"></param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientsByClientUuidAsync(
            string realm,
            string clientUuid,
            string? id = default,
            string? clientId = default,
            string? name = default,
            string? description = default,
            string? type = default,
            string? rootUrl = default,
            string? adminUrl = default,
            string? baseUrl = default,
            bool? surrogateAuthRequired = default,
            bool? enabled = default,
            bool? alwaysDisplayInConsole = default,
            string? clientAuthenticatorType = default,
            string? secret = default,
            string? registrationAccessToken = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            global::System.Collections.Generic.IList<string>? webOrigins = default,
            int? notBefore = default,
            bool? bearerOnly = default,
            bool? consentRequired = default,
            bool? standardFlowEnabled = default,
            bool? implicitFlowEnabled = default,
            bool? directAccessGrantsEnabled = default,
            bool? serviceAccountsEnabled = default,
            bool? authorizationServicesEnabled = default,
            bool? publicClient = default,
            bool? frontchannelLogout = default,
            string? protocol = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributes = default,
            global::System.Collections.Generic.Dictionary<string, string>? authenticationFlowBindingOverrides = default,
            bool? fullScopeAllowed = default,
            int? nodeReRegistrationTimeout = default,
            global::System.Collections.Generic.Dictionary<string, int>? registeredNodes = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? protocolMappers = default,
            global::System.Collections.Generic.IList<string>? defaultClientScopes = default,
            global::System.Collections.Generic.IList<string>? optionalClientScopes = default,
            global::Loud.Technology.Keycloak.Sdk.ResourceServerRepresentation? authorizationSettings = default,
            global::System.Collections.Generic.Dictionary<string, bool>? access = default,
            string? origin = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.Keycloak.Sdk.ClientRepresentation
            {
                Id = id,
                ClientId = clientId,
                Name = name,
                Description = description,
                Type = type,
                RootUrl = rootUrl,
                AdminUrl = adminUrl,
                BaseUrl = baseUrl,
                SurrogateAuthRequired = surrogateAuthRequired,
                Enabled = enabled,
                AlwaysDisplayInConsole = alwaysDisplayInConsole,
                ClientAuthenticatorType = clientAuthenticatorType,
                Secret = secret,
                RegistrationAccessToken = registrationAccessToken,
                RedirectUris = redirectUris,
                WebOrigins = webOrigins,
                NotBefore = notBefore,
                BearerOnly = bearerOnly,
                ConsentRequired = consentRequired,
                StandardFlowEnabled = standardFlowEnabled,
                ImplicitFlowEnabled = implicitFlowEnabled,
                DirectAccessGrantsEnabled = directAccessGrantsEnabled,
                ServiceAccountsEnabled = serviceAccountsEnabled,
                AuthorizationServicesEnabled = authorizationServicesEnabled,
                PublicClient = publicClient,
                FrontchannelLogout = frontchannelLogout,
                Protocol = protocol,
                Attributes = attributes,
                AuthenticationFlowBindingOverrides = authenticationFlowBindingOverrides,
                FullScopeAllowed = fullScopeAllowed,
                NodeReRegistrationTimeout = nodeReRegistrationTimeout,
                RegisteredNodes = registeredNodes,
                ProtocolMappers = protocolMappers,
                DefaultClientScopes = defaultClientScopes,
                OptionalClientScopes = optionalClientScopes,
                AuthorizationSettings = authorizationSettings,
                Access = access,
                Origin = origin,
            };

            await PutAdminRealmsByRealmClientsByClientUuidAsync(
                realm: realm,
                clientUuid: clientUuid,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}