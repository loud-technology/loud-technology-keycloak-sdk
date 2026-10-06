#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAuthenticationManagementClient
    {
        /// <summary>
        /// Add new authentication execution
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmAuthenticationExecutionsAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add new authentication execution
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmAuthenticationExecutionsAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add new authentication execution
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="authenticatorConfig"></param>
        /// <param name="authenticator"></param>
        /// <param name="authenticatorFlow"></param>
        /// <param name="requirement"></param>
        /// <param name="priority"></param>
        /// <param name="id"></param>
        /// <param name="flowId"></param>
        /// <param name="parentFlow"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmAuthenticationExecutionsAsync(
            string realm,
            string? authenticatorConfig = default,
            string? authenticator = default,
            bool? authenticatorFlow = default,
            string? requirement = default,
            int? priority = default,
            string? id = default,
            string? flowId = default,
            string? parentFlow = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}