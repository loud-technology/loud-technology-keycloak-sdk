#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization group representation
        /// </summary>
        /// <param name="subGroupsCount">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdAsync(
            string realm,
            string orgId,
            string groupId,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization group representation
        /// </summary>
        /// <param name="subGroupsCount">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdAsResponseAsync(
            string realm,
            string orgId,
            string groupId,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}