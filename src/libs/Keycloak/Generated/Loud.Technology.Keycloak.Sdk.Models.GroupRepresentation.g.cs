
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GroupRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subGroupCount")]
        public long? SubGroupCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subGroups")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? SubGroups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmRoles")]
        public global::System.Collections.Generic.IList<string>? RealmRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientRoles")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? ClientRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="path"></param>
        /// <param name="parentId"></param>
        /// <param name="subGroupCount"></param>
        /// <param name="subGroups"></param>
        /// <param name="attributes"></param>
        /// <param name="realmRoles"></param>
        /// <param name="clientRoles"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupRepresentation(
            string? id,
            string? name,
            string? description,
            string? path,
            string? parentId,
            long? subGroupCount,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? subGroups,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes,
            global::System.Collections.Generic.IList<string>? realmRoles,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? clientRoles,
            global::System.Collections.Generic.Dictionary<string, bool>? access)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Path = path;
            this.ParentId = parentId;
            this.SubGroupCount = subGroupCount;
            this.SubGroups = subGroups;
            this.Attributes = attributes;
            this.RealmRoles = realmRoles;
            this.ClientRoles = clientRoles;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRepresentation" /> class.
        /// </summary>
        public GroupRepresentation()
        {
        }

    }
}