#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientRoleMappingsClient
    {
        /// <summary>
        /// Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmGroupsByGroupIdRoleMappingsClientsByClientIdCompositeAsync(
            string realm,
            string groupId,
            string clientId,
            bool? briefRepresentation = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmGroupsByGroupIdRoleMappingsClientsByClientIdCompositeAsResponseAsync(
            string realm,
            string groupId,
            string clientId,
            bool? briefRepresentation = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}