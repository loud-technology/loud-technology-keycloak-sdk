#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns the organizations counts.
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="identityProvider"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<long> GetAdminRealmsByRealmOrganizationsCountAsync(
            string realm,
            bool? exact = default,
            string? identityProvider = default,
            string? q = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the organizations counts.
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="identityProvider"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<long>> GetAdminRealmsByRealmOrganizationsCountAsResponseAsync(
            string realm,
            bool? exact = default,
            string? identityProvider = default,
            string? q = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}