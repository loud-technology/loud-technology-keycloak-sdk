
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientTypeRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public string? Parent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.Keycloak.Sdk.PropertyConfig>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTypeRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="parent"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientTypeRepresentation(
            string? name,
            string? provider,
            string? parent,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.Keycloak.Sdk.PropertyConfig>? config)
        {
            this.Name = name;
            this.Provider = provider;
            this.Parent = parent;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTypeRepresentation" /> class.
        /// </summary>
        public ClientTypeRepresentation()
        {
        }

    }
}