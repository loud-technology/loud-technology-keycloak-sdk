#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Move a credential to a position behind another credential
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="newPreviousCredentialId"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmUsersByUserIdCredentialsByCredentialIdMoveAfterByNewPreviousCredentialIdAsync(
            string credentialId,
            string newPreviousCredentialId,
            string realm,
            string userId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move a credential to a position behind another credential
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="newPreviousCredentialId"></param>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmUsersByUserIdCredentialsByCredentialIdMoveAfterByNewPreviousCredentialIdAsResponseAsync(
            string credentialId,
            string newPreviousCredentialId,
            string realm,
            string userId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}