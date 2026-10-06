#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        /// Get admin events Returns all admin events, or filters events based on URL query parameters listed here
        /// </summary>
        /// <param name="authClient"></param>
        /// <param name="authIpAddress"></param>
        /// <param name="authRealm"></param>
        /// <param name="authUser"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="direction"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="operationTypes"></param>
        /// <param name="resourcePath"></param>
        /// <param name="resourceTypes"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AdminEventRepresentation>> GetAdminRealmsByRealmAdminEventsAsync(
            string realm,
            string? authClient = default,
            string? authIpAddress = default,
            string? authRealm = default,
            string? authUser = default,
            string? dateFrom = default,
            string? dateTo = default,
            string? direction = default,
            int? first = default,
            int? max = default,
            global::System.Collections.Generic.IList<string>? operationTypes = default,
            string? resourcePath = default,
            global::System.Collections.Generic.IList<string>? resourceTypes = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get admin events Returns all admin events, or filters events based on URL query parameters listed here
        /// </summary>
        /// <param name="authClient"></param>
        /// <param name="authIpAddress"></param>
        /// <param name="authRealm"></param>
        /// <param name="authUser"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="direction"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="operationTypes"></param>
        /// <param name="resourcePath"></param>
        /// <param name="resourceTypes"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AdminEventRepresentation>>> GetAdminRealmsByRealmAdminEventsAsResponseAsync(
            string realm,
            string? authClient = default,
            string? authIpAddress = default,
            string? authRealm = default,
            string? authUser = default,
            string? dateFrom = default,
            string? dateTo = default,
            string? direction = default,
            int? first = default,
            int? max = default,
            global::System.Collections.Generic.IList<string>? operationTypes = default,
            string? resourcePath = default,
            global::System.Collections.Generic.IList<string>? resourceTypes = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}