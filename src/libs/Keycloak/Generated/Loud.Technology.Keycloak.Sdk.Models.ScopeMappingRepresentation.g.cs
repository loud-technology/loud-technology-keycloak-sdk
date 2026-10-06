
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScopeMappingRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        public string? Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public string? Client { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientTemplate")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ClientTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientScope")]
        public string? ClientScope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeMappingRepresentation" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="client"></param>
        /// <param name="clientScope"></param>
        /// <param name="roles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopeMappingRepresentation(
            string? self,
            string? client,
            string? clientScope,
            global::System.Collections.Generic.IList<string>? roles)
        {
            this.Self = self;
            this.Client = client;
            this.ClientScope = clientScope;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeMappingRepresentation" /> class.
        /// </summary>
        public ScopeMappingRepresentation()
        {
        }

    }
}