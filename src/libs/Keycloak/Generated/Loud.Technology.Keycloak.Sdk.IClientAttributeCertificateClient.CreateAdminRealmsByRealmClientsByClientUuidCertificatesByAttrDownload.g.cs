#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IClientAttributeCertificateClient
    {
        /// <summary>
        /// Get a keystore file for the client, containing the public certificate
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="attr"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<byte[]> CreateAdminRealmsByRealmClientsByClientUuidCertificatesByAttrDownloadAsync(
            string realm,
            string clientUuid,
            string attr,

            global::Loud.Technology.Keycloak.Sdk.KeyStoreConfig request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a keystore file for the client, containing the public certificate
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="attr"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateAdminRealmsByRealmClientsByClientUuidCertificatesByAttrDownloadAsStreamAsync(
            string realm,
            string clientUuid,
            string attr,

            global::Loud.Technology.Keycloak.Sdk.KeyStoreConfig request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a keystore file for the client, containing the public certificate
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="attr"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<byte[]>> CreateAdminRealmsByRealmClientsByClientUuidCertificatesByAttrDownloadAsResponseAsync(
            string realm,
            string clientUuid,
            string attr,

            global::Loud.Technology.Keycloak.Sdk.KeyStoreConfig request,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a keystore file for the client, containing the public certificate
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="attr"></param>
        /// <param name="realmCertificate"></param>
        /// <param name="storePassword"></param>
        /// <param name="keyPassword"></param>
        /// <param name="keyAlias"></param>
        /// <param name="realmAlias"></param>
        /// <param name="format"></param>
        /// <param name="keySize"></param>
        /// <param name="validity"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<byte[]> CreateAdminRealmsByRealmClientsByClientUuidCertificatesByAttrDownloadAsync(
            string realm,
            string clientUuid,
            string attr,
            bool? realmCertificate = default,
            string? storePassword = default,
            string? keyPassword = default,
            string? keyAlias = default,
            string? realmAlias = default,
            string? format = default,
            int? keySize = default,
            int? validity = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}