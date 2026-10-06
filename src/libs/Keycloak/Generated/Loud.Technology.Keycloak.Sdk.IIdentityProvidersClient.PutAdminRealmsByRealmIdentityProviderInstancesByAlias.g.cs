#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Update the identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmIdentityProviderInstancesByAliasAsync(
            string realm,
            string alias,

            global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmIdentityProviderInstancesByAliasAsResponseAsync(
            string realm,
            string alias,

            global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="requestAlias"></param>
        /// <param name="displayName"></param>
        /// <param name="internalId"></param>
        /// <param name="providerId"></param>
        /// <param name="enabled"></param>
        /// <param name="trustEmail"></param>
        /// <param name="storeToken"></param>
        /// <param name="addReadTokenRoleOnCreate"></param>
        /// <param name="authenticateByDefault"></param>
        /// <param name="linkOnly"></param>
        /// <param name="hideOnLogin"></param>
        /// <param name="firstBrokerLoginFlowAlias"></param>
        /// <param name="postBrokerLoginFlowAlias"></param>
        /// <param name="organizationLinks"></param>
        /// <param name="config"></param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmIdentityProviderInstancesByAliasAsync(
            string realm,
            string alias,
            string? requestAlias = default,
            string? displayName = default,
            string? internalId = default,
            string? providerId = default,
            bool? enabled = default,
            bool? trustEmail = default,
            bool? storeToken = default,
            bool? addReadTokenRoleOnCreate = default,
            bool? authenticateByDefault = default,
            bool? linkOnly = default,
            bool? hideOnLogin = default,
            string? firstBrokerLoginFlowAlias = default,
            string? postBrokerLoginFlowAlias = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationIdentityProviderLinkRepresentation>? organizationLinks = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}