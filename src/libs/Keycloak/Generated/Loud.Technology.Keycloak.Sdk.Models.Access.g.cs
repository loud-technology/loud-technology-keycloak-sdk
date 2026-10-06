
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Access
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_caller")]
        public bool? VerifyCaller { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Access" /> class.
        /// </summary>
        /// <param name="roles"></param>
        /// <param name="verifyCaller"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Access(
            global::System.Collections.Generic.IList<string>? roles,
            bool? verifyCaller)
        {
            this.Roles = roles;
            this.VerifyCaller = verifyCaller;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Access" /> class.
        /// </summary>
        public Access()
        {
        }

    }
}