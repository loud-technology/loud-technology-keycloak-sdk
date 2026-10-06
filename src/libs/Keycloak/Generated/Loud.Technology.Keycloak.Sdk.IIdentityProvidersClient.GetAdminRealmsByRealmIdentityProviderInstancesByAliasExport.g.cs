#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Export public broker configuration for identity provider
        /// </summary>
        /// <param name="format"></param>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAdminRealmsByRealmIdentityProviderInstancesByAliasExportAsync(
            string realm,
            string alias,
            string? format = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export public broker configuration for identity provider
        /// </summary>
        /// <param name="format"></param>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> GetAdminRealmsByRealmIdentityProviderInstancesByAliasExportAsResponseAsync(
            string realm,
            string alias,
            string? format = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}