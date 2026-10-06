
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SocialLinkRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialProvider")]
        public string? SocialProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialUserId")]
        public string? SocialUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialUsername")]
        public string? SocialUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialLinkRepresentation" /> class.
        /// </summary>
        /// <param name="socialProvider"></param>
        /// <param name="socialUserId"></param>
        /// <param name="socialUsername"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SocialLinkRepresentation(
            string? socialProvider,
            string? socialUserId,
            string? socialUsername)
        {
            this.SocialProvider = socialProvider;
            this.SocialUserId = socialUserId;
            this.SocialUsername = socialUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialLinkRepresentation" /> class.
        /// </summary>
        public SocialLinkRepresentation()
        {
        }

    }
}