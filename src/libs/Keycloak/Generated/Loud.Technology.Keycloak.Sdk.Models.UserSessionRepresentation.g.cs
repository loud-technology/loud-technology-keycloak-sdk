
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserSessionRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public long? Start { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAccess")]
        public long? LastAccess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rememberMe")]
        public bool? RememberMe { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clients")]
        public global::System.Collections.Generic.Dictionary<string, string>? Clients { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transientUser")]
        public bool? TransientUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="userId"></param>
        /// <param name="ipAddress"></param>
        /// <param name="start"></param>
        /// <param name="lastAccess"></param>
        /// <param name="rememberMe"></param>
        /// <param name="clients"></param>
        /// <param name="transientUser"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserSessionRepresentation(
            string? id,
            string? username,
            string? userId,
            string? ipAddress,
            long? start,
            long? lastAccess,
            bool? rememberMe,
            global::System.Collections.Generic.Dictionary<string, string>? clients,
            bool? transientUser)
        {
            this.Id = id;
            this.Username = username;
            this.UserId = userId;
            this.IpAddress = ipAddress;
            this.Start = start;
            this.LastAccess = lastAccess;
            this.RememberMe = rememberMe;
            this.Clients = clients;
            this.TransientUser = transientUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionRepresentation" /> class.
        /// </summary>
        public UserSessionRepresentation()
        {
        }

    }
}