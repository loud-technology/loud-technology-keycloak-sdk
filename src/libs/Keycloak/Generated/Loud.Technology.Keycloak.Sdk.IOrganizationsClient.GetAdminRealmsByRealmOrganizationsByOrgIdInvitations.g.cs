#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get invitations for the organization
        /// </summary>
        /// <param name="email"></param>
        /// <param name="first"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationInvitationRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdInvitationsAsync(
            string realm,
            string orgId,
            string? email = default,
            int? first = default,
            string? firstName = default,
            string? lastName = default,
            int? max = default,
            string? search = default,
            string? status = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get invitations for the organization
        /// </summary>
        /// <param name="email"></param>
        /// <param name="first"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationInvitationRepresentation>>> GetAdminRealmsByRealmOrganizationsByOrgIdInvitationsAsResponseAsync(
            string realm,
            string orgId,
            string? email = default,
            int? first = default,
            string? firstName = default,
            string? lastName = default,
            int? max = default,
            string? search = default,
            string? status = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}