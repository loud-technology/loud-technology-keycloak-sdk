#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get users Returns a stream of users, filtered according to query parameters.<br/>
        /// Returns a stream of users. Note that the 'credentials' field in the returned UserRepresentation objects is typically not populated for performance reasons. If specific credential metadata is required, use the dedicated 'GET /admin/realms/{realm}/users/{user-id}/credentials' endpoint.
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled"></param>
        /// <param name="exact"></param>
        /// <param name="first"></param>
        /// <param name="firstName"></param>
        /// <param name="idpAlias"></param>
        /// <param name="idpUserId"></param>
        /// <param name="lastName"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>> GetAdminRealmsByRealmUsersAsync(
            string realm,
            bool? briefRepresentation = default,
            string? createdAfter = default,
            string? createdBefore = default,
            string? email = default,
            bool? emailVerified = default,
            bool? enabled = default,
            bool? exact = default,
            int? first = default,
            string? firstName = default,
            string? idpAlias = default,
            string? idpUserId = default,
            string? lastName = default,
            int? max = default,
            string? q = default,
            string? search = default,
            string? username = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users Returns a stream of users, filtered according to query parameters.<br/>
        /// Returns a stream of users. Note that the 'credentials' field in the returned UserRepresentation objects is typically not populated for performance reasons. If specific credential metadata is required, use the dedicated 'GET /admin/realms/{realm}/users/{user-id}/credentials' endpoint.
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled"></param>
        /// <param name="exact"></param>
        /// <param name="first"></param>
        /// <param name="firstName"></param>
        /// <param name="idpAlias"></param>
        /// <param name="idpUserId"></param>
        /// <param name="lastName"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>>> GetAdminRealmsByRealmUsersAsResponseAsync(
            string realm,
            bool? briefRepresentation = default,
            string? createdAfter = default,
            string? createdBefore = default,
            string? email = default,
            bool? emailVerified = default,
            bool? enabled = default,
            bool? exact = default,
            int? first = default,
            string? firstName = default,
            string? idpAlias = default,
            string? idpUserId = default,
            string? lastName = default,
            int? max = default,
            string? q = default,
            string? search = default,
            string? username = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}