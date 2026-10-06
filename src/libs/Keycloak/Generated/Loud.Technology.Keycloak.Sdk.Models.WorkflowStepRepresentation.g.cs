
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowStepRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uses")]
        public string? Uses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled-at")]
        public long? ScheduledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.StepExecutionStatusJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.StepExecutionStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStepRepresentation" /> class.
        /// </summary>
        /// <param name="uses"></param>
        /// <param name="after"></param>
        /// <param name="scheduledAt"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowStepRepresentation(
            string? uses,
            string? after,
            long? scheduledAt,
            global::Loud.Technology.Keycloak.Sdk.StepExecutionStatus? status,
            string? id,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? config)
        {
            this.Uses = uses;
            this.After = after;
            this.ScheduledAt = scheduledAt;
            this.Status = status;
            this.Id = id;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStepRepresentation" /> class.
        /// </summary>
        public WorkflowStepRepresentation()
        {
        }

    }
}