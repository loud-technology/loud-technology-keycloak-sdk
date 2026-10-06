#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IKeycloakClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.PolicyEvaluationResponse> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionEvaluateAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.PolicyEvaluationRequest request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.PolicyEvaluationResponse>> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionEvaluateAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.PolicyEvaluationRequest request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="context"></param>
        /// <param name="resources"></param>
        /// <param name="resourceType"></param>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        /// <param name="roleIds"></param>
        /// <param name="entitlements"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.PolicyEvaluationResponse> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPermissionEvaluateAsync(
            string realm,
            string clientUuid,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? context = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resources = default,
            string? resourceType = default,
            string? clientId = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? roleIds = default,
            bool? entitlements = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}