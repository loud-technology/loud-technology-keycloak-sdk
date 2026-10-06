#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IComponentClient
    {
        /// <summary>
        /// List of subcomponent types that are available to configure for a particular parent component.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentTypeRepresentation>> GetAdminRealmsByRealmComponentsByIdSubComponentTypesAsync(
            string id,
            string realm,
            string? type = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List of subcomponent types that are available to configure for a particular parent component.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentTypeRepresentation>>> GetAdminRealmsByRealmComponentsByIdSubComponentTypesAsResponseAsync(
            string id,
            string realm,
            string? type = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}