
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserVerifiableCredentialRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialScopeName")]
        public string? CredentialScopeName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialConfigurationId")]
        public string? CredentialConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public long? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedDate")]
        public long? UpdatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAttributes")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? UserAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserVerifiableCredentialRepresentation" /> class.
        /// </summary>
        /// <param name="credentialScopeName"></param>
        /// <param name="credentialConfigurationId"></param>
        /// <param name="revision"></param>
        /// <param name="createdDate"></param>
        /// <param name="updatedDate"></param>
        /// <param name="userAttributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserVerifiableCredentialRepresentation(
            string? credentialScopeName,
            string? credentialConfigurationId,
            string? revision,
            long? createdDate,
            long? updatedDate,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? userAttributes)
        {
            this.CredentialScopeName = credentialScopeName;
            this.CredentialConfigurationId = credentialConfigurationId;
            this.Revision = revision;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.UserAttributes = userAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserVerifiableCredentialRepresentation" /> class.
        /// </summary>
        public UserVerifiableCredentialRepresentation()
        {
        }

    }
}