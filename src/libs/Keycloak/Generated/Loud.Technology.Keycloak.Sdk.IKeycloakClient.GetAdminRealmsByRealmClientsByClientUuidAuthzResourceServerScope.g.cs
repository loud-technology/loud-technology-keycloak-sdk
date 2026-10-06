#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IKeycloakClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="name"></param>
        /// <param name="scopeId"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerScopeAsync(
            string realm,
            string clientUuid,
            int? first = default,
            int? max = default,
            string? name = default,
            string? scopeId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="name"></param>
        /// <param name="scopeId"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerScopeAsResponseAsync(
            string realm,
            string clientUuid,
            int? first = default,
            int? max = default,
            string? name = default,
            string? scopeId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}