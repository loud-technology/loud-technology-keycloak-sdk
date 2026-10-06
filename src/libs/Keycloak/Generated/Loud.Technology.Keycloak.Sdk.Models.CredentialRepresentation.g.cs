
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CredentialRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLabel")]
        public string? UserLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public long? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretData")]
        public string? SecretData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialData")]
        public string? CredentialData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temporary")]
        public bool? Temporary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Device { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashedSaltedValue")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? HashedSaltedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Salt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashIterations")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? HashIterations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counter")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Counter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Algorithm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digits")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Digits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Period { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federationLink")]
        public string? FederationLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="userLabel"></param>
        /// <param name="createdDate"></param>
        /// <param name="secretData"></param>
        /// <param name="credentialData"></param>
        /// <param name="priority"></param>
        /// <param name="value"></param>
        /// <param name="temporary"></param>
        /// <param name="federationLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialRepresentation(
            string? id,
            string? type,
            string? userLabel,
            long? createdDate,
            string? secretData,
            string? credentialData,
            int? priority,
            string? value,
            bool? temporary,
            string? federationLink)
        {
            this.Id = id;
            this.Type = type;
            this.UserLabel = userLabel;
            this.CreatedDate = createdDate;
            this.SecretData = secretData;
            this.CredentialData = credentialData;
            this.Priority = priority;
            this.Value = value;
            this.Temporary = temporary;
            this.FederationLink = federationLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialRepresentation" /> class.
        /// </summary>
        public CredentialRepresentation()
        {
        }

    }
}