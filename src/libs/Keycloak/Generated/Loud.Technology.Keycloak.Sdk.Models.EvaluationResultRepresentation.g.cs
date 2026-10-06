
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationResultRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation? Resource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyResultRepresentation>? Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.DecisionEffectJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.DecisionEffect? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedScopes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? AllowedScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deniedScopes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? DeniedScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResultRepresentation" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="scopes"></param>
        /// <param name="policies"></param>
        /// <param name="status"></param>
        /// <param name="allowedScopes"></param>
        /// <param name="deniedScopes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationResultRepresentation(
            global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation? resource,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyResultRepresentation>? policies,
            global::Loud.Technology.Keycloak.Sdk.DecisionEffect? status,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? allowedScopes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? deniedScopes)
        {
            this.Resource = resource;
            this.Scopes = scopes;
            this.Policies = policies;
            this.Status = status;
            this.AllowedScopes = allowedScopes;
            this.DeniedScopes = deniedScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResultRepresentation" /> class.
        /// </summary>
        public EvaluationResultRepresentation()
        {
        }

    }
}