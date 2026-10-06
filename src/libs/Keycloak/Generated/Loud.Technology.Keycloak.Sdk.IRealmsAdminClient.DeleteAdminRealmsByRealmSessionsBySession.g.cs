#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        /// Remove a specific user session.<br/>
        /// Any client that has an admin url will also be told to invalidate this particular session.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="isOffline">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmSessionsBySessionAsync(
            string session,
            string realm,
            bool? isOffline = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a specific user session.<br/>
        /// Any client that has an admin url will also be told to invalidate this particular session.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="isOffline">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmSessionsBySessionAsResponseAsync(
            string session,
            string realm,
            bool? isOffline = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}