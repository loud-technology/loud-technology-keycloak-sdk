#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IScopeMappingsClient
    {
        /// <summary>
        /// Remove client-level roles from the client's scope.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsClientsByClientAsync(
            string realm,
            string clientScopeId,
            string client,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove client-level roles from the client's scope.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsClientsByClientAsResponseAsync(
            string realm,
            string clientScopeId,
            string client,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}