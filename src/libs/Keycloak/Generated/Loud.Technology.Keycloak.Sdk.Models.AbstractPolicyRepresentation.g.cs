
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AbstractPolicyRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<string>? Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<string>? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.LogicJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.Logic? Logic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisionStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.DecisionStrategyJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.DecisionStrategy? DecisionStrategy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        public string? ResourceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourcesData")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? ResourcesData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopesData")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? ScopesData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractPolicyRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="policies"></param>
        /// <param name="resources"></param>
        /// <param name="scopes"></param>
        /// <param name="logic"></param>
        /// <param name="decisionStrategy"></param>
        /// <param name="owner"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourcesData"></param>
        /// <param name="scopesData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AbstractPolicyRepresentation(
            string? id,
            string? name,
            string? description,
            string? type,
            global::System.Collections.Generic.IList<string>? policies,
            global::System.Collections.Generic.IList<string>? resources,
            global::System.Collections.Generic.IList<string>? scopes,
            global::Loud.Technology.Keycloak.Sdk.Logic? logic,
            global::Loud.Technology.Keycloak.Sdk.DecisionStrategy? decisionStrategy,
            string? owner,
            string? resourceType,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resourcesData,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopesData)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.Policies = policies;
            this.Resources = resources;
            this.Scopes = scopes;
            this.Logic = logic;
            this.DecisionStrategy = decisionStrategy;
            this.Owner = owner;
            this.ResourceType = resourceType;
            this.ResourcesData = resourcesData;
            this.ScopesData = scopesData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractPolicyRepresentation" /> class.
        /// </summary>
        public AbstractPolicyRepresentation()
        {
        }

    }
}