
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FederatedIdentityRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProvider")]
        public string? IdentityProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FederatedIdentityRepresentation" /> class.
        /// </summary>
        /// <param name="identityProvider"></param>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FederatedIdentityRepresentation(
            string? identityProvider,
            string? userId,
            string? userName)
        {
            this.IdentityProvider = identityProvider;
            this.UserId = userId;
            this.UserName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FederatedIdentityRepresentation" /> class.
        /// </summary>
        public FederatedIdentityRepresentation()
        {
        }

    }
}