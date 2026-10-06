#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Creates a new organization
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new organization
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmOrganizationsAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new organization
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="alias"></param>
        /// <param name="enabled"></param>
        /// <param name="description"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="attributes"></param>
        /// <param name="domains"></param>
        /// <param name="members"></param>
        /// <param name="identityProviders"></param>
        /// <param name="groups"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsAsync(
            string realm,
            string? id = default,
            string? name = default,
            string? alias = default,
            bool? enabled = default,
            string? description = default,
            string? redirectUrl = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationDomainRepresentation>? domains = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>? members = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>? identityProviders = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? groups = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}