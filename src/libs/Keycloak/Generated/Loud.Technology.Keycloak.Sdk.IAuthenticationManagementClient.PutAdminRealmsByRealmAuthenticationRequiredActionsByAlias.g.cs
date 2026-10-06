#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAuthenticationManagementClient
    {
        /// <summary>
        /// Update required action
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmAuthenticationRequiredActionsByAliasAsync(
            string alias,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RequiredActionProviderRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update required action
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmAuthenticationRequiredActionsByAliasAsResponseAsync(
            string alias,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RequiredActionProviderRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update required action
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="realm"></param>
        /// <param name="requestAlias"></param>
        /// <param name="name"></param>
        /// <param name="providerId"></param>
        /// <param name="enabled"></param>
        /// <param name="defaultAction"></param>
        /// <param name="priority"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmAuthenticationRequiredActionsByAliasAsync(
            string alias,
            string realm,
            string? requestAlias = default,
            string? name = default,
            string? providerId = default,
            bool? enabled = default,
            bool? defaultAction = default,
            int? priority = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}