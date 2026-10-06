
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientProfilesRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientProfileRepresentation>? Profiles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalProfiles")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientProfileRepresentation>? GlobalProfiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProfilesRepresentation" /> class.
        /// </summary>
        /// <param name="profiles"></param>
        /// <param name="globalProfiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientProfilesRepresentation(
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientProfileRepresentation>? profiles,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientProfileRepresentation>? globalProfiles)
        {
            this.Profiles = profiles;
            this.GlobalProfiles = globalProfiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProfilesRepresentation" /> class.
        /// </summary>
        public ClientProfilesRepresentation()
        {
        }

    }
}