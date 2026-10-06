
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientPolicyExecutorRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executor")]
        public string? Executor { get; set; }

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
        /// Initializes a new instance of the <see cref="ClientPolicyExecutorRepresentation" /> class.
        /// </summary>
        /// <param name="executor"></param>
        /// <param name="configuration">
        /// Configuration settings as a JSON object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientPolicyExecutorRepresentation(
            string? executor,
            global::Loud.Technology.Keycloak.Sdk.RawJsonValue? configuration)
        {
            this.Executor = executor;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPolicyExecutorRepresentation" /> class.
        /// </summary>
        public ClientPolicyExecutorRepresentation()
        {
        }

    }
}