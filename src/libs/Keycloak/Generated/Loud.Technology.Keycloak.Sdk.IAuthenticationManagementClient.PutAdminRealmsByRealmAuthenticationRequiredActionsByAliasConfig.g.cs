#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAuthenticationManagementClient
    {
        /// <summary>
        /// Update RequiredAction configuration
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmAuthenticationRequiredActionsByAliasConfigAsync(
            string alias,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RequiredActionConfigRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update RequiredAction configuration
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmAuthenticationRequiredActionsByAliasConfigAsResponseAsync(
            string alias,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RequiredActionConfigRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update RequiredAction configuration
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmAuthenticationRequiredActionsByAliasConfigAsync(
            string alias,
            string realm,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}