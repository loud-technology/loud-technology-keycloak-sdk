
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowScheduleRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch-size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleRepresentation" /> class.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="batchSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowScheduleRepresentation(
            string? after,
            int? batchSize)
        {
            this.After = after;
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleRepresentation" /> class.
        /// </summary>
        public WorkflowScheduleRepresentation()
        {
        }

    }
}