#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IKeycloakClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerResourceAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerResourceAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="uris"></param>
        /// <param name="type"></param>
        /// <param name="scopes"></param>
        /// <param name="iconUri"></param>
        /// <param name="ownerManagedAccess"></param>
        /// <param name="displayName"></param>
        /// <param name="attributes"></param>
        /// <param name="scopesUma"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation> CreateAdminRealmsByRealmClientsByClientUuidAuthzResourceServerResourceAsync(
            string realm,
            string clientUuid,
            string? id = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? uris = default,
            string? type = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopes = default,
            string? iconUri = default,
            bool? ownerManagedAccess = default,
            string? displayName = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopesUma = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}