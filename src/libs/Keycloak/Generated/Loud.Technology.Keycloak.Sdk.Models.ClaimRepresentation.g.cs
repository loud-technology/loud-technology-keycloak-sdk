
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClaimRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public bool? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public bool? Username { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public bool? Profile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public bool? Picture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public bool? Website { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public bool? Gender { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public bool? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public bool? Address { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public bool? Phone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRepresentation" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="profile"></param>
        /// <param name="picture"></param>
        /// <param name="website"></param>
        /// <param name="email"></param>
        /// <param name="gender"></param>
        /// <param name="locale"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaimRepresentation(
            bool? name,
            bool? username,
            bool? profile,
            bool? picture,
            bool? website,
            bool? email,
            bool? gender,
            bool? locale,
            bool? address,
            bool? phone)
        {
            this.Name = name;
            this.Username = username;
            this.Profile = profile;
            this.Picture = picture;
            this.Website = website;
            this.Email = email;
            this.Gender = gender;
            this.Locale = locale;
            this.Address = address;
            this.Phone = phone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRepresentation" /> class.
        /// </summary>
        public ClaimRepresentation()
        {
        }

    }
}