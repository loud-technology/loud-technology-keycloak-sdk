
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthDetailsRepresentation
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ipAddress")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDetailsRepresentation" /> class.
        /// </summary>
        /// <param name="realmId"></param>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        /// <param name="ipAddress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthDetailsRepresentation(
            string? realmId,
            string? clientId,
            string? userId,
            string? ipAddress)
        {
            this.RealmId = realmId;
            this.ClientId = clientId;
            this.UserId = userId;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDetailsRepresentation" /> class.
        /// </summary>
        public AuthDetailsRepresentation()
        {
        }

    }
}