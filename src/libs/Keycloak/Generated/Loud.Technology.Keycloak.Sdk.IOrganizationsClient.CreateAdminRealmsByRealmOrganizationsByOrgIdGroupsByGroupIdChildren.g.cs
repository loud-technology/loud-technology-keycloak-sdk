#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create or move a subgroup<br/>
        /// Creates a new subgroup under this organization group. If the group representation includes an ID, moves the existing group to be a child of this group. If no ID is provided, creates a new subgroup.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdChildrenAsync(
            string realm,
            string orgId,
            string groupId,

            global::Loud.Technology.Keycloak.Sdk.GroupRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or move a subgroup<br/>
        /// Creates a new subgroup under this organization group. If the group representation includes an ID, moves the existing group to be a child of this group. If no ID is provided, creates a new subgroup.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdChildrenAsResponseAsync(
            string realm,
            string orgId,
            string groupId,

            global::Loud.Technology.Keycloak.Sdk.GroupRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or move a subgroup<br/>
        /// Creates a new subgroup under this organization group. If the group representation includes an ID, moves the existing group to be a child of this group. If no ID is provided, creates a new subgroup.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
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
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdChildrenAsync(
            string realm,
            string orgId,
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