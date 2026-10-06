
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientPoliciesRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyRepresentation>? Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalPolicies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyRepresentation>? GlobalPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPoliciesRepresentation" /> class.
        /// </summary>
        /// <param name="policies"></param>
        /// <param name="globalPolicies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientPoliciesRepresentation(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyRepresentation>? policies,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientPolicyRepresentation>? globalPolicies)
        {
            this.Policies = policies;
            this.GlobalPolicies = globalPolicies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPoliciesRepresentation" /> class.
        /// </summary>
        public ClientPoliciesRepresentation()
        {
        }

    }
}