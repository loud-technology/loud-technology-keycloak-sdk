#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Update the client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientsByClientUuidAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmClientsByClientUuidAsResponseAsync(
            string realm,
            string clientUuid,

            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the client
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="rootUrl"></param>
        /// <param name="adminUrl"></param>
        /// <param name="baseUrl"></param>
        /// <param name="surrogateAuthRequired"></param>
        /// <param name="enabled"></param>
        /// <param name="alwaysDisplayInConsole"></param>
        /// <param name="clientAuthenticatorType"></param>
        /// <param name="secret"></param>
        /// <param name="registrationAccessToken"></param>
        /// <param name="redirectUris"></param>
        /// <param name="webOrigins"></param>
        /// <param name="notBefore"></param>
        /// <param name="bearerOnly"></param>
        /// <param name="consentRequired"></param>
        /// <param name="standardFlowEnabled"></param>
        /// <param name="implicitFlowEnabled"></param>
        /// <param name="directAccessGrantsEnabled"></param>
        /// <param name="serviceAccountsEnabled"></param>
        /// <param name="authorizationServicesEnabled"></param>
        /// <param name="publicClient"></param>
        /// <param name="frontchannelLogout"></param>
        /// <param name="protocol"></param>
        /// <param name="attributes"></param>
        /// <param name="authenticationFlowBindingOverrides"></param>
        /// <param name="fullScopeAllowed"></param>
        /// <param name="nodeReRegistrationTimeout"></param>
        /// <param name="registeredNodes"></param>
        /// <param name="protocolMappers"></param>
        /// <param name="defaultClientScopes"></param>
        /// <param name="optionalClientScopes"></param>
        /// <param name="authorizationSettings"></param>
        /// <param name="access"></param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientsByClientUuidAsync(
            string realm,
            string clientUuid,
            string? id = default,
            string? clientId = default,
            string? name = default,
            string? description = default,
            string? type = default,
            string? rootUrl = default,
            string? adminUrl = default,
            string? baseUrl = default,
            bool? surrogateAuthRequired = default,
            bool? enabled = default,
            bool? alwaysDisplayInConsole = default,
            string? clientAuthenticatorType = default,
            string? secret = default,
            string? registrationAccessToken = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            global::System.Collections.Generic.IList<string>? webOrigins = default,
            int? notBefore = default,
            bool? bearerOnly = default,
            bool? consentRequired = default,
            bool? standardFlowEnabled = default,
            bool? implicitFlowEnabled = default,
            bool? directAccessGrantsEnabled = default,
            bool? serviceAccountsEnabled = default,
            bool? authorizationServicesEnabled = default,
            bool? publicClient = default,
            bool? frontchannelLogout = default,
            string? protocol = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributes = default,
            global::System.Collections.Generic.Dictionary<string, string>? authenticationFlowBindingOverrides = default,
            bool? fullScopeAllowed = default,
            int? nodeReRegistrationTimeout = default,
            global::System.Collections.Generic.Dictionary<string, int>? registeredNodes = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? protocolMappers = default,
            global::System.Collections.Generic.IList<string>? defaultClientScopes = default,
            global::System.Collections.Generic.IList<string>? optionalClientScopes = default,
            global::Loud.Technology.Keycloak.Sdk.ResourceServerRepresentation? authorizationSettings = default,
            global::System.Collections.Generic.Dictionary<string, bool>? access = default,
            string? origin = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}