
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientInitialAccessPresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("remainingCount")]
        public int? RemainingCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessPresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <param name="timestamp"></param>
        /// <param name="expiration"></param>
        /// <param name="count"></param>
        /// <param name="remainingCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInitialAccessPresentation(
            string? id,
            string? token,
            int? timestamp,
            int? expiration,
            int? count,
            int? remainingCount)
        {
            this.Id = id;
            this.Token = token;
            this.Timestamp = timestamp;
            this.Expiration = expiration;
            this.Count = count;
            this.RemainingCount = remainingCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessPresentation" /> class.
        /// </summary>
        public ClientInitialAccessPresentation()
        {
        }

    }
}