
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MappingsRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmMappings")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>? RealmMappings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientMappings")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.Keycloak.Sdk.ClientMappingsRepresentation>? ClientMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MappingsRepresentation" /> class.
        /// </summary>
        /// <param name="realmMappings"></param>
        /// <param name="clientMappings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MappingsRepresentation(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RoleRepresentation>? realmMappings,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.Keycloak.Sdk.ClientMappingsRepresentation>? clientMappings)
        {
            this.RealmMappings = realmMappings;
            this.ClientMappings = clientMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MappingsRepresentation" /> class.
        /// </summary>
        public MappingsRepresentation()
        {
        }

    }
}