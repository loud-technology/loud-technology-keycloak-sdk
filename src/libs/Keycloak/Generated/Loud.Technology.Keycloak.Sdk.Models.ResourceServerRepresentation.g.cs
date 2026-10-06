
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResourceServerRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowRemoteResourceManagement")]
        public bool? AllowRemoteResourceManagement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policyEnforcementMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.PolicyEnforcementModeJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.PolicyEnforcementMode? PolicyEnforcementMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation>? Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisionStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.DecisionStrategyJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.DecisionStrategy? DecisionStrategy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationSchema")]
        public global::Loud.Technology.Keycloak.Sdk.AuthorizationSchema? AuthorizationSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceServerRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="allowRemoteResourceManagement"></param>
        /// <param name="policyEnforcementMode"></param>
        /// <param name="resources"></param>
        /// <param name="policies"></param>
        /// <param name="scopes"></param>
        /// <param name="decisionStrategy"></param>
        /// <param name="authorizationSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceServerRepresentation(
            string? id,
            string? clientId,
            string? name,
            bool? allowRemoteResourceManagement,
            global::Loud.Technology.Keycloak.Sdk.PolicyEnforcementMode? policyEnforcementMode,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resources,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation>? policies,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopes,
            global::Loud.Technology.Keycloak.Sdk.DecisionStrategy? decisionStrategy,
            global::Loud.Technology.Keycloak.Sdk.AuthorizationSchema? authorizationSchema)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.Name = name;
            this.AllowRemoteResourceManagement = allowRemoteResourceManagement;
            this.PolicyEnforcementMode = policyEnforcementMode;
            this.Resources = resources;
            this.Policies = policies;
            this.Scopes = scopes;
            this.DecisionStrategy = decisionStrategy;
            this.AuthorizationSchema = authorizationSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceServerRepresentation" /> class.
        /// </summary>
        public ResourceServerRepresentation()
        {
        }

    }
}