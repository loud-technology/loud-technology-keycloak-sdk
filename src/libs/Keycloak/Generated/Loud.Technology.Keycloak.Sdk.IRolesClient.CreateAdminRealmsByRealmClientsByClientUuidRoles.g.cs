#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Create a new role for the realm or client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientsByClientUuidRolesAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.RoleRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new role for the realm or client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmClientsByClientUuidRolesAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.RoleRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new role for the realm or client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="composite"></param>
        /// <param name="composites"></param>
        /// <param name="clientRole"></param>
        /// <param name="containerId"></param>
        /// <param name="attributes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientsByClientUuidRolesAsync(
            string realm,
            string clientUuid,
            string? id = default,
            string? name = default,
            string? description = default,
            bool? composite = default,
            global::Loud.Technology.Keycloak.Sdk.Composites? composites = default,
            bool? clientRole = default,
            string? containerId = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}