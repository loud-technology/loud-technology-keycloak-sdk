
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticatorConfigInfoRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helpText")]
        public string? HelpText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorConfigInfoRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="providerId"></param>
        /// <param name="helpText"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticatorConfigInfoRepresentation(
            string? name,
            string? providerId,
            string? helpText,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? properties)
        {
            this.Name = name;
            this.ProviderId = providerId;
            this.HelpText = helpText;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorConfigInfoRepresentation" /> class.
        /// </summary>
        public AuthenticatorConfigInfoRepresentation()
        {
        }

    }
}