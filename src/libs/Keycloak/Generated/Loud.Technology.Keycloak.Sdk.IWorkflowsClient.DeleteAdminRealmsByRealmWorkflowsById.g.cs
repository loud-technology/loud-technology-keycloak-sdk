#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Delete workflow<br/>
        /// Delete the workflow and its configuration.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminRealmsByRealmWorkflowsByIdAsync(
            string realm,
            string id,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete workflow<br/>
        /// Delete the workflow and its configuration.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> DeleteAdminRealmsByRealmWorkflowsByIdAsResponseAsync(
            string realm,
            string id,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}