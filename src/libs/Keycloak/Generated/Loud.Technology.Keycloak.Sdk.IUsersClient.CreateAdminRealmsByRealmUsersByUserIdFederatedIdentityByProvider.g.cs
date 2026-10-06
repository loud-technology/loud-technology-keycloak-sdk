#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Add a social login provider to the user
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmUsersByUserIdFederatedIdentityByProviderAsync(
            string provider,
            string realm,
            string userId,

            global::Loud.Technology.Keycloak.Sdk.FederatedIdentityRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a social login provider to the user
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmUsersByUserIdFederatedIdentityByProviderAsResponseAsync(
            string provider,
            string realm,
            string userId,

            global::Loud.Technology.Keycloak.Sdk.FederatedIdentityRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a social login provider to the user
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="identityProvider"></param>
        /// <param name="requestUserId"></param>
        /// <param name="userName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmUsersByUserIdFederatedIdentityByProviderAsync(
            string provider,
            string realm,
            string userId,
            string? identityProvider = default,
            string? requestUserId = default,
            string? userName = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}