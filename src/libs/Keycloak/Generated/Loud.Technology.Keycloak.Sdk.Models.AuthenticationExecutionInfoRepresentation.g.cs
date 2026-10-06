
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticationExecutionInfoRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirement")]
        public string? Requirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirementChoices")]
        public global::System.Collections.Generic.IList<string>? RequirementChoices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurable")]
        public bool? Configurable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationFlow")]
        public bool? AuthenticationFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationConfig")]
        public string? AuthenticationConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flowId")]
        public string? FlowId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        public int? Level { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExecutionInfoRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requirement"></param>
        /// <param name="displayName"></param>
        /// <param name="alias"></param>
        /// <param name="description"></param>
        /// <param name="requirementChoices"></param>
        /// <param name="configurable"></param>
        /// <param name="authenticationFlow"></param>
        /// <param name="providerId"></param>
        /// <param name="authenticationConfig"></param>
        /// <param name="flowId"></param>
        /// <param name="level"></param>
        /// <param name="index"></param>
        /// <param name="priority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationExecutionInfoRepresentation(
            string? id,
            string? requirement,
            string? displayName,
            string? alias,
            string? description,
            global::System.Collections.Generic.IList<string>? requirementChoices,
            bool? configurable,
            bool? authenticationFlow,
            string? providerId,
            string? authenticationConfig,
            string? flowId,
            int? level,
            int? index,
            int? priority)
        {
            this.Id = id;
            this.Requirement = requirement;
            this.DisplayName = displayName;
            this.Alias = alias;
            this.Description = description;
            this.RequirementChoices = requirementChoices;
            this.Configurable = configurable;
            this.AuthenticationFlow = authenticationFlow;
            this.ProviderId = providerId;
            this.AuthenticationConfig = authenticationConfig;
            this.FlowId = flowId;
            this.Level = level;
            this.Index = index;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExecutionInfoRepresentation" /> class.
        /// </summary>
        public AuthenticationExecutionInfoRepresentation()
        {
        }

    }
}