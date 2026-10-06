#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IScopeMappingsClient
    {
        /// <summary>
        /// Get the roles associated with a client's scope Returns roles for the client.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="client"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsClientsByClientAsync(
            string realm,
            string clientScopeId,
            string client,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the roles associated with a client's scope Returns roles for the client.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="client"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsClientsByClientAsResponseAsync(
            string realm,
            string clientScopeId,
            string client,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}