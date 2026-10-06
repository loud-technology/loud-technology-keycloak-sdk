#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List scheduled workflows for resource<br/>
        /// Return workflows that have scheduled steps for the given resource identifier.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.WorkflowRepresentation> GetAdminRealmsByRealmWorkflowsScheduledByResourceIdAsync(
            string resourceId,
            string realm,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List scheduled workflows for resource<br/>
        /// Return workflows that have scheduled steps for the given resource identifier.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.WorkflowRepresentation>> GetAdminRealmsByRealmWorkflowsScheduledByResourceIdAsResponseAsync(
            string resourceId,
            string realm,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}