#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Removes the identity provider with the specified alias from the organization<br/>
        /// Breaks the association between the identity provider and the organization. The provider itself is not deleted. If no provider is found, or if it is not currently associated with the org, an error response is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsync(
            string alias,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes the identity provider with the specified alias from the organization<br/>
        /// Breaks the association between the identity provider and the organization. The provider itself is not deleted. If no provider is found, or if it is not currently associated with the org, an error response is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsResponseAsync(
            string alias,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}