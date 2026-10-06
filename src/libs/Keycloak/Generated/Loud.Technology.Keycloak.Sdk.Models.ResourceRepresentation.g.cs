
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResourceRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_uri")]
        public string? IconUri { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Loud.Technology.Keycloak.Sdk.ResourceOwnerRepresentation? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerManagedAccess")]
        public bool? OwnerManagedAccess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Attributes { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Uri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopesUma")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? ScopesUma { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="uris"></param>
        /// <param name="type"></param>
        /// <param name="scopes"></param>
        /// <param name="iconUri"></param>
        /// <param name="owner">
        /// Included only in responses
        /// </param>
        /// <param name="ownerManagedAccess"></param>
        /// <param name="displayName"></param>
        /// <param name="attributes"></param>
        /// <param name="scopesUma"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceRepresentation(
            string? id,
            string? name,
            global::System.Collections.Generic.IList<string>? uris,
            string? type,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopes,
            string? iconUri,
            global::Loud.Technology.Keycloak.Sdk.ResourceOwnerRepresentation? owner,
            bool? ownerManagedAccess,
            string? displayName,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeRepresentation>? scopesUma)
        {
            this.Id = id;
            this.Name = name;
            this.Uris = uris;
            this.Type = type;
            this.Scopes = scopes;
            this.IconUri = iconUri;
            this.Owner = owner;
            this.OwnerManagedAccess = ownerManagedAccess;
            this.DisplayName = displayName;
            this.Attributes = attributes;
            this.ScopesUma = scopesUma;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRepresentation" /> class.
        /// </summary>
        public ResourceRepresentation()
        {
        }

    }
}