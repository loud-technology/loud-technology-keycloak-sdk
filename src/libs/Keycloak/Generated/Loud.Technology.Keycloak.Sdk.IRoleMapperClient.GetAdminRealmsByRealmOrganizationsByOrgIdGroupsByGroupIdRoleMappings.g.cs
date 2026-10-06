#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRoleMapperClient
    {
        /// <summary>
        /// Get role mappings
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.MappingsRepresentation> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdRoleMappingsAsync(
            string realm,
            string orgId,
            string groupId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get role mappings
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.MappingsRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdRoleMappingsAsResponseAsync(
            string realm,
            string orgId,
            string groupId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}