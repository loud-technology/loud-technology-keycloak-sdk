#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get members of this organization group<br/>
        /// Returns a paginated list of organization members that belong to this group
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdMembersAsync(
            string realm,
            string orgId,
            string groupId,
            bool? briefRepresentation = default,
            int? first = default,
            int? max = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get members of this organization group<br/>
        /// Returns a paginated list of organization members that belong to this group
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>>> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdMembersAsResponseAsync(
            string realm,
            string orgId,
            string groupId,
            bool? briefRepresentation = default,
            int? first = default,
            int? max = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}