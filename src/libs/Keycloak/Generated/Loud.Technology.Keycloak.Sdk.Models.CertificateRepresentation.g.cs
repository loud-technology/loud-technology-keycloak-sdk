
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificateRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateKey")]
        public string? PrivateKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate")]
        public string? Certificate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public string? Kid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        public string? Jwks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateRepresentation" /> class.
        /// </summary>
        /// <param name="privateKey"></param>
        /// <param name="publicKey"></param>
        /// <param name="certificate"></param>
        /// <param name="kid"></param>
        /// <param name="jwks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateRepresentation(
            string? privateKey,
            string? publicKey,
            string? certificate,
            string? kid,
            string? jwks)
        {
            this.PrivateKey = privateKey;
            this.PublicKey = publicKey;
            this.Certificate = certificate;
            this.Kid = kid;
            this.Jwks = jwks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateRepresentation" /> class.
        /// </summary>
        public CertificateRepresentation()
        {
        }

    }
}