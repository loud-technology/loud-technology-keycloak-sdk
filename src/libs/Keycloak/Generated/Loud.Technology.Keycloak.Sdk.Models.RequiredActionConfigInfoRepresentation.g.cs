
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequiredActionConfigInfoRepresentation
    {
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
        /// Initializes a new instance of the <see cref="RequiredActionConfigInfoRepresentation" /> class.
        /// </summary>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequiredActionConfigInfoRepresentation(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ConfigPropertyRepresentation>? properties)
        {
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredActionConfigInfoRepresentation" /> class.
        /// </summary>
        public RequiredActionConfigInfoRepresentation()
        {
        }

    }
}