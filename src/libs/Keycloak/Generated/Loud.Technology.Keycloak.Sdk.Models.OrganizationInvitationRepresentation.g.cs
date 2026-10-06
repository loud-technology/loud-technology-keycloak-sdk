
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationInvitationRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentDate")]
        public int? SentDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.StatusJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.Status? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteLink")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? InviteLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitationRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="sentDate"></param>
        /// <param name="expiresAt"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInvitationRepresentation(
            string? id,
            string? organizationId,
            string? email,
            string? firstName,
            string? lastName,
            int? sentDate,
            int? expiresAt,
            global::Loud.Technology.Keycloak.Sdk.Status? status)
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SentDate = sentDate;
            this.ExpiresAt = expiresAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitationRepresentation" /> class.
        /// </summary>
        public OrganizationInvitationRepresentation()
        {
        }

    }
}