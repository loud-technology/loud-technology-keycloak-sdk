
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VerifiableCredentialOfferActionConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialConfigurationId")]
        public string? CredentialConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preAuthorized")]
        public bool? PreAuthorized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiableCredentialOfferActionConfig" /> class.
        /// </summary>
        /// <param name="credentialConfigurationId"></param>
        /// <param name="clientId"></param>
        /// <param name="preAuthorized"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifiableCredentialOfferActionConfig(
            string? credentialConfigurationId,
            string? clientId,
            bool? preAuthorized)
        {
            this.CredentialConfigurationId = credentialConfigurationId;
            this.ClientId = clientId;
            this.PreAuthorized = preAuthorized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiableCredentialOfferActionConfig" /> class.
        /// </summary>
        public VerifiableCredentialOfferActionConfig()
        {
        }

    }
}