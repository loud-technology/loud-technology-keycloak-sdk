#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Update group, ignores subgroups.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmGroupsByGroupIdAsync(
            string realm,
            string groupId,

            global::Loud.Technology.Keycloak.Sdk.GroupRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update group, ignores subgroups.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmGroupsByGroupIdAsResponseAsync(
            string realm,
            string groupId,

            global::Loud.Technology.Keycloak.Sdk.GroupRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update group, ignores subgroups.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="groupId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="path"></param>
        /// <param name="parentId"></param>
        /// <param name="subGroupCount"></param>
        /// <param name="subGroups"></param>
        /// <param name="attributes"></param>
        /// <param name="realmRoles"></param>
        /// <param name="clientRoles"></param>
        /// <param name="access"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmGroupsByGroupIdAsync(
            string realm,
            string groupId,
            string? id = default,
            string? name = default,
            string? description = default,
            string? path = default,
            string? parentId = default,
            long? subGroupCount = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? subGroups = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes = default,
            global::System.Collections.Generic.IList<string>? realmRoles = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? clientRoles = default,
            global::System.Collections.Generic.Dictionary<string, bool>? access = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}