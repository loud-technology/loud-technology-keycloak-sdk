
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ClientTemplateRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Protocol { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullScopeAllowed")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? FullScopeAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearerOnly")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? BearerOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consentRequired")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ConsentRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standardFlowEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? StandardFlowEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("implicitFlowEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ImplicitFlowEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directAccessGrantsEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DirectAccessGrantsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceAccountsEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ServiceAccountsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicClient")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PublicClient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frontchannelLogout")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? FrontchannelLogout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolMappers")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? ProtocolMappers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTemplateRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="protocol"></param>
        /// <param name="fullScopeAllowed"></param>
        /// <param name="bearerOnly"></param>
        /// <param name="consentRequired"></param>
        /// <param name="standardFlowEnabled"></param>
        /// <param name="implicitFlowEnabled"></param>
        /// <param name="directAccessGrantsEnabled"></param>
        /// <param name="serviceAccountsEnabled"></param>
        /// <param name="publicClient"></param>
        /// <param name="frontchannelLogout"></param>
        /// <param name="attributes"></param>
        /// <param name="protocolMappers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientTemplateRepresentation(
            string? id,
            string? name,
            string? description,
            string? protocol,
            bool? fullScopeAllowed,
            bool? bearerOnly,
            bool? consentRequired,
            bool? standardFlowEnabled,
            bool? implicitFlowEnabled,
            bool? directAccessGrantsEnabled,
            bool? serviceAccountsEnabled,
            bool? publicClient,
            bool? frontchannelLogout,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? protocolMappers)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Protocol = protocol;
            this.FullScopeAllowed = fullScopeAllowed;
            this.BearerOnly = bearerOnly;
            this.ConsentRequired = consentRequired;
            this.StandardFlowEnabled = standardFlowEnabled;
            this.ImplicitFlowEnabled = implicitFlowEnabled;
            this.DirectAccessGrantsEnabled = directAccessGrantsEnabled;
            this.ServiceAccountsEnabled = serviceAccountsEnabled;
            this.PublicClient = publicClient;
            this.FrontchannelLogout = frontchannelLogout;
            this.Attributes = attributes;
            this.ProtocolMappers = protocolMappers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTemplateRepresentation" /> class.
        /// </summary>
        public ClientTemplateRepresentation()
        {
        }

    }
}