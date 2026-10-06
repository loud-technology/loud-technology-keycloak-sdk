#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Send an email to the user with a link they can click to execute particular actions.<br/>
        /// An email contains a link the user can click to perform a set of required actions. The redirectUri and clientId parameters are optional. If no redirect is given, then there will be no link back to click after actions have completed. Redirect uri must be a valid uri for the particular clientId.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="lifespan"></param>
        /// <param name="redirectUri"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmUsersByUserIdExecuteActionsEmailAsync(
            string realm,
            string userId,

            global::System.Collections.Generic.IList<string> request,
            string? clientId = default,
            int? lifespan = default,
            string? redirectUri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an email to the user with a link they can click to execute particular actions.<br/>
        /// An email contains a link the user can click to perform a set of required actions. The redirectUri and clientId parameters are optional. If no redirect is given, then there will be no link back to click after actions have completed. Redirect uri must be a valid uri for the particular clientId.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="lifespan"></param>
        /// <param name="redirectUri"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmUsersByUserIdExecuteActionsEmailAsResponseAsync(
            string realm,
            string userId,

            global::System.Collections.Generic.IList<string> request,
            string? clientId = default,
            int? lifespan = default,
            string? redirectUri = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}