
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Composites
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realm")]
        public global::System.Collections.Generic.IList<string>? Realm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Client { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Application { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Composites" /> class.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="client"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Composites(
            global::System.Collections.Generic.IList<string>? realm,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? client)
        {
            this.Realm = realm;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Composites" /> class.
        /// </summary>
        public Composites()
        {
        }

    }
}