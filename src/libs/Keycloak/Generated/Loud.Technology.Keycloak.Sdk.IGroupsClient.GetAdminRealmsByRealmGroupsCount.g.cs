#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Returns the groups counts.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="top">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, long>> GetAdminRealmsByRealmGroupsCountAsync(
            string realm,
            string? search = default,
            bool? top = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the groups counts.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="top">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, long>>> GetAdminRealmsByRealmGroupsCountAsResponseAsync(
            string realm,
            string? search = default,
            bool? top = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}