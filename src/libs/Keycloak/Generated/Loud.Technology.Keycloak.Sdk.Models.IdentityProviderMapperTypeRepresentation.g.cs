
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityProviderMapperTypeRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

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
        /// Initializes a new instance of the <see cref="IdentityProviderMapperTypeRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="helpText"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityProviderMapperTypeRepresentation(
            string? id,
            string? name,
            string? category,
            string? helpText,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? properties)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.HelpText = helpText;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderMapperTypeRepresentation" /> class.
        /// </summary>
        public IdentityProviderMapperTypeRepresentation()
        {
        }

    }
}