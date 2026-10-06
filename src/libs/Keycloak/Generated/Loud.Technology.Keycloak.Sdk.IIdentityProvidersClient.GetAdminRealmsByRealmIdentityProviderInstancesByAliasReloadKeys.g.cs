#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Reaload keys for the identity provider if the provider supports it, "true" is returned if reload was performed, "false" if not.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> GetAdminRealmsByRealmIdentityProviderInstancesByAliasReloadKeysAsync(
            string realm,
            string alias,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reaload keys for the identity provider if the provider supports it, "true" is returned if reload was performed, "false" if not.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<bool>> GetAdminRealmsByRealmIdentityProviderInstancesByAliasReloadKeysAsResponseAsync(
            string realm,
            string alias,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}