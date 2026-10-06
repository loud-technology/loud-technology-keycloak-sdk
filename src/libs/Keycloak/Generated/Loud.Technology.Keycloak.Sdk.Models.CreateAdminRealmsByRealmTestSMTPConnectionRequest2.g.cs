
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAdminRealmsByRealmTestSMTPConnectionRequest2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public string? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminRealmsByRealmTestSMTPConnectionRequest2" /> class.
        /// </summary>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminRealmsByRealmTestSMTPConnectionRequest2(
            string? config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminRealmsByRealmTestSMTPConnectionRequest2" /> class.
        /// </summary>
        public CreateAdminRealmsByRealmTestSMTPConnectionRequest2()
        {
        }

    }
}