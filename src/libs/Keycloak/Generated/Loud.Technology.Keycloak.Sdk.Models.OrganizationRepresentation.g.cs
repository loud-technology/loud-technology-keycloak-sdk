
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationDomainRepresentation>? Domains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>? Members { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProviders")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>? IdentityProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="alias"></param>
        /// <param name="enabled"></param>
        /// <param name="description"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="attributes"></param>
        /// <param name="domains"></param>
        /// <param name="members"></param>
        /// <param name="identityProviders"></param>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationRepresentation(
            string? id,
            string? name,
            string? alias,
            bool? enabled,
            string? description,
            string? redirectUrl,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationDomainRepresentation>? domains,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>? members,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>? identityProviders,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? groups)
        {
            this.Id = id;
            this.Name = name;
            this.Alias = alias;
            this.Enabled = enabled;
            this.Description = description;
            this.RedirectUrl = redirectUrl;
            this.Attributes = attributes;
            this.Domains = domains;
            this.Members = members;
            this.IdentityProviders = identityProviders;
            this.Groups = groups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRepresentation" /> class.
        /// </summary>
        public OrganizationRepresentation()
        {
        }

    }
}