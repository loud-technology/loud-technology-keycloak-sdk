#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IKeycloakClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deep"></param>
        /// <param name="exactName"></param>
        /// <param name="first"></param>
        /// <param name="matchingUri"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="uri"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerResourceAsync(
            string realm,
            string clientUuid,
            string? id = default,
            bool? deep = default,
            bool? exactName = default,
            int? first = default,
            bool? matchingUri = default,
            int? max = default,
            string? name = default,
            string? owner = default,
            string? scope = default,
            string? type = default,
            string? uri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deep"></param>
        /// <param name="exactName"></param>
        /// <param name="first"></param>
        /// <param name="matchingUri"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="uri"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerResourceAsResponseAsync(
            string realm,
            string clientUuid,
            string? id = default,
            bool? deep = default,
            bool? exactName = default,
            int? first = default,
            bool? matchingUri = default,
            int? max = default,
            string? name = default,
            string? owner = default,
            string? scope = default,
            string? type = default,
            string? uri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}