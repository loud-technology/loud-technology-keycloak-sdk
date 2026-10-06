#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Send an email-verification email to the user An email contains a link the user can click to verify their email address.<br/>
        /// The redirectUri, clientId and lifespan parameters are optional. The default for the redirect is the account client. The default for the lifespan is 12 hours
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="lifespan"></param>
        /// <param name="redirectUri"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmUsersByUserIdSendVerifyEmailAsync(
            string realm,
            string userId,
            string? clientId = default,
            int? lifespan = default,
            string? redirectUri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an email-verification email to the user An email contains a link the user can click to verify their email address.<br/>
        /// The redirectUri, clientId and lifespan parameters are optional. The default for the redirect is the account client. The default for the lifespan is 12 hours
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="lifespan"></param>
        /// <param name="redirectUri"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmUsersByUserIdSendVerifyEmailAsResponseAsync(
            string realm,
            string userId,
            string? clientId = default,
            int? lifespan = default,
            string? redirectUri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}