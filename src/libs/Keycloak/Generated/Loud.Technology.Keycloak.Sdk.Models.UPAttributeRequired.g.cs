
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UPAttributeRequired
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UPAttributeRequired" /> class.
        /// </summary>
        /// <param name="roles"></param>
        /// <param name="scopes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UPAttributeRequired(
            global::System.Collections.Generic.IList<string>? roles,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Roles = roles;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPAttributeRequired" /> class.
        /// </summary>
        public UPAttributeRequired()
        {
        }

    }
}