
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticationFlowRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topLevel")]
        public bool? TopLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtIn")]
        public bool? BuiltIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationExecutions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionExportRepresentation>? AuthenticationExecutions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationFlowRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="alias"></param>
        /// <param name="description"></param>
        /// <param name="providerId"></param>
        /// <param name="topLevel"></param>
        /// <param name="builtIn"></param>
        /// <param name="authenticationExecutions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationFlowRepresentation(
            string? id,
            string? alias,
            string? description,
            string? providerId,
            bool? topLevel,
            bool? builtIn,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticationExecutionExportRepresentation>? authenticationExecutions)
        {
            this.Id = id;
            this.Alias = alias;
            this.Description = description;
            this.ProviderId = providerId;
            this.TopLevel = topLevel;
            this.BuiltIn = builtIn;
            this.AuthenticationExecutions = authenticationExecutions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationFlowRepresentation" /> class.
        /// </summary>
        public AuthenticationFlowRepresentation()
        {
        }

    }
}