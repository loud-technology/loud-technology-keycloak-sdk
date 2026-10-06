
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResourceType
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeAliases")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? ScopeAliases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupType")]
        public string? GroupType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceType" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="scopes"></param>
        /// <param name="scopeAliases"></param>
        /// <param name="groupType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceType(
            string? type,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? scopeAliases,
            string? groupType)
        {
            this.Type = type;
            this.Scopes = scopes;
            this.ScopeAliases = scopeAliases;
            this.GroupType = groupType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceType" /> class.
        /// </summary>
        public ResourceType()
        {
        }

    }
}