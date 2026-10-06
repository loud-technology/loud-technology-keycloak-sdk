
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuedVerifiableCredentialRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialType")]
        public string? CredentialType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuedAt")]
        public long? IssuedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientName")]
        public string? ClientName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientBaseUrl")]
        public string? ClientBaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedVerifiableCredentialRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="credentialType"></param>
        /// <param name="issuedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="clientId"></param>
        /// <param name="clientName"></param>
        /// <param name="clientBaseUrl"></param>
        /// <param name="revision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuedVerifiableCredentialRepresentation(
            string? id,
            string? userId,
            string? credentialType,
            long? issuedAt,
            long? expiresAt,
            string? clientId,
            string? clientName,
            string? clientBaseUrl,
            string? revision)
        {
            this.Id = id;
            this.UserId = userId;
            this.CredentialType = credentialType;
            this.IssuedAt = issuedAt;
            this.ExpiresAt = expiresAt;
            this.ClientId = clientId;
            this.ClientName = clientName;
            this.ClientBaseUrl = clientBaseUrl;
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedVerifiableCredentialRepresentation" /> class.
        /// </summary>
        public IssuedVerifiableCredentialRepresentation()
        {
        }

    }
}