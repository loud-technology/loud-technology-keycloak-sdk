
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticationExecutionExportRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticatorConfig")]
        public string? AuthenticatorConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticator")]
        public string? Authenticator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticatorFlow")]
        public bool? AuthenticatorFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirement")]
        public string? Requirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autheticatorFlow")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AutheticatorFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flowAlias")]
        public string? FlowAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userSetupAllowed")]
        public bool? UserSetupAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExecutionExportRepresentation" /> class.
        /// </summary>
        /// <param name="authenticatorConfig"></param>
        /// <param name="authenticator"></param>
        /// <param name="authenticatorFlow"></param>
        /// <param name="requirement"></param>
        /// <param name="priority"></param>
        /// <param name="flowAlias"></param>
        /// <param name="userSetupAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationExecutionExportRepresentation(
            string? authenticatorConfig,
            string? authenticator,
            bool? authenticatorFlow,
            string? requirement,
            int? priority,
            string? flowAlias,
            bool? userSetupAllowed)
        {
            this.AuthenticatorConfig = authenticatorConfig;
            this.Authenticator = authenticator;
            this.AuthenticatorFlow = authenticatorFlow;
            this.Requirement = requirement;
            this.Priority = priority;
            this.FlowAlias = flowAlias;
            this.UserSetupAllowed = userSetupAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExecutionExportRepresentation" /> class.
        /// </summary>
        public AuthenticationExecutionExportRepresentation()
        {
        }

    }
}