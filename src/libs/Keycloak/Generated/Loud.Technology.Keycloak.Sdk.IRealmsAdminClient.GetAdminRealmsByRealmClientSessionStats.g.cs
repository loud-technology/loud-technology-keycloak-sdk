#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        /// Get client session stats Returns a JSON map.<br/>
        /// The key is the client id, the value is the number of sessions that currently are active with that client. Only clients that actually have a session associated with them will be in this map.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>> GetAdminRealmsByRealmClientSessionStatsAsync(
            string realm,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get client session stats Returns a JSON map.<br/>
        /// The key is the client id, the value is the number of sessions that currently are active with that client. Only clients that actually have a session associated with them will be in this map.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>>> GetAdminRealmsByRealmClientSessionStatsAsResponseAsync(
            string realm,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}