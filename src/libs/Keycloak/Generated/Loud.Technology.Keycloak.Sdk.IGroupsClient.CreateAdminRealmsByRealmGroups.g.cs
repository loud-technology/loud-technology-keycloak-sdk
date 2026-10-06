#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// create or add a top level realm groupSet or create child.<br/>
        /// This will update the group and set the parent if it exists. Create it and set the parent if the group doesn’t exist.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmGroupsAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.GroupRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create or add a top level realm groupSet or create child.<br/>
        /// This will update the group and set the parent if it exists. Create it and set the parent if the group doesn’t exist.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmGroupsAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.GroupRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create or add a top level realm groupSet or create child.<br/>
        /// This will update the group and set the parent if it exists. Create it and set the parent if the group doesn’t exist.
        /// </summary>
        /// <param name="realm"></param>
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
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmGroupsAsync(
            string realm,
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