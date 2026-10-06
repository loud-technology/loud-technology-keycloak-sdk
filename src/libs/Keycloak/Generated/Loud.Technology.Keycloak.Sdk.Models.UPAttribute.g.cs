
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UPAttribute
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validations")]
        public global::System.Collections.Generic.Dictionary<string, object>? Validations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::Loud.Technology.Keycloak.Sdk.UPAttributeRequired? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::Loud.Technology.Keycloak.Sdk.UPAttributePermissions? Permissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector")]
        public global::Loud.Technology.Keycloak.Sdk.UPAttributeSelector? Selector { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivalued")]
        public bool? Multivalued { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultValue")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UPAttribute" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="validations"></param>
        /// <param name="annotations"></param>
        /// <param name="required"></param>
        /// <param name="permissions"></param>
        /// <param name="selector"></param>
        /// <param name="group"></param>
        /// <param name="multivalued"></param>
        /// <param name="defaultValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UPAttribute(
            string? name,
            string? displayName,
            global::System.Collections.Generic.Dictionary<string, object>? validations,
            object? annotations,
            global::Loud.Technology.Keycloak.Sdk.UPAttributeRequired? required,
            global::Loud.Technology.Keycloak.Sdk.UPAttributePermissions? permissions,
            global::Loud.Technology.Keycloak.Sdk.UPAttributeSelector? selector,
            string? group,
            bool? multivalued,
            string? defaultValue)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Validations = validations;
            this.Annotations = annotations;
            this.Required = required;
            this.Permissions = permissions;
            this.Selector = selector;
            this.Group = group;
            this.Multivalued = multivalued;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPAttribute" /> class.
        /// </summary>
        public UPAttribute()
        {
        }

    }
}