#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Return credential types, which are provided by the user storage where user is stored.<br/>
        /// Returned values can contain for example "password", "otp" etc. This will always return empty list for "local" users, which are not backed by any user storage
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetAdminRealmsByRealmUsersByUserIdConfiguredUserStorageCredentialTypesAsync(
            string realm,
            string userId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return credential types, which are provided by the user storage where user is stored.<br/>
        /// Returned values can contain for example "password", "otp" etc. This will always return empty list for "local" users, which are not backed by any user storage
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<string>>> GetAdminRealmsByRealmUsersByUserIdConfiguredUserStorageCredentialTypesAsResponseAsync(
            string realm,
            string userId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}