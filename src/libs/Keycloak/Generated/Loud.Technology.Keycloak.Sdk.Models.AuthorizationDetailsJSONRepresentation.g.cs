
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthorizationDetailsJSONRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<string>? Locations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<string>? Actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatypes")]
        public global::System.Collections.Generic.IList<string>? Datatypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privileges")]
        public global::System.Collections.Generic.IList<string>? Privileges { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customData")]
        public object? CustomData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationDetailsJSONRepresentation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="locations"></param>
        /// <param name="actions"></param>
        /// <param name="datatypes"></param>
        /// <param name="identifier"></param>
        /// <param name="privileges"></param>
        /// <param name="customData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizationDetailsJSONRepresentation(
            string? type,
            global::System.Collections.Generic.IList<string>? locations,
            global::System.Collections.Generic.IList<string>? actions,
            global::System.Collections.Generic.IList<string>? datatypes,
            string? identifier,
            global::System.Collections.Generic.IList<string>? privileges,
            object? customData)
        {
            this.Type = type;
            this.Locations = locations;
            this.Actions = actions;
            this.Datatypes = datatypes;
            this.Identifier = identifier;
            this.Privileges = privileges;
            this.CustomData = customData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationDetailsJSONRepresentation" /> class.
        /// </summary>
        public AuthorizationDetailsJSONRepresentation()
        {
        }

    }
}