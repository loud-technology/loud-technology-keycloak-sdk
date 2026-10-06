#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Updates the per-association config for the identity provider linked to the organization<br/>
        /// Updates the autoMembership and membershipType settings for the link between the organization and the identity provider with the given alias. If the provider is not linked to the organization, a NOT_FOUND error is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsync(
            string alias,
            string realm,
            string orgId,

            global::Loud.Technology.Keycloak.Sdk.OrganizationIdentityProviderLinkRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the per-association config for the identity provider linked to the organization<br/>
        /// Updates the autoMembership and membershipType settings for the link between the organization and the identity provider with the given alias. If the provider is not linked to the organization, a NOT_FOUND error is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsResponseAsync(
            string alias,
            string realm,
            string orgId,

            global::Loud.Technology.Keycloak.Sdk.OrganizationIdentityProviderLinkRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the per-association config for the identity provider linked to the organization<br/>
        /// Updates the autoMembership and membershipType settings for the link between the organization and the identity provider with the given alias. If the provider is not linked to the organization, a NOT_FOUND error is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="organizationId"></param>
        /// <param name="autoMembership"></param>
        /// <param name="membershipType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsync(
            string alias,
            string realm,
            string orgId,
            string? organizationId = default,
            bool? autoMembership = default,
            string? membershipType = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}