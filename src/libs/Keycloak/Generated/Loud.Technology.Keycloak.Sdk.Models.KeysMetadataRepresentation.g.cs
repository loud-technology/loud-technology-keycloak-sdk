
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeysMetadataRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public global::System.Collections.Generic.Dictionary<string, string>? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.KeyMetadataRepresentation>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeysMetadataRepresentation" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeysMetadataRepresentation(
            global::System.Collections.Generic.Dictionary<string, string>? active,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.KeyMetadataRepresentation>? keys)
        {
            this.Active = active;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeysMetadataRepresentation" /> class.
        /// </summary>
        public KeysMetadataRepresentation()
        {
        }

    }
}