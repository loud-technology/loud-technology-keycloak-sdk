#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IScopeMappingsClient
    {
        /// <summary>
        /// Get effective client roles Returns the roles for the client that are associated with the client's scope.
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="client"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsClientsByClientCompositeAsync(
            string realm,
            string clientScopeId,
            string client,
            bool? briefRepresentation = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get effective client roles Returns the roles for the client that are associated with the client's scope.
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="client"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsClientsByClientCompositeAsResponseAsync(
            string realm,
            string clientScopeId,
            string client,
            bool? briefRepresentation = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}