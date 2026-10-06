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
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerScopeAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation request,
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerScopeAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="iconUri"></param>
        /// <param name="policies"></param>
        /// <param name="resources"></param>
        /// <param name="displayName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerScopeAsync(
            string realm,
            string clientUuid,
            string? id = default,
            string? name = default,
            string? iconUri = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation>? policies = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resources = default,
            string? displayName = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}