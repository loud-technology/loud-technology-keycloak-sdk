
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientPolicyConditionRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// Configuration settings as a JSON object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Loud.Technology.Keycloak.Sdk.RawJsonValue? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPolicyConditionRepresentation" /> class.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="configuration">
        /// Configuration settings as a JSON object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientPolicyConditionRepresentation(
            string? condition,
            global::Loud.Technology.Keycloak.Sdk.RawJsonValue? configuration)
        {
            this.Condition = condition;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPolicyConditionRepresentation" /> class.
        /// </summary>
        public ClientPolicyConditionRepresentation()
        {
        }

    }
}