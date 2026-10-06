#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Get clients belonging to the realm.<br/>
        /// If a client can’t be retrieved from the storage due to a problem with the underlying storage, it is silently removed from the returned list. This ensures that concurrent modifications to the list don’t prevent callers from retrieving this list.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search">
        /// Default Value: false
        /// </param>
        /// <param name="viewableOnly">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>> GetAdminRealmsByRealmClientsAsync(
            string realm,
            string? clientId = default,
            int? first = default,
            int? max = default,
            string? q = default,
            bool? search = default,
            bool? viewableOnly = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get clients belonging to the realm.<br/>
        /// If a client can’t be retrieved from the storage due to a problem with the underlying storage, it is silently removed from the returned list. This ensures that concurrent modifications to the list don’t prevent callers from retrieving this list.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="q"></param>
        /// <param name="search">
        /// Default Value: false
        /// </param>
        /// <param name="viewableOnly">
        /// Default Value: false
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>>> GetAdminRealmsByRealmClientsAsResponseAsync(
            string realm,
            string? clientId = default,
            int? first = default,
            int? max = default,
            string? q = default,
            bool? search = default,
            bool? viewableOnly = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}