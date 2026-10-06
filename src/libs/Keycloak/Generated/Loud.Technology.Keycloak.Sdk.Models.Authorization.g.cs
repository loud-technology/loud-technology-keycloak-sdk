
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Authorization
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.Permission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Authorization(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.Permission>? permissions)
        {
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        public Authorization()
        {
        }

    }
}