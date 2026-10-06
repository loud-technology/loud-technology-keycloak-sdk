#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get workflow<br/>
        /// Get the workflow representation. Optionally exclude the workflow id from the response.
        /// </summary>
        /// <param name="includeId"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetAdminRealmsByRealmWorkflowsByIdAsBytesAsync(
            string realm,
            string id,
            bool? includeId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workflow<br/>
        /// Get the workflow representation. Optionally exclude the workflow id from the response.
        /// </summary>
        /// <param name="includeId"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetAdminRealmsByRealmWorkflowsByIdAsBytesAsStreamAsync(
            string realm,
            string id,
            bool? includeId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workflow<br/>
        /// Get the workflow representation. Optionally exclude the workflow id from the response.
        /// </summary>
        /// <param name="includeId"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<byte[]>> GetAdminRealmsByRealmWorkflowsByIdAsBytesAsResponseAsync(
            string realm,
            string id,
            bool? includeId = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}