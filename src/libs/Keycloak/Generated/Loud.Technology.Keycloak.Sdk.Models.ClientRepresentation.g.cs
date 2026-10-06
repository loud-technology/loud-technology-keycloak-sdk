
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootUrl")]
        public string? RootUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminUrl")]
        public string? AdminUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("surrogateAuthRequired")]
        public bool? SurrogateAuthRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alwaysDisplayInConsole")]
        public bool? AlwaysDisplayInConsole { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientAuthenticatorType")]
        public string? ClientAuthenticatorType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationAccessToken")]
        public string? RegistrationAccessToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoles")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? DefaultRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webOrigins")]
        public global::System.Collections.Generic.IList<string>? WebOrigins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notBefore")]
        public int? NotBefore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearerOnly")]
        public bool? BearerOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consentRequired")]
        public bool? ConsentRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standardFlowEnabled")]
        public bool? StandardFlowEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("implicitFlowEnabled")]
        public bool? ImplicitFlowEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directAccessGrantsEnabled")]
        public bool? DirectAccessGrantsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceAccountsEnabled")]
        public bool? ServiceAccountsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationServicesEnabled")]
        public bool? AuthorizationServicesEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directGrantsOnly")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DirectGrantsOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicClient")]
        public bool? PublicClient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frontchannelLogout")]
        public bool? FrontchannelLogout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        public string? Protocol { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationFlowBindingOverrides")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthenticationFlowBindingOverrides { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullScopeAllowed")]
        public bool? FullScopeAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeReRegistrationTimeout")]
        public int? NodeReRegistrationTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registeredNodes")]
        public global::System.Collections.Generic.Dictionary<string, int>? RegisteredNodes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolMappers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? ProtocolMappers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientTemplate")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ClientTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useTemplateConfig")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UseTemplateConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useTemplateScope")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UseTemplateScope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useTemplateMappers")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UseTemplateMappers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultClientScopes")]
        public global::System.Collections.Generic.IList<string>? DefaultClientScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionalClientScopes")]
        public global::System.Collections.Generic.IList<string>? OptionalClientScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationSettings")]
        public global::Loud.Technology.Keycloak.Sdk.ResourceServerRepresentation? AuthorizationSettings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="rootUrl"></param>
        /// <param name="adminUrl"></param>
        /// <param name="baseUrl"></param>
        /// <param name="surrogateAuthRequired"></param>
        /// <param name="enabled"></param>
        /// <param name="alwaysDisplayInConsole"></param>
        /// <param name="clientAuthenticatorType"></param>
        /// <param name="secret"></param>
        /// <param name="registrationAccessToken"></param>
        /// <param name="redirectUris"></param>
        /// <param name="webOrigins"></param>
        /// <param name="notBefore"></param>
        /// <param name="bearerOnly"></param>
        /// <param name="consentRequired"></param>
        /// <param name="standardFlowEnabled"></param>
        /// <param name="implicitFlowEnabled"></param>
        /// <param name="directAccessGrantsEnabled"></param>
        /// <param name="serviceAccountsEnabled"></param>
        /// <param name="authorizationServicesEnabled"></param>
        /// <param name="publicClient"></param>
        /// <param name="frontchannelLogout"></param>
        /// <param name="protocol"></param>
        /// <param name="attributes"></param>
        /// <param name="authenticationFlowBindingOverrides"></param>
        /// <param name="fullScopeAllowed"></param>
        /// <param name="nodeReRegistrationTimeout"></param>
        /// <param name="registeredNodes"></param>
        /// <param name="protocolMappers"></param>
        /// <param name="defaultClientScopes"></param>
        /// <param name="optionalClientScopes"></param>
        /// <param name="authorizationSettings"></param>
        /// <param name="access"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientRepresentation(
            string? id,
            string? clientId,
            string? name,
            string? description,
            string? type,
            string? rootUrl,
            string? adminUrl,
            string? baseUrl,
            bool? surrogateAuthRequired,
            bool? enabled,
            bool? alwaysDisplayInConsole,
            string? clientAuthenticatorType,
            string? secret,
            string? registrationAccessToken,
            global::System.Collections.Generic.IList<string>? redirectUris,
            global::System.Collections.Generic.IList<string>? webOrigins,
            int? notBefore,
            bool? bearerOnly,
            bool? consentRequired,
            bool? standardFlowEnabled,
            bool? implicitFlowEnabled,
            bool? directAccessGrantsEnabled,
            bool? serviceAccountsEnabled,
            bool? authorizationServicesEnabled,
            bool? publicClient,
            bool? frontchannelLogout,
            string? protocol,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            global::System.Collections.Generic.Dictionary<string, string>? authenticationFlowBindingOverrides,
            bool? fullScopeAllowed,
            int? nodeReRegistrationTimeout,
            global::System.Collections.Generic.Dictionary<string, int>? registeredNodes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? protocolMappers,
            global::System.Collections.Generic.IList<string>? defaultClientScopes,
            global::System.Collections.Generic.IList<string>? optionalClientScopes,
            global::Loud.Technology.Keycloak.Sdk.ResourceServerRepresentation? authorizationSettings,
            global::System.Collections.Generic.Dictionary<string, bool>? access,
            string? origin)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.RootUrl = rootUrl;
            this.AdminUrl = adminUrl;
            this.BaseUrl = baseUrl;
            this.SurrogateAuthRequired = surrogateAuthRequired;
            this.Enabled = enabled;
            this.AlwaysDisplayInConsole = alwaysDisplayInConsole;
            this.ClientAuthenticatorType = clientAuthenticatorType;
            this.Secret = secret;
            this.RegistrationAccessToken = registrationAccessToken;
            this.RedirectUris = redirectUris;
            this.WebOrigins = webOrigins;
            this.NotBefore = notBefore;
            this.BearerOnly = bearerOnly;
            this.ConsentRequired = consentRequired;
            this.StandardFlowEnabled = standardFlowEnabled;
            this.ImplicitFlowEnabled = implicitFlowEnabled;
            this.DirectAccessGrantsEnabled = directAccessGrantsEnabled;
            this.ServiceAccountsEnabled = serviceAccountsEnabled;
            this.AuthorizationServicesEnabled = authorizationServicesEnabled;
            this.PublicClient = publicClient;
            this.FrontchannelLogout = frontchannelLogout;
            this.Protocol = protocol;
            this.Attributes = attributes;
            this.AuthenticationFlowBindingOverrides = authenticationFlowBindingOverrides;
            this.FullScopeAllowed = fullScopeAllowed;
            this.NodeReRegistrationTimeout = nodeReRegistrationTimeout;
            this.RegisteredNodes = registeredNodes;
            this.ProtocolMappers = protocolMappers;
            this.DefaultClientScopes = defaultClientScopes;
            this.OptionalClientScopes = optionalClientScopes;
            this.AuthorizationSettings = authorizationSettings;
            this.Access = access;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRepresentation" /> class.
        /// </summary>
        public ClientRepresentation()
        {
        }

    }
}