#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Set the configuration for the user profile
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.UPConfig> PutAdminRealmsByRealmUsersProfileAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.UPConfig request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the configuration for the user profile
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.UPConfig>> PutAdminRealmsByRealmUsersProfileAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.UPConfig request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the configuration for the user profile
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="attributes"></param>
        /// <param name="groups"></param>
        /// <param name="unmanagedAttributePolicy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.UPConfig> PutAdminRealmsByRealmUsersProfileAsync(
            string realm,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UPAttribute>? attributes = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UPGroup>? groups = default,
            global::Loud.Technology.Keycloak.Sdk.UnmanagedAttributePolicy? unmanagedAttributePolicy = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}