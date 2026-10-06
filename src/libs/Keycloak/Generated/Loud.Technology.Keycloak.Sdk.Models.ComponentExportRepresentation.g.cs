
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComponentExportRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        public string? SubType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subComponents")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentExportRepresentation>>? SubComponents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentExportRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="providerId"></param>
        /// <param name="subType"></param>
        /// <param name="subComponents"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComponentExportRepresentation(
            string? id,
            string? name,
            string? providerId,
            string? subType,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentExportRepresentation>>? subComponents,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? config)
        {
            this.Id = id;
            this.Name = name;
            this.ProviderId = providerId;
            this.SubType = subType;
            this.SubComponents = subComponents;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentExportRepresentation" /> class.
        /// </summary>
        public ComponentExportRepresentation()
        {
        }

    }
}