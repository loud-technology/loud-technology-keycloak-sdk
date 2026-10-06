#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List workflows<br/>
        /// List workflows filtered by name and paginated using first and max parameters.
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.WorkflowRepresentation> GetAdminRealmsByRealmWorkflowsAsync(
            string realm,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workflows<br/>
        /// List workflows filtered by name and paginated using first and max parameters.
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.WorkflowRepresentation>> GetAdminRealmsByRealmWorkflowsAsResponseAsync(
            string realm,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}