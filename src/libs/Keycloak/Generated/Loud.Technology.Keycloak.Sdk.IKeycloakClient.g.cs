
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    /// This is a REST API reference for the Keycloak Admin REST API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IKeycloakClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Loud.Technology.Keycloak.Sdk.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Loud.Technology.Keycloak.Sdk.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        ///
        /// </summary>
        public AttackDetectionClient AttackDetection { get; }

        /// <summary>
        ///
        /// </summary>
        public AuthenticationManagementClient AuthenticationManagement { get; }

        /// <summary>
        ///
        /// </summary>
        public ClientAttributeCertificateClient ClientAttributeCertificate { get; }

        /// <summary>
        ///
        /// </summary>
        public ClientInitialAccessClient ClientInitialAccess { get; }

        /// <summary>
        ///
        /// </summary>
        public ClientRegistrationPolicyClient ClientRegistrationPolicy { get; }

        /// <summary>
        ///
        /// </summary>
        public ClientRoleMappingsClient ClientRoleMappings { get; }

        /// <summary>
        ///
        /// </summary>
        public ClientScopesClient ClientScopes { get; }

        /// <summary>
        ///
        /// </summary>
        public ClientsClient Clients { get; }

        /// <summary>
        ///
        /// </summary>
        public ComponentClient Component { get; }

        /// <summary>
        ///
        /// </summary>
        public GroupsClient Groups { get; }

        /// <summary>
        ///
        /// </summary>
        public IdentityProvidersClient IdentityProviders { get; }

        /// <summary>
        ///
        /// </summary>
        public KeyClient Key { get; }

        /// <summary>
        ///
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        ///
        /// </summary>
        public ProtocolMappersClient ProtocolMappers { get; }

        /// <summary>
        ///
        /// </summary>
        public RealmsAdminClient RealmsAdmin { get; }

        /// <summary>
        ///
        /// </summary>
        public RoleMapperClient RoleMapper { get; }

        /// <summary>
        ///
        /// </summary>
        public RolesClient Roles { get; }

        /// <summary>
        ///
        /// </summary>
        public RolesByIdClient RolesById { get; }

        /// <summary>
        ///
        /// </summary>
        public ScopeMappingsClient ScopeMappings { get; }

        /// <summary>
        ///
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        ///
        /// </summary>
        public WorkflowsClient Workflows { get; }

    }
}