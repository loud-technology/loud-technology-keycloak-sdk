
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RawJsonValue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("empty")]
        public bool? Empty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawJsonValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="empty"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawJsonValue(
            object? value,
            bool? empty)
        {
            this.Value = value;
            this.Empty = empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawJsonValue" /> class.
        /// </summary>
        public RawJsonValue()
        {
        }

    }
}