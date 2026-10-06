#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Send an email to the user with a link they can click to reset their password.<br/>
        /// The redirectUri and clientId parameters are optional. The default for the redirect is the account client. This endpoint has been deprecated.  Please use the execute-actions-email passing a list with UPDATE_PASSWORD within it.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmUsersByUserIdResetPasswordEmailAsync(
            string realm,
            string userId,
            string? clientId = default,
            string? redirectUri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an email to the user with a link they can click to reset their password.<br/>
        /// The redirectUri and clientId parameters are optional. The default for the redirect is the account client. This endpoint has been deprecated.  Please use the execute-actions-email passing a list with UPDATE_PASSWORD within it.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmUsersByUserIdResetPasswordEmailAsResponseAsync(
            string realm,
            string userId,
            string? clientId = default,
            string? redirectUri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}