
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationIdentityProviderLinkRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoMembership")]
        public bool? AutoMembership { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipType")]
        public string? MembershipType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationIdentityProviderLinkRepresentation" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="autoMembership"></param>
        /// <param name="membershipType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationIdentityProviderLinkRepresentation(
            string? organizationId,
            bool? autoMembership,
            string? membershipType)
        {
            this.OrganizationId = organizationId;
            this.AutoMembership = autoMembership;
            this.MembershipType = membershipType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationIdentityProviderLinkRepresentation" /> class.
        /// </summary>
        public OrganizationIdentityProviderLinkRepresentation()
        {
        }

    }
}