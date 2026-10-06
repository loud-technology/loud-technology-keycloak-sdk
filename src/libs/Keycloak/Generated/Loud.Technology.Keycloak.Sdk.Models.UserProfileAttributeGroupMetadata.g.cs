
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserProfileAttributeGroupMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayHeader")]
        public string? DisplayHeader { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayDescription")]
        public string? DisplayDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileAttributeGroupMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayHeader"></param>
        /// <param name="displayDescription"></param>
        /// <param name="annotations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileAttributeGroupMetadata(
            string? name,
            string? displayHeader,
            string? displayDescription,
            object? annotations)
        {
            this.Name = name;
            this.DisplayHeader = displayHeader;
            this.DisplayDescription = displayDescription;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileAttributeGroupMetadata" /> class.
        /// </summary>
        public UserProfileAttributeGroupMetadata()
        {
        }

    }
}