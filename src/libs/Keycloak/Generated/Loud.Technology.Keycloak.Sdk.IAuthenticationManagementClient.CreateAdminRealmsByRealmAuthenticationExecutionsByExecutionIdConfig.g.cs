#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAuthenticationManagementClient
    {
        /// <summary>
        /// Update execution with new configuration
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmAuthenticationExecutionsByExecutionIdConfigAsync(
            string executionId,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticatorConfigRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update execution with new configuration
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmAuthenticationExecutionsByExecutionIdConfigAsResponseAsync(
            string executionId,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticatorConfigRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update execution with new configuration
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="alias"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmAuthenticationExecutionsByExecutionIdConfigAsync(
            string executionId,
            string realm,
            string? id = default,
            string? alias = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}