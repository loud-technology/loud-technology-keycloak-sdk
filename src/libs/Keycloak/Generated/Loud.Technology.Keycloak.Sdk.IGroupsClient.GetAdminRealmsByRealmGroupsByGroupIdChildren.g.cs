#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Return a paginated list of subgroups that have a parent group corresponding to the group on the URL
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: false
        /// </param>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmGroupsByGroupIdChildrenAsync(
            string realm,
            string groupId,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return a paginated list of subgroups that have a parent group corresponding to the group on the URL
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: false
        /// </param>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>>> GetAdminRealmsByRealmGroupsByGroupIdChildrenAsResponseAsync(
            string realm,
            string groupId,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}