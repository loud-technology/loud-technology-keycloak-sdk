
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowConcurrencyRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel-in-progress")]
        public string? CancelInProgress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restart-in-progress")]
        public string? RestartInProgress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowConcurrencyRepresentation" /> class.
        /// </summary>
        /// <param name="cancelInProgress"></param>
        /// <param name="restartInProgress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowConcurrencyRepresentation(
            string? cancelInProgress,
            string? restartInProgress)
        {
            this.CancelInProgress = cancelInProgress;
            this.RestartInProgress = restartInProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowConcurrencyRepresentation" /> class.
        /// </summary>
        public WorkflowConcurrencyRepresentation()
        {
        }

    }
}