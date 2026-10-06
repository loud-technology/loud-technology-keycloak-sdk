#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientRoleMappingsClient
    {
        /// <summary>
        /// Get available client-level roles that can be mapped to the user or group
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmUsersByUserIdRoleMappingsClientsByClientIdAvailableAsync(
            string realm,
            string userId,
            string clientId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get available client-level roles that can be mapped to the user or group
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmUsersByUserIdRoleMappingsClientsByClientIdAvailableAsResponseAsync(
            string realm,
            string userId,
            string clientId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}