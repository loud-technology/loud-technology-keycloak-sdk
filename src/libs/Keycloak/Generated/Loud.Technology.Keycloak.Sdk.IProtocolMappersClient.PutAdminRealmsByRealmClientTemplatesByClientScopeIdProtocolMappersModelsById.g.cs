#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IProtocolMappersClient
    {
        /// <summary>
        /// Update the mapper
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientTemplatesByClientScopeIdProtocolMappersModelsByIdAsync(
            string id,
            string realm,
            string clientScopeId,

            global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the mapper
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmClientTemplatesByClientScopeIdProtocolMappersModelsByIdAsResponseAsync(
            string id,
            string realm,
            string clientScopeId,

            global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the mapper
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="protocol"></param>
        /// <param name="protocolMapper"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientTemplatesByClientScopeIdProtocolMappersModelsByIdAsync(
            string id,
            string realm,
            string clientScopeId,
            string? requestId = default,
            string? name = default,
            string? protocol = default,
            string? protocolMapper = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}