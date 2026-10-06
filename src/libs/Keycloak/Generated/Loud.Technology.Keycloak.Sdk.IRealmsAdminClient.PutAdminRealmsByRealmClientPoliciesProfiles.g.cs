#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientPoliciesProfilesAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.ClientProfilesRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmClientPoliciesProfilesAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.ClientProfilesRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="profiles"></param>
        /// <param name="globalProfiles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientPoliciesProfilesAsync(
            string realm,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientProfileRepresentation>? profiles = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientProfileRepresentation>? globalProfiles = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}