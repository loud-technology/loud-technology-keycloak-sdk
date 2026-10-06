
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserConsentRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantedClientScopes")]
        public global::System.Collections.Generic.IList<string>? GrantedClientScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public long? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedDate")]
        public long? LastUpdatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantedRealmRoles")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? GrantedRealmRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserConsentRepresentation" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="grantedClientScopes"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastUpdatedDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserConsentRepresentation(
            string? clientId,
            global::System.Collections.Generic.IList<string>? grantedClientScopes,
            long? createdDate,
            long? lastUpdatedDate)
        {
            this.ClientId = clientId;
            this.GrantedClientScopes = grantedClientScopes;
            this.CreatedDate = createdDate;
            this.LastUpdatedDate = lastUpdatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserConsentRepresentation" /> class.
        /// </summary>
        public UserConsentRepresentation()
        {
        }

    }
}