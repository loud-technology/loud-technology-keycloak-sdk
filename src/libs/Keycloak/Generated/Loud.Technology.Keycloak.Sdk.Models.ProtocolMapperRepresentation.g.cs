
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProtocolMapperRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        public string? Protocol { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolMapper")]
        public string? ProtocolMapper { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consentRequired")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ConsentRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consentText")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ConsentText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, string>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolMapperRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="protocol"></param>
        /// <param name="protocolMapper"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtocolMapperRepresentation(
            string? id,
            string? name,
            string? protocol,
            string? protocolMapper,
            global::System.Collections.Generic.Dictionary<string, string>? config)
        {
            this.Id = id;
            this.Name = name;
            this.Protocol = protocol;
            this.ProtocolMapper = protocolMapper;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolMapperRepresentation" /> class.
        /// </summary>
        public ProtocolMapperRepresentation()
        {
        }

    }
}