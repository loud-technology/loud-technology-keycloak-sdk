
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<object>? Params { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ErrorRepresentation>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorRepresentation" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="errorMessage"></param>
        /// <param name="params"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorRepresentation(
            string? field,
            string? errorMessage,
            global::System.Collections.Generic.IList<object>? @params,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ErrorRepresentation>? errors)
        {
            this.Field = field;
            this.ErrorMessage = errorMessage;
            this.Params = @params;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorRepresentation" /> class.
        /// </summary>
        public ErrorRepresentation()
        {
        }

    }
}