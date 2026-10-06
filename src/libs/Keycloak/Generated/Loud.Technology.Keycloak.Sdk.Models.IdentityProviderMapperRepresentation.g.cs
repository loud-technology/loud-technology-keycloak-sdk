
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityProviderMapperRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProviderAlias")]
        public string? IdentityProviderAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProviderMapper")]
        public string? IdentityProviderMapper { get; set; }

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
        /// Initializes a new instance of the <see cref="IdentityProviderMapperRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="identityProviderAlias"></param>
        /// <param name="identityProviderMapper"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityProviderMapperRepresentation(
            string? id,
            string? name,
            string? identityProviderAlias,
            string? identityProviderMapper,
            global::System.Collections.Generic.Dictionary<string, string>? config)
        {
            this.Id = id;
            this.Name = name;
            this.IdentityProviderAlias = identityProviderAlias;
            this.IdentityProviderMapper = identityProviderMapper;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderMapperRepresentation" /> class.
        /// </summary>
        public IdentityProviderMapperRepresentation()
        {
        }

    }
}