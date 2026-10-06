#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Invites an existing user or sends a registration link to a new user, based on the provided e-mail address.<br/>
        /// If the user with the given e-mail address exists, it sends an invitation link, otherwise it sends a registration link. The client_id query parameter is optional. If no client_id is provided, the account client is used. After accepting the invitation the user is redirected to the selected client's home URL; for the account client the organization redirect URL is used instead when configured.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserAsync(
            string realm,
            string orgId,

            global::Loud.Technology.Keycloak.Sdk.CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest request,
            string? clientId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invites an existing user or sends a registration link to a new user, based on the provided e-mail address.<br/>
        /// If the user with the given e-mail address exists, it sends an invitation link, otherwise it sends a registration link. The client_id query parameter is optional. If no client_id is provided, the account client is used. After accepting the invitation the user is redirected to the selected client's home URL; for the account client the organization redirect URL is used instead when configured.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserAsResponseAsync(
            string realm,
            string orgId,

            global::Loud.Technology.Keycloak.Sdk.CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest request,
            string? clientId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invites an existing user or sends a registration link to a new user, based on the provided e-mail address.<br/>
        /// If the user with the given e-mail address exists, it sends an invitation link, otherwise it sends a registration link. The client_id query parameter is optional. If no client_id is provided, the account client is used. After accepting the invitation the user is redirected to the selected client's home URL; for the account client the organization redirect URL is used instead when configured.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserAsync(
            string realm,
            string orgId,
            string? clientId = default,
            string? email = default,
            string? firstName = default,
            string? lastName = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}