
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailVerified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userProfileMetadata")]
        public global::Loud.Technology.Keycloak.Sdk.UserProfileMetadata? UserProfileMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        public string? Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdTimestamp")]
        public long? CreatedTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totp")]
        public bool? Totp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federationLink")]
        public string? FederationLink { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceAccountClientId")]
        public string? ServiceAccountClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.CredentialRepresentation>? Credentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableableCredentialTypes")]
        public global::System.Collections.Generic.IList<string>? DisableableCredentialTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredActions")]
        public global::System.Collections.Generic.IList<string>? RequiredActions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federatedIdentities")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.FederatedIdentityRepresentation>? FederatedIdentities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmRoles")]
        public global::System.Collections.Generic.IList<string>? RealmRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientRoles")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? ClientRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientConsents")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserConsentRepresentation>? ClientConsents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notBefore")]
        public int? NotBefore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiableCredentials")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserVerifiableCredentialRepresentation>? VerifiableCredentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuedVerifiableCredentials")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IssuedVerifiableCredentialRepresentation>? IssuedVerifiableCredentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicationRoles")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? ApplicationRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialLinks")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.SocialLinkRepresentation>? SocialLinks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="attributes"></param>
        /// <param name="userProfileMetadata"></param>
        /// <param name="enabled"></param>
        /// <param name="self"></param>
        /// <param name="origin"></param>
        /// <param name="createdTimestamp"></param>
        /// <param name="totp"></param>
        /// <param name="federationLink"></param>
        /// <param name="serviceAccountClientId"></param>
        /// <param name="credentials"></param>
        /// <param name="disableableCredentialTypes"></param>
        /// <param name="requiredActions"></param>
        /// <param name="federatedIdentities"></param>
        /// <param name="realmRoles"></param>
        /// <param name="clientRoles"></param>
        /// <param name="clientConsents"></param>
        /// <param name="notBefore"></param>
        /// <param name="verifiableCredentials"></param>
        /// <param name="issuedVerifiableCredentials"></param>
        /// <param name="groups"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserRepresentation(
            string? id,
            string? username,
            string? firstName,
            string? lastName,
            string? email,
            bool? emailVerified,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes,
            global::Loud.Technology.Keycloak.Sdk.UserProfileMetadata? userProfileMetadata,
            bool? enabled,
            string? self,
            string? origin,
            long? createdTimestamp,
            bool? totp,
            string? federationLink,
            string? serviceAccountClientId,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.CredentialRepresentation>? credentials,
            global::System.Collections.Generic.IList<string>? disableableCredentialTypes,
            global::System.Collections.Generic.IList<string>? requiredActions,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.FederatedIdentityRepresentation>? federatedIdentities,
            global::System.Collections.Generic.IList<string>? realmRoles,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? clientRoles,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserConsentRepresentation>? clientConsents,
            int? notBefore,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserVerifiableCredentialRepresentation>? verifiableCredentials,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IssuedVerifiableCredentialRepresentation>? issuedVerifiableCredentials,
            global::System.Collections.Generic.IList<string>? groups,
            global::System.Collections.Generic.Dictionary<string, bool>? access)
        {
            this.Id = id;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.Attributes = attributes;
            this.UserProfileMetadata = userProfileMetadata;
            this.Enabled = enabled;
            this.Self = self;
            this.Origin = origin;
            this.CreatedTimestamp = createdTimestamp;
            this.Totp = totp;
            this.FederationLink = federationLink;
            this.ServiceAccountClientId = serviceAccountClientId;
            this.Credentials = credentials;
            this.DisableableCredentialTypes = disableableCredentialTypes;
            this.RequiredActions = requiredActions;
            this.FederatedIdentities = federatedIdentities;
            this.RealmRoles = realmRoles;
            this.ClientRoles = clientRoles;
            this.ClientConsents = clientConsents;
            this.NotBefore = notBefore;
            this.VerifiableCredentials = verifiableCredentials;
            this.IssuedVerifiableCredentials = issuedVerifiableCredentials;
            this.Groups = groups;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepresentation" /> class.
        /// </summary>
        public UserRepresentation()
        {
        }

    }
}