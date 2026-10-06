#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Add a composite to the role
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientsByClientUuidRolesByRoleNameCompositesAsync(
            string roleName,
            string realm,
            string clientUuid,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a composite to the role
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmClientsByClientUuidRolesByRoleNameCompositesAsResponseAsync(
            string roleName,
            string realm,
            string clientUuid,

            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation> request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}