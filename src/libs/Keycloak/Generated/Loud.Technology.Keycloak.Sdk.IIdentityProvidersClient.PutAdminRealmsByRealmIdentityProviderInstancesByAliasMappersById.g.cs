#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Update a mapper for the identity provider
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmIdentityProviderInstancesByAliasMappersByIdAsync(
            string id,
            string realm,
            string alias,

            global::Loud.Technology.Keycloak.Sdk.IdentityProviderMapperRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a mapper for the identity provider
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmIdentityProviderInstancesByAliasMappersByIdAsResponseAsync(
            string id,
            string realm,
            string alias,

            global::Loud.Technology.Keycloak.Sdk.IdentityProviderMapperRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a mapper for the identity provider
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="identityProviderAlias"></param>
        /// <param name="identityProviderMapper"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmIdentityProviderInstancesByAliasMappersByIdAsync(
            string id,
            string realm,
            string alias,
            string? requestId = default,
            string? name = default,
            string? identityProviderAlias = default,
            string? identityProviderMapper = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}