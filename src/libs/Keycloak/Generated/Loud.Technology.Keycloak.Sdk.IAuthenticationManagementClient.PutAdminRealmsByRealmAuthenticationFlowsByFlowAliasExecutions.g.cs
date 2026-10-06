#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IAuthenticationManagementClient
    {
        /// <summary>
        /// Update authentication executions of a Flow
        /// </summary>
        /// <param name="flowAlias"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmAuthenticationFlowsByFlowAliasExecutionsAsync(
            string flowAlias,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionInfoRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update authentication executions of a Flow
        /// </summary>
        /// <param name="flowAlias"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmAuthenticationFlowsByFlowAliasExecutionsAsResponseAsync(
            string flowAlias,
            string realm,

            global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionInfoRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update authentication executions of a Flow
        /// </summary>
        /// <param name="flowAlias"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requirement"></param>
        /// <param name="displayName"></param>
        /// <param name="alias"></param>
        /// <param name="description"></param>
        /// <param name="requirementChoices"></param>
        /// <param name="configurable"></param>
        /// <param name="authenticationFlow"></param>
        /// <param name="providerId"></param>
        /// <param name="authenticationConfig"></param>
        /// <param name="flowId"></param>
        /// <param name="level"></param>
        /// <param name="index"></param>
        /// <param name="priority"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmAuthenticationFlowsByFlowAliasExecutionsAsync(
            string flowAlias,
            string realm,
            string? id = default,
            string? requirement = default,
            string? displayName = default,
            string? alias = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? requirementChoices = default,
            bool? configurable = default,
            bool? authenticationFlow = default,
            string? providerId = default,
            string? authenticationConfig = default,
            string? flowId = default,
            int? level = default,
            int? index = default,
            int? priority = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}