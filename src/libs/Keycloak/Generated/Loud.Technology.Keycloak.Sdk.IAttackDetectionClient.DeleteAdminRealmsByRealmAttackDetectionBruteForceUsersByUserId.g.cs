#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAttackDetectionClient
    {
        /// <summary>
        /// Clear any user login failures for the user This can release temporary disabled user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmAttackDetectionBruteForceUsersByUserIdAsync(
            string userId,
            string realm,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear any user login failures for the user This can release temporary disabled user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmAttackDetectionBruteForceUsersByUserIdAsResponseAsync(
            string userId,
            string realm,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}