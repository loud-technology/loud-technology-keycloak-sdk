#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a new user Username must be unique.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmUsersAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.UserRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user Username must be unique.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmUsersAsResponseAsync(
            string realm,

            global::Loud.Technology.Keycloak.Sdk.UserRepresentation request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user Username must be unique.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="attributes"></param>
        /// <param name="userProfileMetadata"></param>
        /// <param name="enabled"></param>
        /// <param name="self"></param>
        /// <param name="origin"></param>
        /// <param name="createdTimestamp"></param>
        /// <param name="totp"></param>
        /// <param name="federationLink"></param>
        /// <param name="serviceAccountClientId"></param>
        /// <param name="credentials"></param>
        /// <param name="disableableCredentialTypes"></param>
        /// <param name="requiredActions"></param>
        /// <param name="federatedIdentities"></param>
        /// <param name="realmRoles"></param>
        /// <param name="clientRoles"></param>
        /// <param name="clientConsents"></param>
        /// <param name="notBefore"></param>
        /// <param name="verifiableCredentials"></param>
        /// <param name="issuedVerifiableCredentials"></param>
        /// <param name="groups"></param>
        /// <param name="access"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmUsersAsync(
            string realm,
            string? id = default,
            string? username = default,
            string? firstName = default,
            string? lastName = default,
            string? email = default,
            bool? emailVerified = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes = default,
            global::Loud.Technology.Keycloak.Sdk.UserProfileMetadata? userProfileMetadata = default,
            bool? enabled = default,
            string? self = default,
            string? origin = default,
            long? createdTimestamp = default,
            bool? totp = default,
            string? federationLink = default,
            string? serviceAccountClientId = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.CredentialRepresentation>? credentials = default,
            global::System.Collections.Generic.IList<string>? disableableCredentialTypes = default,
            global::System.Collections.Generic.IList<string>? requiredActions = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.FederatedIdentityRepresentation>? federatedIdentities = default,
            global::System.Collections.Generic.IList<string>? realmRoles = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? clientRoles = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserConsentRepresentation>? clientConsents = default,
            int? notBefore = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserVerifiableCredentialRepresentation>? verifiableCredentials = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IssuedVerifiableCredentialRepresentation>? issuedVerifiableCredentials = default,
            global::System.Collections.Generic.IList<string>? groups = default,
            global::System.Collections.Generic.Dictionary<string, bool>? access = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}