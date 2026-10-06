
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequiredActionProviderRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAction")]
        public bool? DefaultAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

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
        /// Initializes a new instance of the <see cref="RequiredActionProviderRepresentation" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="name"></param>
        /// <param name="providerId"></param>
        /// <param name="enabled"></param>
        /// <param name="defaultAction"></param>
        /// <param name="priority"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequiredActionProviderRepresentation(
            string? alias,
            string? name,
            string? providerId,
            bool? enabled,
            bool? defaultAction,
            int? priority,
            global::System.Collections.Generic.Dictionary<string, string>? config)
        {
            this.Alias = alias;
            this.Name = name;
            this.ProviderId = providerId;
            this.Enabled = enabled;
            this.DefaultAction = defaultAction;
            this.Priority = priority;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredActionProviderRepresentation" /> class.
        /// </summary>
        public RequiredActionProviderRepresentation()
        {
        }

    }
}