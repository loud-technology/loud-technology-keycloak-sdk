#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientAttributeCertificateClient
    {
        /// <summary>
        /// Upload only certificate, not private key
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="attr"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.CertificateRepresentation> CreateAdminRealmsByRealmClientsByClientUuidCertificatesByAttrUploadAsync(
            string realm,
            string clientUuid,
            string attr,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload only certificate, not private key
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="attr"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Keycloak.Sdk.CertificateRepresentation>> CreateAdminRealmsByRealmClientsByClientUuidCertificatesByAttrUploadAsResponseAsync(
            string realm,
            string clientUuid,
            string attr,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}