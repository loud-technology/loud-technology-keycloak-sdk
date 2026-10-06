
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublishedRealmRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realm")]
        public string? Realm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_key")]
        public string? PublicKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token-service")]
        public string? TokenService { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account-service")]
        public string? AccountService { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens-not-before")]
        public int? TokensNotBefore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedRealmRepresentation" /> class.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="publicKey"></param>
        /// <param name="tokenService"></param>
        /// <param name="accountService"></param>
        /// <param name="tokensNotBefore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishedRealmRepresentation(
            string? realm,
            string? publicKey,
            string? tokenService,
            string? accountService,
            int? tokensNotBefore)
        {
            this.Realm = realm;
            this.PublicKey = publicKey;
            this.TokenService = tokenService;
            this.AccountService = accountService;
            this.TokensNotBefore = tokensNotBefore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedRealmRepresentation" /> class.
        /// </summary>
        public PublishedRealmRepresentation()
        {
        }

    }
}