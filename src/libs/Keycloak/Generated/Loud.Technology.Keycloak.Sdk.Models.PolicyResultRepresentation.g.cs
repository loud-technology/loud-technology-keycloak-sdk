
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PolicyResultRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation? Policy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.DecisionEffectJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.DecisionEffect? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("associatedPolicies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyResultRepresentation>? AssociatedPolicies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResultRepresentation" /> class.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="status"></param>
        /// <param name="associatedPolicies"></param>
        /// <param name="scopes"></param>
        /// <param name="resourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyResultRepresentation(
            global::Loud.Technology.Keycloak.Sdk.PolicyRepresentation? policy,
            global::Loud.Technology.Keycloak.Sdk.DecisionEffect? status,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.PolicyResultRepresentation>? associatedPolicies,
            global::System.Collections.Generic.IList<string>? scopes,
            string? resourceType)
        {
            this.Policy = policy;
            this.Status = status;
            this.AssociatedPolicies = associatedPolicies;
            this.Scopes = scopes;
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResultRepresentation" /> class.
        /// </summary>
        public PolicyResultRepresentation()
        {
        }

    }
}