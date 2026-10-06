#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IScopeMappingsClient
    {
        /// <summary>
        /// Add a set of realm-level roles to the client's scope
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientScopesByClientScopeIdScopeMappingsRealmAsync(
            string realm,
            string clientScopeId,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a set of realm-level roles to the client's scope
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmClientScopesByClientScopeIdScopeMappingsRealmAsResponseAsync(
            string realm,
            string clientScopeId,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}