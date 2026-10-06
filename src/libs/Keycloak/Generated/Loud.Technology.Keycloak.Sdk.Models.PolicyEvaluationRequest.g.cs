
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PolicyEvaluationRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? Context { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        public string? ResourceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleIds")]
        public global::System.Collections.Generic.IList<string>? RoleIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public bool? Entitlements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyEvaluationRequest" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="resources"></param>
        /// <param name="resourceType"></param>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        /// <param name="roleIds"></param>
        /// <param name="entitlements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyEvaluationRequest(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? context,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ResourceRepresentation>? resources,
            string? resourceType,
            string? clientId,
            string? userId,
            global::System.Collections.Generic.IList<string>? roleIds,
            bool? entitlements)
        {
            this.Context = context;
            this.Resources = resources;
            this.ResourceType = resourceType;
            this.ClientId = clientId;
            this.UserId = userId;
            this.RoleIds = roleIds;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyEvaluationRequest" /> class.
        /// </summary>
        public PolicyEvaluationRequest()
        {
        }

    }
}