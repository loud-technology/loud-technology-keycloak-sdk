#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.ManagementPermissionReference> PutAdminRealmsByRealmRolesByRoleNameManagementPermissionsAsync(
            string roleName,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.ManagementPermissionReference request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.ManagementPermissionReference>> PutAdminRealmsByRealmRolesByRoleNameManagementPermissionsAsResponseAsync(
            string roleName,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.ManagementPermissionReference request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="enabled"></param>
        /// <param name="resource"></param>
        /// <param name="scopePermissions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.ManagementPermissionReference> PutAdminRealmsByRealmRolesByRoleNameManagementPermissionsAsync(
            string roleName,
            string realm,
            bool? enabled = default,
            string? resource = default,
            global::System.Collections.Generic.Dictionary<string, string>? scopePermissions = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}