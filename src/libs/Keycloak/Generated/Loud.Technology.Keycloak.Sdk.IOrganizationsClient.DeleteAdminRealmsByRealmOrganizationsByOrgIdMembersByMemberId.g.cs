#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Removes the user with the specified id from the organization<br/>
        /// Breaks the association between the user and organization. The user itself is deleted in case the membership is managed, otherwise the user is not deleted. If no user is found, or if they are not a member of the organization, an error response is returned
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdAsync(
            string memberId,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes the user with the specified id from the organization<br/>
        /// Breaks the association between the user and organization. The user itself is deleted in case the membership is managed, otherwise the user is not deleted. If no user is found, or if they are not a member of the organization, an error response is returned
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdAsResponseAsync(
            string memberId,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}