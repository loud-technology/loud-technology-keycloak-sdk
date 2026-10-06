#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns the identity provider associated with the organization that has the specified alias<br/>
        /// Searches for an identity provider with the given alias. If one is found and is associated with the organization, it is returned. Otherwise, an error response with status NOT_FOUND is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation> GetAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsync(
            string alias,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the identity provider associated with the organization that has the specified alias<br/>
        /// Searches for an identity provider with the given alias. If one is found and is associated with the organization, it is returned. Otherwise, an error response with status NOT_FOUND is returned
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasAsResponseAsync(
            string alias,
            string realm,
            string orgId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}