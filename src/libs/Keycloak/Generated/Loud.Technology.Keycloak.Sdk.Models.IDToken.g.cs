
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IDToken
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jti")]
        public string? Jti { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp")]
        public long? Exp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbf")]
        public long? Nbf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iat")]
        public long? Iat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iss")]
        public string? Iss { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        public string? Sub { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typ")]
        public string? Typ { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azp")]
        public string? Azp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otherClaims")]
        public object? OtherClaims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_time")]
        public long? AuthTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sid")]
        public string? Sid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at_hash")]
        public string? AtHash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c_hash")]
        public string? CHash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("given_name")]
        public string? GivenName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family_name")]
        public string? FamilyName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_name")]
        public string? MiddleName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_username")]
        public string? PreferredUsername { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("birthdate")]
        public string? Birthdate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoneinfo")]
        public string? Zoneinfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_verified")]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims_locales")]
        public string? ClaimsLocales { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acr")]
        public string? Acr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s_hash")]
        public string? SHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDToken" /> class.
        /// </summary>
        /// <param name="jti"></param>
        /// <param name="exp"></param>
        /// <param name="nbf"></param>
        /// <param name="iat"></param>
        /// <param name="iss"></param>
        /// <param name="sub"></param>
        /// <param name="typ"></param>
        /// <param name="azp"></param>
        /// <param name="otherClaims"></param>
        /// <param name="nonce"></param>
        /// <param name="authTime"></param>
        /// <param name="sid"></param>
        /// <param name="atHash"></param>
        /// <param name="cHash"></param>
        /// <param name="name"></param>
        /// <param name="givenName"></param>
        /// <param name="familyName"></param>
        /// <param name="middleName"></param>
        /// <param name="nickname"></param>
        /// <param name="preferredUsername"></param>
        /// <param name="profile"></param>
        /// <param name="picture"></param>
        /// <param name="website"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="gender"></param>
        /// <param name="birthdate"></param>
        /// <param name="zoneinfo"></param>
        /// <param name="locale"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="phoneNumberVerified"></param>
        /// <param name="updatedAt"></param>
        /// <param name="claimsLocales"></param>
        /// <param name="acr"></param>
        /// <param name="sHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDToken(
            string? jti,
            long? exp,
            long? nbf,
            long? iat,
            string? iss,
            string? sub,
            string? typ,
            string? azp,
            object? otherClaims,
            string? nonce,
            long? authTime,
            string? sid,
            string? atHash,
            string? cHash,
            string? name,
            string? givenName,
            string? familyName,
            string? middleName,
            string? nickname,
            string? preferredUsername,
            string? profile,
            string? picture,
            string? website,
            string? email,
            bool? emailVerified,
            string? gender,
            string? birthdate,
            string? zoneinfo,
            string? locale,
            string? phoneNumber,
            bool? phoneNumberVerified,
            long? updatedAt,
            string? claimsLocales,
            string? acr,
            string? sHash)
        {
            this.Jti = jti;
            this.Exp = exp;
            this.Nbf = nbf;
            this.Iat = iat;
            this.Iss = iss;
            this.Sub = sub;
            this.Typ = typ;
            this.Azp = azp;
            this.OtherClaims = otherClaims;
            this.Nonce = nonce;
            this.AuthTime = authTime;
            this.Sid = sid;
            this.AtHash = atHash;
            this.CHash = cHash;
            this.Name = name;
            this.GivenName = givenName;
            this.FamilyName = familyName;
            this.MiddleName = middleName;
            this.Nickname = nickname;
            this.PreferredUsername = preferredUsername;
            this.Profile = profile;
            this.Picture = picture;
            this.Website = website;
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.Zoneinfo = zoneinfo;
            this.Locale = locale;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberVerified = phoneNumberVerified;
            this.UpdatedAt = updatedAt;
            this.ClaimsLocales = claimsLocales;
            this.Acr = acr;
            this.SHash = sHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDToken" /> class.
        /// </summary>
        public IDToken()
        {
        }

    }
}