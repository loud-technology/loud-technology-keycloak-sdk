#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        /// Get events Returns all events, or filters them based on URL query parameters listed here
        /// </summary>
        /// <param name="client"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="direction"></param>
        /// <param name="first"></param>
        /// <param name="ipAddress"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="user"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.EventRepresentation>> GetAdminRealmsByRealmEventsAsync(
            string realm,
            string? client = default,
            string? dateFrom = default,
            string? dateTo = default,
            string? direction = default,
            int? first = default,
            string? ipAddress = default,
            int? max = default,
            global::System.Collections.Generic.IList<string>? type = default,
            string? user = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get events Returns all events, or filters them based on URL query parameters listed here
        /// </summary>
        /// <param name="client"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="direction"></param>
        /// <param name="first"></param>
        /// <param name="ipAddress"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="user"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.EventRepresentation>>> GetAdminRealmsByRealmEventsAsResponseAsync(
            string realm,
            string? client = default,
            string? dateFrom = default,
            string? dateTo = default,
            string? direction = default,
            int? first = default,
            string? ipAddress = default,
            int? max = default,
            global::System.Collections.Generic.IList<string>? type = default,
            string? user = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}