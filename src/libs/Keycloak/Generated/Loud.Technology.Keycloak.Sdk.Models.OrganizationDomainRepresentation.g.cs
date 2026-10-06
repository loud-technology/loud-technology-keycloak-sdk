
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationDomainRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProviderAlias")]
        public string? IdentityProviderAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRedirect")]
        public bool? AutoRedirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDomainRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="verified"></param>
        /// <param name="identityProviderAlias"></param>
        /// <param name="autoRedirect"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationDomainRepresentation(
            string? name,
            bool? verified,
            string? identityProviderAlias,
            bool? autoRedirect)
        {
            this.Name = name;
            this.Verified = verified;
            this.IdentityProviderAlias = identityProviderAlias;
            this.AutoRedirect = autoRedirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDomainRepresentation" /> class.
        /// </summary>
        public OrganizationDomainRepresentation()
        {
        }

    }
}