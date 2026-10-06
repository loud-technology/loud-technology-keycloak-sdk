
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementPermissionReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopePermissions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScopePermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementPermissionReference" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="resource"></param>
        /// <param name="scopePermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementPermissionReference(
            bool? enabled,
            string? resource,
            global::System.Collections.Generic.Dictionary<string, string>? scopePermissions)
        {
            this.Enabled = enabled;
            this.Resource = resource;
            this.ScopePermissions = scopePermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementPermissionReference" /> class.
        /// </summary>
        public ManagementPermissionReference()
        {
        }

    }
}