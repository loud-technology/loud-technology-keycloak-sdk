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
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientsByClientUuidAuthzResourceServerAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ResourceServerRepresentation request,
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmClientsByClientUuidAuthzResourceServerAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ResourceServerRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="allowRemoteResourceManagement"></param>
        /// <param name="policyEnforcementMode"></param>
        /// <param name="resources"></param>
        /// <param name="policies"></param>
        /// <param name="scopes"></param>
        /// <param name="decisionStrategy"></param>
        /// <param name="authorizationSchema"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientsByClientUuidAuthzResourceServerAsync(
            string realm,
            string clientUuid,
            string? id = default,
            string? clientId = default,
            string? name = default,
            bool? allowRemoteResourceManagement = default,
            global::Loud.Technology.Keycloak.Sdk.PolicyEnforcementMode? policyEnforcementMode = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resources = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation>? policies = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopes = default,
            global::Loud.Technology.Keycloak.Sdk.DecisionStrategy? decisionStrategy = default,
            global::Loud.Technology.Keycloak.Sdk.AuthorizationSchema? authorizationSchema = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}