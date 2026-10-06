
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticatorConfigRepresentation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, string>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorConfigRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="alias"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticatorConfigRepresentation(
            string? id,
            string? alias,
            global::System.Collections.Generic.Dictionary<string, string>? config)
        {
            this.Id = id;
            this.Alias = alias;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorConfigRepresentation" /> class.
        /// </summary>
        public AuthenticatorConfigRepresentation()
        {
        }

    }
}