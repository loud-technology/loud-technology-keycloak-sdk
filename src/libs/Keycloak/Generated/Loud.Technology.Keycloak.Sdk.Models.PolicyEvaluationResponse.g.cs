
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PolicyEvaluationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.EvaluationResultRepresentation>? Results { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public bool? Entitlements { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.DecisionEffectJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.DecisionEffect? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpt")]
        public global::Loud.Technology.Keycloak.Sdk.AccessToken? Rpt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyEvaluationResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="entitlements"></param>
        /// <param name="status"></param>
        /// <param name="rpt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyEvaluationResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.EvaluationResultRepresentation>? results,
            bool? entitlements,
            global::Loud.Technology.Keycloak.Sdk.DecisionEffect? status,
            global::Loud.Technology.Keycloak.Sdk.AccessToken? rpt)
        {
            this.Results = results;
            this.Entitlements = entitlements;
            this.Status = status;
            this.Rpt = rpt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyEvaluationResponse" /> class.
        /// </summary>
        public PolicyEvaluationResponse()
        {
        }

    }
}