
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConfigPropertyRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helpText")]
        public string? HelpText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultValue")]
        public object? DefaultValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public bool? Secret { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigPropertyRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="helpText"></param>
        /// <param name="type"></param>
        /// <param name="defaultValue"></param>
        /// <param name="options"></param>
        /// <param name="secret"></param>
        /// <param name="required"></param>
        /// <param name="readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigPropertyRepresentation(
            string? name,
            string? label,
            string? helpText,
            string? type,
            object? defaultValue,
            global::System.Collections.Generic.IList<string>? options,
            bool? secret,
            bool? required,
            bool? readOnly)
        {
            this.Name = name;
            this.Label = label;
            this.HelpText = helpText;
            this.Type = type;
            this.DefaultValue = defaultValue;
            this.Options = options;
            this.Secret = secret;
            this.Required = required;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigPropertyRepresentation" /> class.
        /// </summary>
        public ConfigPropertyRepresentation()
        {
        }

    }
}