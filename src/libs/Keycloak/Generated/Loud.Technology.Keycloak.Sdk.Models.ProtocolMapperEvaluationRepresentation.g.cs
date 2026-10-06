
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProtocolMapperEvaluationRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapperId")]
        public string? MapperId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapperName")]
        public string? MapperName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerId")]
        public string? ContainerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerName")]
        public string? ContainerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerType")]
        public string? ContainerType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolMapper")]
        public string? ProtocolMapper { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolMapperEvaluationRepresentation" /> class.
        /// </summary>
        /// <param name="mapperId"></param>
        /// <param name="mapperName"></param>
        /// <param name="containerId"></param>
        /// <param name="containerName"></param>
        /// <param name="containerType"></param>
        /// <param name="protocolMapper"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtocolMapperEvaluationRepresentation(
            string? mapperId,
            string? mapperName,
            string? containerId,
            string? containerName,
            string? containerType,
            string? protocolMapper)
        {
            this.MapperId = mapperId;
            this.MapperName = mapperName;
            this.ContainerId = containerId;
            this.ContainerName = containerName;
            this.ContainerType = containerType;
            this.ProtocolMapper = protocolMapper;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolMapperEvaluationRepresentation" /> class.
        /// </summary>
        public ProtocolMapperEvaluationRepresentation()
        {
        }

    }
}