
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial class RealmsAdminClient
    {


        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement s_PutAdminRealmsByRealmSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[] s_PutAdminRealmsByRealmSecurityRequirements =
            new global::Loud.Technology.Keycloak.Sdk.EndPointSecurityRequirement[]
            {                s_PutAdminRealmsByRealmSecurityRequirement0,
            };
        partial void PreparePutAdminRealmsByRealmArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string realm,
            global::Loud.Technology.Keycloak.Sdk.RealmRepresentation request);
        partial void PreparePutAdminRealmsByRealmRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string realm,
            global::Loud.Technology.Keycloak.Sdk.RealmRepresentation request);
        partial void ProcessPutAdminRealmsByRealmResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.<br/>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PutAdminRealmsByRealmAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RealmRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await PutAdminRealmsByRealmAsResponseAsync(
                realm: realm,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.<br/>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RealmRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePutAdminRealmsByRealmArguments(
                httpClient: HttpClient,
                realm: ref realm,
                request: request);


            var __authorizations = global::Loud.Technology.Keycloak.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PutAdminRealmsByRealmSecurityRequirements,
                operationName: "PutAdminRealmsByRealmAsync");

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
                                path: $"/admin/realms/{realm}",
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
                PreparePutAdminRealmsByRealmRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    realm: realm!,
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
                                operationId: "putAdminRealmsByRealm",
                                methodName: "PutAdminRealmsByRealmAsync",
                                pathTemplate: "$\"/admin/realms/{realm}\"",
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
                                operationId: "putAdminRealmsByRealm",
                                methodName: "PutAdminRealmsByRealmAsync",
                                pathTemplate: "$\"/admin/realms/{realm}\"",
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
                                operationId: "putAdminRealmsByRealm",
                                methodName: "PutAdminRealmsByRealmAsync",
                                pathTemplate: "$\"/admin/realms/{realm}\"",
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
                ProcessPutAdminRealmsByRealmResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "putAdminRealmsByRealm",
                                methodName: "PutAdminRealmsByRealmAsync",
                                pathTemplate: "$\"/admin/realms/{realm}\"",
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
                                operationId: "putAdminRealmsByRealm",
                                methodName: "PutAdminRealmsByRealmAsync",
                                pathTemplate: "$\"/admin/realms/{realm}\"",
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
                            //
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
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
                            //
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Loud.Technology.Keycloak.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
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
        /// Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.<br/>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestRealm"></param>
        /// <param name="displayName"></param>
        /// <param name="displayNameHtml"></param>
        /// <param name="notBefore"></param>
        /// <param name="defaultSignatureAlgorithm"></param>
        /// <param name="revokeRefreshToken"></param>
        /// <param name="refreshTokenMaxReuse"></param>
        /// <param name="accessTokenLifespan"></param>
        /// <param name="accessTokenLifespanForImplicitFlow"></param>
        /// <param name="ssoSessionIdleTimeout"></param>
        /// <param name="ssoSessionMaxLifespan"></param>
        /// <param name="ssoSessionIdleTimeoutRememberMe"></param>
        /// <param name="ssoSessionMaxLifespanRememberMe"></param>
        /// <param name="offlineSessionIdleTimeout"></param>
        /// <param name="offlineSessionMaxLifespanEnabled"></param>
        /// <param name="offlineSessionMaxLifespan"></param>
        /// <param name="clientSessionIdleTimeout"></param>
        /// <param name="clientSessionMaxLifespan"></param>
        /// <param name="clientOfflineSessionIdleTimeout"></param>
        /// <param name="clientOfflineSessionMaxLifespan"></param>
        /// <param name="accessCodeLifespan"></param>
        /// <param name="accessCodeLifespanUserAction"></param>
        /// <param name="accessCodeLifespanLogin"></param>
        /// <param name="actionTokenGeneratedByAdminLifespan"></param>
        /// <param name="actionTokenGeneratedByUserLifespan"></param>
        /// <param name="oauth2DeviceCodeLifespan"></param>
        /// <param name="oauth2DevicePollingInterval"></param>
        /// <param name="enabled"></param>
        /// <param name="sslRequired"></param>
        /// <param name="registrationAllowed"></param>
        /// <param name="registrationEmailAsUsername"></param>
        /// <param name="rememberMe"></param>
        /// <param name="verifyEmail"></param>
        /// <param name="loginWithEmailAllowed"></param>
        /// <param name="duplicateEmailsAllowed"></param>
        /// <param name="resetPasswordAllowed"></param>
        /// <param name="editUsernameAllowed"></param>
        /// <param name="bruteForceProtected"></param>
        /// <param name="permanentLockout"></param>
        /// <param name="maxTemporaryLockouts"></param>
        /// <param name="bruteForceStrategy"></param>
        /// <param name="maxFailureWaitSeconds"></param>
        /// <param name="minimumQuickLoginWaitSeconds"></param>
        /// <param name="waitIncrementSeconds"></param>
        /// <param name="quickLoginCheckMilliSeconds"></param>
        /// <param name="maxDeltaTimeSeconds"></param>
        /// <param name="failureFactor"></param>
        /// <param name="maxSecondaryAuthFailures"></param>
        /// <param name="roles"></param>
        /// <param name="groups"></param>
        /// <param name="defaultRole"></param>
        /// <param name="adminPermissionsClient"></param>
        /// <param name="defaultGroups"></param>
        /// <param name="passwordPolicy"></param>
        /// <param name="otpPolicyType"></param>
        /// <param name="otpPolicyAlgorithm"></param>
        /// <param name="otpPolicyInitialCounter"></param>
        /// <param name="otpPolicyDigits"></param>
        /// <param name="otpPolicyLookAheadWindow"></param>
        /// <param name="otpPolicyPeriod"></param>
        /// <param name="otpPolicyCodeReusable"></param>
        /// <param name="otpSupportedApplications"></param>
        /// <param name="localizationTexts"></param>
        /// <param name="webAuthnPolicyRpEntityName"></param>
        /// <param name="webAuthnPolicySignatureAlgorithms"></param>
        /// <param name="webAuthnPolicyRpId"></param>
        /// <param name="webAuthnPolicyAttestationConveyancePreference"></param>
        /// <param name="webAuthnPolicyAuthenticatorAttachment"></param>
        /// <param name="webAuthnPolicyRequireResidentKey"></param>
        /// <param name="webAuthnPolicyResidentKey"></param>
        /// <param name="webAuthnPolicyUserVerificationRequirement"></param>
        /// <param name="webAuthnPolicyCreateTimeout"></param>
        /// <param name="webAuthnPolicyAvoidSameAuthenticatorRegister"></param>
        /// <param name="webAuthnPolicyAcceptableAaguids"></param>
        /// <param name="webAuthnPolicyExtraOrigins"></param>
        /// <param name="webAuthnPolicyPasswordlessRpEntityName"></param>
        /// <param name="webAuthnPolicyPasswordlessSignatureAlgorithms"></param>
        /// <param name="webAuthnPolicyPasswordlessRpId"></param>
        /// <param name="webAuthnPolicyPasswordlessAttestationConveyancePreference"></param>
        /// <param name="webAuthnPolicyPasswordlessAuthenticatorAttachment"></param>
        /// <param name="webAuthnPolicyPasswordlessRequireResidentKey"></param>
        /// <param name="webAuthnPolicyPasswordlessResidentKey"></param>
        /// <param name="webAuthnPolicyPasswordlessUserVerificationRequirement"></param>
        /// <param name="webAuthnPolicyPasswordlessCreateTimeout"></param>
        /// <param name="webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister"></param>
        /// <param name="webAuthnPolicyPasswordlessAcceptableAaguids"></param>
        /// <param name="webAuthnPolicyPasswordlessExtraOrigins"></param>
        /// <param name="webAuthnPolicyPasswordlessPasskeysEnabled"></param>
        /// <param name="webAuthnPolicyPasswordlessMediation"></param>
        /// <param name="clientProfiles"></param>
        /// <param name="clientPolicies"></param>
        /// <param name="users"></param>
        /// <param name="federatedUsers"></param>
        /// <param name="scopeMappings"></param>
        /// <param name="clientScopeMappings"></param>
        /// <param name="clients"></param>
        /// <param name="clientScopes"></param>
        /// <param name="defaultDefaultClientScopes"></param>
        /// <param name="defaultOptionalClientScopes"></param>
        /// <param name="browserSecurityHeaders"></param>
        /// <param name="smtpServer"></param>
        /// <param name="userFederationProviders"></param>
        /// <param name="userFederationMappers"></param>
        /// <param name="loginTheme"></param>
        /// <param name="accountTheme"></param>
        /// <param name="adminTheme"></param>
        /// <param name="emailTheme"></param>
        /// <param name="eventsEnabled"></param>
        /// <param name="eventsExpiration"></param>
        /// <param name="eventsListeners"></param>
        /// <param name="enabledEventTypes"></param>
        /// <param name="adminEventsEnabled"></param>
        /// <param name="adminEventsDetailsEnabled"></param>
        /// <param name="identityProviders"></param>
        /// <param name="identityProviderMappers"></param>
        /// <param name="protocolMappers"></param>
        /// <param name="components"></param>
        /// <param name="internationalizationEnabled"></param>
        /// <param name="supportedLocales"></param>
        /// <param name="defaultLocale"></param>
        /// <param name="authenticationFlows"></param>
        /// <param name="authenticatorConfig"></param>
        /// <param name="requiredActions"></param>
        /// <param name="browserFlow"></param>
        /// <param name="registrationFlow"></param>
        /// <param name="directGrantFlow"></param>
        /// <param name="resetCredentialsFlow"></param>
        /// <param name="clientAuthenticationFlow"></param>
        /// <param name="dockerAuthenticationFlow"></param>
        /// <param name="firstBrokerLoginFlow"></param>
        /// <param name="attributes"></param>
        /// <param name="keycloakVersion"></param>
        /// <param name="userManagedAccessAllowed"></param>
        /// <param name="organizationsEnabled"></param>
        /// <param name="organizations"></param>
        /// <param name="verifiableCredentialsEnabled"></param>
        /// <param name="adminPermissionsEnabled"></param>
        /// <param name="scimApiEnabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PutAdminRealmsByRealmAsync(
            string realm,
            string? id = default,
            string? requestRealm = default,
            string? displayName = default,
            string? displayNameHtml = default,
            int? notBefore = default,
            string? defaultSignatureAlgorithm = default,
            bool? revokeRefreshToken = default,
            int? refreshTokenMaxReuse = default,
            int? accessTokenLifespan = default,
            int? accessTokenLifespanForImplicitFlow = default,
            int? ssoSessionIdleTimeout = default,
            int? ssoSessionMaxLifespan = default,
            int? ssoSessionIdleTimeoutRememberMe = default,
            int? ssoSessionMaxLifespanRememberMe = default,
            int? offlineSessionIdleTimeout = default,
            bool? offlineSessionMaxLifespanEnabled = default,
            int? offlineSessionMaxLifespan = default,
            int? clientSessionIdleTimeout = default,
            int? clientSessionMaxLifespan = default,
            int? clientOfflineSessionIdleTimeout = default,
            int? clientOfflineSessionMaxLifespan = default,
            int? accessCodeLifespan = default,
            int? accessCodeLifespanUserAction = default,
            int? accessCodeLifespanLogin = default,
            int? actionTokenGeneratedByAdminLifespan = default,
            int? actionTokenGeneratedByUserLifespan = default,
            int? oauth2DeviceCodeLifespan = default,
            int? oauth2DevicePollingInterval = default,
            bool? enabled = default,
            string? sslRequired = default,
            bool? registrationAllowed = default,
            bool? registrationEmailAsUsername = default,
            bool? rememberMe = default,
            bool? verifyEmail = default,
            bool? loginWithEmailAllowed = default,
            bool? duplicateEmailsAllowed = default,
            bool? resetPasswordAllowed = default,
            bool? editUsernameAllowed = default,
            bool? bruteForceProtected = default,
            bool? permanentLockout = default,
            int? maxTemporaryLockouts = default,
            global::Loud.Technology.Keycloak.Sdk.BruteForceStrategy? bruteForceStrategy = default,
            int? maxFailureWaitSeconds = default,
            int? minimumQuickLoginWaitSeconds = default,
            int? waitIncrementSeconds = default,
            long? quickLoginCheckMilliSeconds = default,
            int? maxDeltaTimeSeconds = default,
            int? failureFactor = default,
            int? maxSecondaryAuthFailures = default,
            global::Loud.Technology.Keycloak.Sdk.RolesRepresentation? roles = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? groups = default,
            global::Loud.Technology.Keycloak.Sdk.RoleRepresentation? defaultRole = default,
            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation? adminPermissionsClient = default,
            global::System.Collections.Generic.IList<string>? defaultGroups = default,
            string? passwordPolicy = default,
            string? otpPolicyType = default,
            string? otpPolicyAlgorithm = default,
            int? otpPolicyInitialCounter = default,
            int? otpPolicyDigits = default,
            int? otpPolicyLookAheadWindow = default,
            int? otpPolicyPeriod = default,
            bool? otpPolicyCodeReusable = default,
            global::System.Collections.Generic.IList<string>? otpSupportedApplications = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? localizationTexts = default,
            string? webAuthnPolicyRpEntityName = default,
            global::System.Collections.Generic.IList<string>? webAuthnPolicySignatureAlgorithms = default,
            string? webAuthnPolicyRpId = default,
            string? webAuthnPolicyAttestationConveyancePreference = default,
            string? webAuthnPolicyAuthenticatorAttachment = default,
            string? webAuthnPolicyRequireResidentKey = default,
            string? webAuthnPolicyResidentKey = default,
            string? webAuthnPolicyUserVerificationRequirement = default,
            int? webAuthnPolicyCreateTimeout = default,
            bool? webAuthnPolicyAvoidSameAuthenticatorRegister = default,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyAcceptableAaguids = default,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyExtraOrigins = default,
            string? webAuthnPolicyPasswordlessRpEntityName = default,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyPasswordlessSignatureAlgorithms = default,
            string? webAuthnPolicyPasswordlessRpId = default,
            string? webAuthnPolicyPasswordlessAttestationConveyancePreference = default,
            string? webAuthnPolicyPasswordlessAuthenticatorAttachment = default,
            string? webAuthnPolicyPasswordlessRequireResidentKey = default,
            string? webAuthnPolicyPasswordlessResidentKey = default,
            string? webAuthnPolicyPasswordlessUserVerificationRequirement = default,
            int? webAuthnPolicyPasswordlessCreateTimeout = default,
            bool? webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister = default,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyPasswordlessAcceptableAaguids = default,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyPasswordlessExtraOrigins = default,
            bool? webAuthnPolicyPasswordlessPasskeysEnabled = default,
            string? webAuthnPolicyPasswordlessMediation = default,
            global::Loud.Technology.Keycloak.Sdk.ClientProfilesRepresentation? clientProfiles = default,
            global::Loud.Technology.Keycloak.Sdk.ClientPoliciesRepresentation? clientPolicies = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>? users = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>? federatedUsers = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>? scopeMappings = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>>? clientScopeMappings = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>? clients = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientScopeRepresentation>? clientScopes = default,
            global::System.Collections.Generic.IList<string>? defaultDefaultClientScopes = default,
            global::System.Collections.Generic.IList<string>? defaultOptionalClientScopes = default,
            global::System.Collections.Generic.Dictionary<string, string>? browserSecurityHeaders = default,
            global::System.Collections.Generic.Dictionary<string, string>? smtpServer = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserFederationProviderRepresentation>? userFederationProviders = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserFederationMapperRepresentation>? userFederationMappers = default,
            string? loginTheme = default,
            string? accountTheme = default,
            string? adminTheme = default,
            string? emailTheme = default,
            bool? eventsEnabled = default,
            long? eventsExpiration = default,
            global::System.Collections.Generic.IList<string>? eventsListeners = default,
            global::System.Collections.Generic.IList<string>? enabledEventTypes = default,
            bool? adminEventsEnabled = default,
            bool? adminEventsDetailsEnabled = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>? identityProviders = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderMapperRepresentation>? identityProviderMappers = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? protocolMappers = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentExportRepresentation>>? components = default,
            bool? internationalizationEnabled = default,
            global::System.Collections.Generic.IList<string>? supportedLocales = default,
            string? defaultLocale = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticationFlowRepresentation>? authenticationFlows = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticatorConfigRepresentation>? authenticatorConfig = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RequiredActionProviderRepresentation>? requiredActions = default,
            string? browserFlow = default,
            string? registrationFlow = default,
            string? directGrantFlow = default,
            string? resetCredentialsFlow = default,
            string? clientAuthenticationFlow = default,
            string? dockerAuthenticationFlow = default,
            string? firstBrokerLoginFlow = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributes = default,
            string? keycloakVersion = default,
            bool? userManagedAccessAllowed = default,
            bool? organizationsEnabled = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation>? organizations = default,
            bool? verifiableCredentialsEnabled = default,
            bool? adminPermissionsEnabled = default,
            bool? scimApiEnabled = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.Keycloak.Sdk.RealmRepresentation
            {
                Id = id,
                Realm = requestRealm,
                DisplayName = displayName,
                DisplayNameHtml = displayNameHtml,
                NotBefore = notBefore,
                DefaultSignatureAlgorithm = defaultSignatureAlgorithm,
                RevokeRefreshToken = revokeRefreshToken,
                RefreshTokenMaxReuse = refreshTokenMaxReuse,
                AccessTokenLifespan = accessTokenLifespan,
                AccessTokenLifespanForImplicitFlow = accessTokenLifespanForImplicitFlow,
                SsoSessionIdleTimeout = ssoSessionIdleTimeout,
                SsoSessionMaxLifespan = ssoSessionMaxLifespan,
                SsoSessionIdleTimeoutRememberMe = ssoSessionIdleTimeoutRememberMe,
                SsoSessionMaxLifespanRememberMe = ssoSessionMaxLifespanRememberMe,
                OfflineSessionIdleTimeout = offlineSessionIdleTimeout,
                OfflineSessionMaxLifespanEnabled = offlineSessionMaxLifespanEnabled,
                OfflineSessionMaxLifespan = offlineSessionMaxLifespan,
                ClientSessionIdleTimeout = clientSessionIdleTimeout,
                ClientSessionMaxLifespan = clientSessionMaxLifespan,
                ClientOfflineSessionIdleTimeout = clientOfflineSessionIdleTimeout,
                ClientOfflineSessionMaxLifespan = clientOfflineSessionMaxLifespan,
                AccessCodeLifespan = accessCodeLifespan,
                AccessCodeLifespanUserAction = accessCodeLifespanUserAction,
                AccessCodeLifespanLogin = accessCodeLifespanLogin,
                ActionTokenGeneratedByAdminLifespan = actionTokenGeneratedByAdminLifespan,
                ActionTokenGeneratedByUserLifespan = actionTokenGeneratedByUserLifespan,
                Oauth2DeviceCodeLifespan = oauth2DeviceCodeLifespan,
                Oauth2DevicePollingInterval = oauth2DevicePollingInterval,
                Enabled = enabled,
                SslRequired = sslRequired,
                RegistrationAllowed = registrationAllowed,
                RegistrationEmailAsUsername = registrationEmailAsUsername,
                RememberMe = rememberMe,
                VerifyEmail = verifyEmail,
                LoginWithEmailAllowed = loginWithEmailAllowed,
                DuplicateEmailsAllowed = duplicateEmailsAllowed,
                ResetPasswordAllowed = resetPasswordAllowed,
                EditUsernameAllowed = editUsernameAllowed,
                BruteForceProtected = bruteForceProtected,
                PermanentLockout = permanentLockout,
                MaxTemporaryLockouts = maxTemporaryLockouts,
                BruteForceStrategy = bruteForceStrategy,
                MaxFailureWaitSeconds = maxFailureWaitSeconds,
                MinimumQuickLoginWaitSeconds = minimumQuickLoginWaitSeconds,
                WaitIncrementSeconds = waitIncrementSeconds,
                QuickLoginCheckMilliSeconds = quickLoginCheckMilliSeconds,
                MaxDeltaTimeSeconds = maxDeltaTimeSeconds,
                FailureFactor = failureFactor,
                MaxSecondaryAuthFailures = maxSecondaryAuthFailures,
                Roles = roles,
                Groups = groups,
                DefaultRole = defaultRole,
                AdminPermissionsClient = adminPermissionsClient,
                DefaultGroups = defaultGroups,
                PasswordPolicy = passwordPolicy,
                OtpPolicyType = otpPolicyType,
                OtpPolicyAlgorithm = otpPolicyAlgorithm,
                OtpPolicyInitialCounter = otpPolicyInitialCounter,
                OtpPolicyDigits = otpPolicyDigits,
                OtpPolicyLookAheadWindow = otpPolicyLookAheadWindow,
                OtpPolicyPeriod = otpPolicyPeriod,
                OtpPolicyCodeReusable = otpPolicyCodeReusable,
                OtpSupportedApplications = otpSupportedApplications,
                LocalizationTexts = localizationTexts,
                WebAuthnPolicyRpEntityName = webAuthnPolicyRpEntityName,
                WebAuthnPolicySignatureAlgorithms = webAuthnPolicySignatureAlgorithms,
                WebAuthnPolicyRpId = webAuthnPolicyRpId,
                WebAuthnPolicyAttestationConveyancePreference = webAuthnPolicyAttestationConveyancePreference,
                WebAuthnPolicyAuthenticatorAttachment = webAuthnPolicyAuthenticatorAttachment,
                WebAuthnPolicyRequireResidentKey = webAuthnPolicyRequireResidentKey,
                WebAuthnPolicyResidentKey = webAuthnPolicyResidentKey,
                WebAuthnPolicyUserVerificationRequirement = webAuthnPolicyUserVerificationRequirement,
                WebAuthnPolicyCreateTimeout = webAuthnPolicyCreateTimeout,
                WebAuthnPolicyAvoidSameAuthenticatorRegister = webAuthnPolicyAvoidSameAuthenticatorRegister,
                WebAuthnPolicyAcceptableAaguids = webAuthnPolicyAcceptableAaguids,
                WebAuthnPolicyExtraOrigins = webAuthnPolicyExtraOrigins,
                WebAuthnPolicyPasswordlessRpEntityName = webAuthnPolicyPasswordlessRpEntityName,
                WebAuthnPolicyPasswordlessSignatureAlgorithms = webAuthnPolicyPasswordlessSignatureAlgorithms,
                WebAuthnPolicyPasswordlessRpId = webAuthnPolicyPasswordlessRpId,
                WebAuthnPolicyPasswordlessAttestationConveyancePreference = webAuthnPolicyPasswordlessAttestationConveyancePreference,
                WebAuthnPolicyPasswordlessAuthenticatorAttachment = webAuthnPolicyPasswordlessAuthenticatorAttachment,
                WebAuthnPolicyPasswordlessRequireResidentKey = webAuthnPolicyPasswordlessRequireResidentKey,
                WebAuthnPolicyPasswordlessResidentKey = webAuthnPolicyPasswordlessResidentKey,
                WebAuthnPolicyPasswordlessUserVerificationRequirement = webAuthnPolicyPasswordlessUserVerificationRequirement,
                WebAuthnPolicyPasswordlessCreateTimeout = webAuthnPolicyPasswordlessCreateTimeout,
                WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister = webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister,
                WebAuthnPolicyPasswordlessAcceptableAaguids = webAuthnPolicyPasswordlessAcceptableAaguids,
                WebAuthnPolicyPasswordlessExtraOrigins = webAuthnPolicyPasswordlessExtraOrigins,
                WebAuthnPolicyPasswordlessPasskeysEnabled = webAuthnPolicyPasswordlessPasskeysEnabled,
                WebAuthnPolicyPasswordlessMediation = webAuthnPolicyPasswordlessMediation,
                ClientProfiles = clientProfiles,
                ClientPolicies = clientPolicies,
                Users = users,
                FederatedUsers = federatedUsers,
                ScopeMappings = scopeMappings,
                ClientScopeMappings = clientScopeMappings,
                Clients = clients,
                ClientScopes = clientScopes,
                DefaultDefaultClientScopes = defaultDefaultClientScopes,
                DefaultOptionalClientScopes = defaultOptionalClientScopes,
                BrowserSecurityHeaders = browserSecurityHeaders,
                SmtpServer = smtpServer,
                UserFederationProviders = userFederationProviders,
                UserFederationMappers = userFederationMappers,
                LoginTheme = loginTheme,
                AccountTheme = accountTheme,
                AdminTheme = adminTheme,
                EmailTheme = emailTheme,
                EventsEnabled = eventsEnabled,
                EventsExpiration = eventsExpiration,
                EventsListeners = eventsListeners,
                EnabledEventTypes = enabledEventTypes,
                AdminEventsEnabled = adminEventsEnabled,
                AdminEventsDetailsEnabled = adminEventsDetailsEnabled,
                IdentityProviders = identityProviders,
                IdentityProviderMappers = identityProviderMappers,
                ProtocolMappers = protocolMappers,
                Components = components,
                InternationalizationEnabled = internationalizationEnabled,
                SupportedLocales = supportedLocales,
                DefaultLocale = defaultLocale,
                AuthenticationFlows = authenticationFlows,
                AuthenticatorConfig = authenticatorConfig,
                RequiredActions = requiredActions,
                BrowserFlow = browserFlow,
                RegistrationFlow = registrationFlow,
                DirectGrantFlow = directGrantFlow,
                ResetCredentialsFlow = resetCredentialsFlow,
                ClientAuthenticationFlow = clientAuthenticationFlow,
                DockerAuthenticationFlow = dockerAuthenticationFlow,
                FirstBrokerLoginFlow = firstBrokerLoginFlow,
                Attributes = attributes,
                KeycloakVersion = keycloakVersion,
                UserManagedAccessAllowed = userManagedAccessAllowed,
                OrganizationsEnabled = organizationsEnabled,
                Organizations = organizations,
                VerifiableCredentialsEnabled = verifiableCredentialsEnabled,
                AdminPermissionsEnabled = adminPermissionsEnabled,
                ScimApiEnabled = scimApiEnabled,
            };

            await PutAdminRealmsByRealmAsync(
                realm: realm,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}