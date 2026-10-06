
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityProviderRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalId")]
        public string? InternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateProfileFirstLoginMode")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? UpdateProfileFirstLoginMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustEmail")]
        public bool? TrustEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storeToken")]
        public bool? StoreToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addReadTokenRoleOnCreate")]
        public bool? AddReadTokenRoleOnCreate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticateByDefault")]
        public bool? AuthenticateByDefault { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkOnly")]
        public bool? LinkOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideOnLogin")]
        public bool? HideOnLogin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstBrokerLoginFlowAlias")]
        public string? FirstBrokerLoginFlowAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postBrokerLoginFlowAlias")]
        public string? PostBrokerLoginFlowAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationLinks")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationIdentityProviderLinkRepresentation>? OrganizationLinks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, string>? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        public global::System.Collections.Generic.IList<string>? Types { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateProfileFirstLogin")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UpdateProfileFirstLogin { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderRepresentation" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="displayName"></param>
        /// <param name="internalId"></param>
        /// <param name="providerId"></param>
        /// <param name="enabled"></param>
        /// <param name="trustEmail"></param>
        /// <param name="storeToken"></param>
        /// <param name="addReadTokenRoleOnCreate"></param>
        /// <param name="authenticateByDefault"></param>
        /// <param name="linkOnly"></param>
        /// <param name="hideOnLogin"></param>
        /// <param name="firstBrokerLoginFlowAlias"></param>
        /// <param name="postBrokerLoginFlowAlias"></param>
        /// <param name="organizationLinks"></param>
        /// <param name="config"></param>
        /// <param name="types"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityProviderRepresentation(
            string? alias,
            string? displayName,
            string? internalId,
            string? providerId,
            bool? enabled,
            bool? trustEmail,
            bool? storeToken,
            bool? addReadTokenRoleOnCreate,
            bool? authenticateByDefault,
            bool? linkOnly,
            bool? hideOnLogin,
            string? firstBrokerLoginFlowAlias,
            string? postBrokerLoginFlowAlias,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationIdentityProviderLinkRepresentation>? organizationLinks,
            global::System.Collections.Generic.Dictionary<string, string>? config,
            global::System.Collections.Generic.IList<string>? types)
        {
            this.Alias = alias;
            this.DisplayName = displayName;
            this.InternalId = internalId;
            this.ProviderId = providerId;
            this.Enabled = enabled;
            this.TrustEmail = trustEmail;
            this.StoreToken = storeToken;
            this.AddReadTokenRoleOnCreate = addReadTokenRoleOnCreate;
            this.AuthenticateByDefault = authenticateByDefault;
            this.LinkOnly = linkOnly;
            this.HideOnLogin = hideOnLogin;
            this.FirstBrokerLoginFlowAlias = firstBrokerLoginFlowAlias;
            this.PostBrokerLoginFlowAlias = postBrokerLoginFlowAlias;
            this.OrganizationLinks = organizationLinks;
            this.Config = config;
            this.Types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderRepresentation" /> class.
        /// </summary>
        public IdentityProviderRepresentation()
        {
        }

    }
}