#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAuthenticationManagementClient
    {
        /// <summary>
        /// Create a new authentication flow
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmAuthenticationFlowsAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticationFlowRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new authentication flow
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmAuthenticationFlowsAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticationFlowRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new authentication flow
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="alias"></param>
        /// <param name="description"></param>
        /// <param name="providerId"></param>
        /// <param name="topLevel"></param>
        /// <param name="builtIn"></param>
        /// <param name="authenticationExecutions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmAuthenticationFlowsAsync(
            string realm,
            string? id = default,
            string? alias = default,
            string? description = default,
            string? providerId = default,
            bool? topLevel = default,
            bool? builtIn = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionExportRepresentation>? authenticationExecutions = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}