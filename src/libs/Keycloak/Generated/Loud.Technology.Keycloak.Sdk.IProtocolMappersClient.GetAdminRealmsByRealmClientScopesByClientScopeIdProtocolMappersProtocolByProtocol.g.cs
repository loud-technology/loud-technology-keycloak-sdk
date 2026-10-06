#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IProtocolMappersClient
    {
        /// <summary>
        /// Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="protocol"></param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>> GetAdminRealmsByRealmClientScopesByClientScopeIdProtocolMappersProtocolByProtocolAsync(
            string protocol,
            string realm,
            string clientScopeId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="protocol"></param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>>> GetAdminRealmsByRealmClientScopesByClientScopeIdProtocolMappersProtocolByProtocolAsResponseAsync(
            string protocol,
            string realm,
            string clientScopeId,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}