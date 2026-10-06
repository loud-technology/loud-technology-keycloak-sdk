
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoleRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeParamRequired")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ScopeParamRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composite")]
        public bool? Composite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composites")]
        public global::Loud.Technology.Keycloak.Sdk.Composites? Composites { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientRole")]
        public bool? ClientRole { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerId")]
        public string? ContainerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="composite"></param>
        /// <param name="composites"></param>
        /// <param name="clientRole"></param>
        /// <param name="containerId"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleRepresentation(
            string? id,
            string? name,
            string? description,
            bool? composite,
            global::Loud.Technology.Keycloak.Sdk.Composites? composites,
            bool? clientRole,
            string? containerId,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Composite = composite;
            this.Composites = composites;
            this.ClientRole = clientRole;
            this.ContainerId = containerId;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRepresentation" /> class.
        /// </summary>
        public RoleRepresentation()
        {
        }

    }
}