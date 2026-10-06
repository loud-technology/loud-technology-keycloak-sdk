#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow from the provided representation.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmWorkflowsAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.WorkflowRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow from the provided representation.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmWorkflowsAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.WorkflowRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow from the provided representation.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="on"></param>
        /// <param name="schedule"></param>
        /// <param name="concurrency"></param>
        /// <param name="if"></param>
        /// <param name="steps"></param>
        /// <param name="state"></param>
        /// <param name="with"></param>
        /// <param name="cancelInProgress"></param>
        /// <param name="restartInProgress"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmWorkflowsAsync(
            string realm,
            string? id = default,
            string? name = default,
            bool? enabled = default,
            string? on = default,
            global::Loud.Technology.Keycloak.Sdk.WorkflowScheduleRepresentation? schedule = default,
            global::Loud.Technology.Keycloak.Sdk.WorkflowConcurrencyRepresentation? concurrency = default,
            string? @if = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.WorkflowStepRepresentation>? steps = default,
            global::Loud.Technology.Keycloak.Sdk.WorkflowStateRepresentation? state = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? with = default,
            string? cancelInProgress = default,
            string? restartInProgress = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}