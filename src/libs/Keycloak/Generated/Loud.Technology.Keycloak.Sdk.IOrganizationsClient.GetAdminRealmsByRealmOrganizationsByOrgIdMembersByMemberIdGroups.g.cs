#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns the organization group memberships for a member with the specified id<br/>
        /// Searches for auser with the given id. If one is found, and is currently a member of the organization, returns the groups from the organizationwhere the user is member of. Otherwise, an error response with status NOT_FOUND is returned
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdGroupsAsync(
            string memberId,
            string realm,
            string orgId,
            bool? briefRepresentation = default,
            int? first = default,
            int? max = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the organization group memberships for a member with the specified id<br/>
        /// Searches for auser with the given id. If one is found, and is currently a member of the organization, returns the groups from the organizationwhere the user is member of. Otherwise, an error response with status NOT_FOUND is returned
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>>> GetAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdGroupsAsResponseAsync(
            string memberId,
            string realm,
            string orgId,
            bool? briefRepresentation = default,
            int? first = default,
            int? max = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}