
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientTypesRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client-types")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientTypeRepresentation>? ClientTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global-client-types")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientTypeRepresentation>? GlobalClientTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTypesRepresentation" /> class.
        /// </summary>
        /// <param name="clientTypes"></param>
        /// <param name="globalClientTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientTypesRepresentation(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientTypeRepresentation>? clientTypes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientTypeRepresentation>? globalClientTypes)
        {
            this.ClientTypes = clientTypes;
            this.GlobalClientTypes = globalClientTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTypesRepresentation" /> class.
        /// </summary>
        public ClientTypesRepresentation()
        {
        }

    }
}