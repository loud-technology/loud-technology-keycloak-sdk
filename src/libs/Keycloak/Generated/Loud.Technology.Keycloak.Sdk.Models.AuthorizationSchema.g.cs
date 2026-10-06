
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthorizationSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceTypes")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.Keycloak.Sdk.ResourceType>? ResourceTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationSchema" /> class.
        /// </summary>
        /// <param name="resourceTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizationSchema(
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.Keycloak.Sdk.ResourceType>? resourceTypes)
        {
            this.ResourceTypes = resourceTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationSchema" /> class.
        /// </summary>
        public AuthorizationSchema()
        {
        }

    }
}