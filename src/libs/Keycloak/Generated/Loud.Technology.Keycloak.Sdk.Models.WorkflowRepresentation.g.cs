
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        public string? On { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::Loud.Technology.Keycloak.Sdk.WorkflowScheduleRepresentation? Schedule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public global::Loud.Technology.Keycloak.Sdk.WorkflowConcurrencyRepresentation? Concurrency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("if")]
        public string? If { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.WorkflowStepRepresentation>? Steps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Loud.Technology.Keycloak.Sdk.WorkflowStateRepresentation? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? With { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelInProgress")]
        public string? CancelInProgress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartInProgress")]
        public string? RestartInProgress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="on"></param>
        /// <param name="schedule"></param>
        /// <param name="concurrency"></param>
        /// <param name="if"></param>
        /// <param name="steps"></param>
        /// <param name="state"></param>
        /// <param name="with"></param>
        /// <param name="cancelInProgress"></param>
        /// <param name="restartInProgress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRepresentation(
            string? id,
            string? name,
            bool? enabled,
            string? on,
            global::Loud.Technology.Keycloak.Sdk.WorkflowScheduleRepresentation? schedule,
            global::Loud.Technology.Keycloak.Sdk.WorkflowConcurrencyRepresentation? concurrency,
            string? @if,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.WorkflowStepRepresentation>? steps,
            global::Loud.Technology.Keycloak.Sdk.WorkflowStateRepresentation? state,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? with,
            string? cancelInProgress,
            string? restartInProgress)
        {
            this.Id = id;
            this.Name = name;
            this.Enabled = enabled;
            this.On = on;
            this.Schedule = schedule;
            this.Concurrency = concurrency;
            this.If = @if;
            this.Steps = steps;
            this.State = state;
            this.With = with;
            this.CancelInProgress = cancelInProgress;
            this.RestartInProgress = restartInProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRepresentation" /> class.
        /// </summary>
        public WorkflowRepresentation()
        {
        }

    }
}