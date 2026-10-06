
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest(
            string? email,
            string? firstName,
            string? lastName)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest" /> class.
        /// </summary>
        public CreateAdminRealmsByRealmOrganizationsByOrgIdMembersInviteUserRequest()
        {
        }

    }
}