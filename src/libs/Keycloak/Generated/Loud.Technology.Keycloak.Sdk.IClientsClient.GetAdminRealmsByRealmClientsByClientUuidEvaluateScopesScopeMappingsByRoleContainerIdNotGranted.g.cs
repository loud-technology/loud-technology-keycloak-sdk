#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Get roles, which this client doesn't have scope for and can't have them in the accessToken issued for him.<br/>
        /// Defacto all the other roles of particular role container, which are not in {@link #getGrantedScopeMappings()}
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="roleContainerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesScopeMappingsByRoleContainerIdNotGrantedAsync(
            string realm,
            string clientUuid,
            string roleContainerId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get roles, which this client doesn't have scope for and can't have them in the accessToken issued for him.<br/>
        /// Defacto all the other roles of particular role container, which are not in {@link #getGrantedScopeMappings()}
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="roleContainerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesScopeMappingsByRoleContainerIdNotGrantedAsResponseAsync(
            string realm,
            string clientUuid,
            string roleContainerId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}