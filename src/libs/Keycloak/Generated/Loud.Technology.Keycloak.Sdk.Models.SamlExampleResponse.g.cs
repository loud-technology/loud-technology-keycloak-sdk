
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SamlExampleResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samlResponse")]
        public string? SamlResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamlExampleResponse" /> class.
        /// </summary>
        /// <param name="samlResponse"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamlExampleResponse(
            string? samlResponse)
        {
            this.SamlResponse = samlResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamlExampleResponse" /> class.
        /// </summary>
        public SamlExampleResponse()
        {
        }

    }
}