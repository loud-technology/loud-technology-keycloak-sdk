#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Get the identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation> GetAdminRealmsByRealmIdentityProviderInstancesByAliasAsync(
            string realm,
            string alias,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>> GetAdminRealmsByRealmIdentityProviderInstancesByAliasAsResponseAsync(
            string realm,
            string alias,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}