#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns organization groups for the identity provider<br/>
        /// Returns organization groups that can be used in identity provider mappers. Only returns groups if the identity provider is associated with the organization.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="exact">
        /// Default Value: false
        /// </param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasGroupsAsync(
            string alias,
            string realm,
            string orgId,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? q = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns organization groups for the identity provider<br/>
        /// Returns organization groups that can be used in identity provider mappers. Only returns groups if the identity provider is associated with the organization.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="exact">
        /// Default Value: false
        /// </param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>>> GetAdminRealmsByRealmOrganizationsByOrgIdIdentityProvidersByAliasGroupsAsResponseAsync(
            string alias,
            string realm,
            string orgId,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? q = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}