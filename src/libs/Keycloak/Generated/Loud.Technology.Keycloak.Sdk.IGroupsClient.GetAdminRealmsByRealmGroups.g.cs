#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Get group hierarchy.  Only `name` and `id` are returned.  `subGroups` are only returned when using the `search` or `q` parameter. If none of these parameters is provided, the top-level groups are returned without `subGroups` being filled.
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="exact">
        /// Default Value: false
        /// </param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="populateHierarchy">
        /// Default Value: true
        /// </param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmGroupsAsync(
            string realm,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            bool? populateHierarchy = default,
            string? q = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get group hierarchy.  Only `name` and `id` are returned.  `subGroups` are only returned when using the `search` or `q` parameter. If none of these parameters is provided, the top-level groups are returned without `subGroups` being filled.
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="exact">
        /// Default Value: false
        /// </param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="populateHierarchy">
        /// Default Value: true
        /// </param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>>> GetAdminRealmsByRealmGroupsAsResponseAsync(
            string realm,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            bool? populateHierarchy = default,
            string? q = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}