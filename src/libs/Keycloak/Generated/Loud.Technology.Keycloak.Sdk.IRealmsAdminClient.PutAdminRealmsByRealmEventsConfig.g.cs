#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        /// Update the events provider Change the events provider and/or its configuration
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmEventsConfigAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RealmEventsConfigRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the events provider Change the events provider and/or its configuration
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmEventsConfigAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.RealmEventsConfigRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the events provider Change the events provider and/or its configuration
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="eventsEnabled"></param>
        /// <param name="eventsExpiration"></param>
        /// <param name="eventsListeners"></param>
        /// <param name="enabledEventTypes"></param>
        /// <param name="adminEventsEnabled"></param>
        /// <param name="adminEventsDetailsEnabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmEventsConfigAsync(
            string realm,
            bool? eventsEnabled = default,
            long? eventsExpiration = default,
            global::System.Collections.Generic.IList<string>? eventsListeners = default,
            global::System.Collections.Generic.IList<string>? enabledEventTypes = default,
            bool? adminEventsEnabled = default,
            bool? adminEventsDetailsEnabled = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}