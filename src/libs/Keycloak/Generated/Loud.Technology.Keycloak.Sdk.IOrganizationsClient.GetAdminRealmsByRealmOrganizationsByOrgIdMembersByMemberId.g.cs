#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns the member of the organization with the specified id<br/>
        /// Searches for auser with the given id. If one is found, and is currently a member of the organization, returns it. Otherwise,an error response with status NOT_FOUND is returned
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation> GetAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdAsync(
            string memberId,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the member of the organization with the specified id<br/>
        /// Searches for auser with the given id. If one is found, and is currently a member of the organization, returns it. Otherwise,an error response with status NOT_FOUND is returned
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdAsResponseAsync(
            string memberId,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}