
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserProfileAttributeMetadata
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
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnly")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validators")]
        public global::System.Collections.Generic.Dictionary<string, object>? Validators { get; set; }

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
        /// Initializes a new instance of the <see cref="UserProfileAttributeMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="required"></param>
        /// <param name="readOnly"></param>
        /// <param name="annotations"></param>
        /// <param name="validators"></param>
        /// <param name="group"></param>
        /// <param name="multivalued"></param>
        /// <param name="defaultValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileAttributeMetadata(
            string? name,
            string? displayName,
            bool? required,
            bool? readOnly,
            object? annotations,
            global::System.Collections.Generic.Dictionary<string, object>? validators,
            string? group,
            bool? multivalued,
            string? defaultValue)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Required = required;
            this.ReadOnly = readOnly;
            this.Annotations = annotations;
            this.Validators = validators;
            this.Group = group;
            this.Multivalued = multivalued;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileAttributeMetadata" /> class.
        /// </summary>
        public UserProfileAttributeMetadata()
        {
        }

    }
}