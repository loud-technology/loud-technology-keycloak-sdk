#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientRoleMappingsClient
    {
        /// <summary>
        /// Delete client-level roles from user or group role mapping
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdRoleMappingsClientsByClientIdAsync(
            string realm,
            string orgId,
            string groupId,
            string clientId,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete client-level roles from user or group role mapping
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdRoleMappingsClientsByClientIdAsResponseAsync(
            string realm,
            string orgId,
            string groupId,
            string clientId,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}