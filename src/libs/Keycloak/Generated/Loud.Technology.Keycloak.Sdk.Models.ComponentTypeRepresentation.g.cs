
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComponentTypeRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientProperties")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? ClientProperties { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentTypeRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="helpText"></param>
        /// <param name="properties"></param>
        /// <param name="clientProperties"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComponentTypeRepresentation(
            string? id,
            string? helpText,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? properties,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? clientProperties,
            object? metadata)
        {
            this.Id = id;
            this.HelpText = helpText;
            this.Properties = properties;
            this.ClientProperties = clientProperties;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentTypeRepresentation" /> class.
        /// </summary>
        public ComponentTypeRepresentation()
        {
        }

    }
}