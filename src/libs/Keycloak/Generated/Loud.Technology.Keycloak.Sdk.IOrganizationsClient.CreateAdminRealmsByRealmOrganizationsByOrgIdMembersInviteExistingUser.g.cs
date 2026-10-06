#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Invites an existing user to the organization, using the specified user id
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteExistingUserAsync(
            string realm,
            string orgId,

            global::Loud.Technology.Keycloak.Sdk.CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteExistingUserRequest request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invites an existing user to the organization, using the specified user id
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteExistingUserAsResponseAsync(
            string realm,
            string orgId,

            global::Loud.Technology.Keycloak.Sdk.CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteExistingUserRequest request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invites an existing user to the organization, using the specified user id
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteExistingUserAsync(
            string realm,
            string orgId,
            string? id = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}