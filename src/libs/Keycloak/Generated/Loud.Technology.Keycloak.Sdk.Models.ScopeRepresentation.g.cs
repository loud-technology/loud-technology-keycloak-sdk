
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScopeRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUri")]
        public string? IconUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation>? Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="iconUri"></param>
        /// <param name="policies"></param>
        /// <param name="resources"></param>
        /// <param name="displayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopeRepresentation(
            string? id,
            string? name,
            string? iconUri,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation>? policies,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resources,
            string? displayName)
        {
            this.Id = id;
            this.Name = name;
            this.IconUri = iconUri;
            this.Policies = policies;
            this.Resources = resources;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeRepresentation" /> class.
        /// </summary>
        public ScopeRepresentation()
        {
        }

    }
}