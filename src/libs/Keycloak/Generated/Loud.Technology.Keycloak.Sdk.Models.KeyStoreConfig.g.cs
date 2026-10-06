
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeyStoreConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmCertificate")]
        public bool? RealmCertificate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storePassword")]
        public string? StorePassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyPassword")]
        public string? KeyPassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyAlias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmAlias")]
        public string? RealmAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keySize")]
        public int? KeySize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        public int? Validity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyStoreConfig" /> class.
        /// </summary>
        /// <param name="realmCertificate"></param>
        /// <param name="storePassword"></param>
        /// <param name="keyPassword"></param>
        /// <param name="keyAlias"></param>
        /// <param name="realmAlias"></param>
        /// <param name="format"></param>
        /// <param name="keySize"></param>
        /// <param name="validity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyStoreConfig(
            bool? realmCertificate,
            string? storePassword,
            string? keyPassword,
            string? keyAlias,
            string? realmAlias,
            string? format,
            int? keySize,
            int? validity)
        {
            this.RealmCertificate = realmCertificate;
            this.StorePassword = storePassword;
            this.KeyPassword = keyPassword;
            this.KeyAlias = keyAlias;
            this.RealmAlias = realmAlias;
            this.Format = format;
            this.KeySize = keySize;
            this.Validity = validity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyStoreConfig" /> class.
        /// </summary>
        public KeyStoreConfig()
        {
        }

    }
}