#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Return list of all protocol mappers, which will be used when generating tokens issued for particular client.<br/>
        /// This means protocol mappers assigned to this client directly and protocol mappers assigned to all client scopes of this client.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperEvaluationRepresentation>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesProtocolMappersAsync(
            string realm,
            string clientUuid,
            string? scope = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return list of all protocol mappers, which will be used when generating tokens issued for particular client.<br/>
        /// This means protocol mappers assigned to this client directly and protocol mappers assigned to all client scopes of this client.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperEvaluationRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesProtocolMappersAsResponseAsync(
            string realm,
            string clientUuid,
            string? scope = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}