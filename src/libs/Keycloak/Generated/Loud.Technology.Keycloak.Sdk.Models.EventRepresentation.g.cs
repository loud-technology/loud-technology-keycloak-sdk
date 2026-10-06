
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EventRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public long? Time { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmId")]
        public string? RealmId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipAddress")]
        public string? IpAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.Dictionary<string, string>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <param name="type"></param>
        /// <param name="realmId"></param>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        /// <param name="sessionId"></param>
        /// <param name="ipAddress"></param>
        /// <param name="error"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventRepresentation(
            string? id,
            long? time,
            string? type,
            string? realmId,
            string? clientId,
            string? userId,
            string? sessionId,
            string? ipAddress,
            string? error,
            global::System.Collections.Generic.Dictionary<string, string>? details)
        {
            this.Id = id;
            this.Time = time;
            this.Type = type;
            this.RealmId = realmId;
            this.ClientId = clientId;
            this.UserId = userId;
            this.SessionId = sessionId;
            this.IpAddress = ipAddress;
            this.Error = error;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventRepresentation" /> class.
        /// </summary>
        public EventRepresentation()
        {
        }

    }
}