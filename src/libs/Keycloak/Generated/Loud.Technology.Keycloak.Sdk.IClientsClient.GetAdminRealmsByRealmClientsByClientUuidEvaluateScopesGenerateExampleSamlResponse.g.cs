#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Create JSON with an example SAML response as payload
        /// </summary>
        /// <param name="audience"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.SamlExampleResponse> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesGenerateExampleSamlResponseAsync(
            string realm,
            string clientUuid,
            string? audience = default,
            string? scope = default,
            string? userId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create JSON with an example SAML response as payload
        /// </summary>
        /// <param name="audience"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.SamlExampleResponse>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesGenerateExampleSamlResponseAsResponseAsync(
            string realm,
            string clientUuid,
            string? audience = default,
            string? scope = default,
            string? userId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}