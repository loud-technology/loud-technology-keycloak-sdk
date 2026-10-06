
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientInitialAccessCreatePresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public int? Expiration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webOrigins")]
        public global::System.Collections.Generic.IList<string>? WebOrigins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessCreatePresentation" /> class.
        /// </summary>
        /// <param name="expiration"></param>
        /// <param name="count"></param>
        /// <param name="webOrigins"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInitialAccessCreatePresentation(
            int? expiration,
            int? count,
            global::System.Collections.Generic.IList<string>? webOrigins)
        {
            this.Expiration = expiration;
            this.Count = count;
            this.WebOrigins = webOrigins;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessCreatePresentation" /> class.
        /// </summary>
        public ClientInitialAccessCreatePresentation()
        {
        }

    }
}