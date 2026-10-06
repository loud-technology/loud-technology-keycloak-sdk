
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeyMetadataRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerPriority")]
        public long? ProviderPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public string? Kid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        public string? Algorithm { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.KeyUseJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.KeyUse? Use { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validTo")]
        public long? ValidTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyMetadataRepresentation" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="providerPriority"></param>
        /// <param name="kid"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="algorithm"></param>
        /// <param name="publicKey"></param>
        /// <param name="certificate"></param>
        /// <param name="use"></param>
        /// <param name="validTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyMetadataRepresentation(
            string? providerId,
            long? providerPriority,
            string? kid,
            string? status,
            string? type,
            string? algorithm,
            string? publicKey,
            string? certificate,
            global::Loud.Technology.Keycloak.Sdk.KeyUse? use,
            long? validTo)
        {
            this.ProviderId = providerId;
            this.ProviderPriority = providerPriority;
            this.Kid = kid;
            this.Status = status;
            this.Type = type;
            this.Algorithm = algorithm;
            this.PublicKey = publicKey;
            this.Certificate = certificate;
            this.Use = use;
            this.ValidTo = validTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyMetadataRepresentation" /> class.
        /// </summary>
        public KeyMetadataRepresentation()
        {
        }

    }
}