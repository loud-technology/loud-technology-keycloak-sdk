
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rsid")]
        public string? Rsid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rsname")]
        public string? Rsname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Claims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="rsid"></param>
        /// <param name="rsname"></param>
        /// <param name="scopes"></param>
        /// <param name="claims"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Permission(
            string? rsid,
            string? rsname,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? claims)
        {
            this.Rsid = rsid;
            this.Rsname = rsname;
            this.Scopes = scopes;
            this.Claims = claims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        public Permission()
        {
        }

    }
}