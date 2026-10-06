
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserFederationMapperRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("federationProviderDisplayName")]
        public string? FederationProviderDisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federationMapperType")]
        public string? FederationMapperType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, string>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFederationMapperRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="federationProviderDisplayName"></param>
        /// <param name="federationMapperType"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserFederationMapperRepresentation(
            string? id,
            string? name,
            string? federationProviderDisplayName,
            string? federationMapperType,
            global::System.Collections.Generic.Dictionary<string, string>? config)
        {
            this.Id = id;
            this.Name = name;
            this.FederationProviderDisplayName = federationProviderDisplayName;
            this.FederationMapperType = federationMapperType;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFederationMapperRepresentation" /> class.
        /// </summary>
        public UserFederationMapperRepresentation()
        {
        }

    }
}