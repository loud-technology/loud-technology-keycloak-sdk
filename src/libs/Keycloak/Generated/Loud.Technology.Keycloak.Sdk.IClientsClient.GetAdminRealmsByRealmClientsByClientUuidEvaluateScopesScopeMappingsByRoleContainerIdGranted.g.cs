#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.<br/>
        /// This contains scope mappings, which this client has directly, as well as scope mappings, which are granted to all client scopes, which are linked with this client.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="roleContainerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesScopeMappingsByRoleContainerIdGrantedAsync(
            string realm,
            string clientUuid,
            string roleContainerId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.<br/>
        /// This contains scope mappings, which this client has directly, as well as scope mappings, which are granted to all client scopes, which are linked with this client.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="roleContainerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesScopeMappingsByRoleContainerIdGrantedAsResponseAsync(
            string realm,
            string clientUuid,
            string roleContainerId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}