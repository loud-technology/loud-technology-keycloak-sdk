#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientInitialAccessClient
    {
        /// <summary>
        /// Create a new initial access token.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.ClientInitialAccessCreatePresentation> CreateAdminRealmsByRealmClientsInitialAccessAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.ClientInitialAccessCreatePresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new initial access token.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.ClientInitialAccessCreatePresentation>> CreateAdminRealmsByRealmClientsInitialAccessAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.ClientInitialAccessCreatePresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new initial access token.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="expiration"></param>
        /// <param name="count"></param>
        /// <param name="webOrigins"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.ClientInitialAccessCreatePresentation> CreateAdminRealmsByRealmClientsInitialAccessAsync(
            string realm,
            int? expiration = default,
            int? count = default,
            global::System.Collections.Generic.IList<string>? webOrigins = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}