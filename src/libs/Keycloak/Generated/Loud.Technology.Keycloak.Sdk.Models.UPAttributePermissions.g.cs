
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UPAttributePermissions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        public global::System.Collections.Generic.IList<string>? View { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit")]
        public global::System.Collections.Generic.IList<string>? Edit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UPAttributePermissions" /> class.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="edit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UPAttributePermissions(
            global::System.Collections.Generic.IList<string>? view,
            global::System.Collections.Generic.IList<string>? edit)
        {
            this.View = view;
            this.Edit = edit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPAttributePermissions" /> class.
        /// </summary>
        public UPAttributePermissions()
        {
        }

    }
}