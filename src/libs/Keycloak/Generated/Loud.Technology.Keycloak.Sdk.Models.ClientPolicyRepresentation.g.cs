
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientPolicyRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyConditionRepresentation>? Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::System.Collections.Generic.IList<string>? Profiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPolicyRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="mode"></param>
        /// <param name="conditions"></param>
        /// <param name="profiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientPolicyRepresentation(
            string? name,
            string? description,
            bool? enabled,
            string? mode,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyConditionRepresentation>? conditions,
            global::System.Collections.Generic.IList<string>? profiles)
        {
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Mode = mode;
            this.Conditions = conditions;
            this.Profiles = profiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPolicyRepresentation" /> class.
        /// </summary>
        public ClientPolicyRepresentation()
        {
        }

    }
}