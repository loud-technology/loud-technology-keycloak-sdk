
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientProfileRepresentation
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("executors")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyExecutorRepresentation>? Executors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProfileRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="executors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientProfileRepresentation(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyExecutorRepresentation>? executors)
        {
            this.Name = name;
            this.Description = description;
            this.Executors = executors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProfileRepresentation" /> class.
        /// </summary>
        public ClientProfileRepresentation()
        {
        }

    }
}