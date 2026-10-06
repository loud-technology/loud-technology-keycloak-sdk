#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="first"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmClientsByClientUuidRolesByRoleNameGroupsAsync(
            string roleName,
            string realm,
            string clientUuid,
            bool? briefRepresentation = default,
            int? first = default,
            int? max = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="first"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidRolesByRoleNameGroupsAsResponseAsync(
            string roleName,
            string realm,
            string clientUuid,
            bool? briefRepresentation = default,
            int? first = default,
            int? max = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}