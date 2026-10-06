
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealmRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realm")]
        public string? Realm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayNameHtml")]
        public string? DisplayNameHtml { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notBefore")]
        public int? NotBefore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSignatureAlgorithm")]
        public string? DefaultSignatureAlgorithm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokeRefreshToken")]
        public bool? RevokeRefreshToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenMaxReuse")]
        public int? RefreshTokenMaxReuse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessTokenLifespan")]
        public int? AccessTokenLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessTokenLifespanForImplicitFlow")]
        public int? AccessTokenLifespanForImplicitFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoSessionIdleTimeout")]
        public int? SsoSessionIdleTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoSessionMaxLifespan")]
        public int? SsoSessionMaxLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoSessionIdleTimeoutRememberMe")]
        public int? SsoSessionIdleTimeoutRememberMe { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoSessionMaxLifespanRememberMe")]
        public int? SsoSessionMaxLifespanRememberMe { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offlineSessionIdleTimeout")]
        public int? OfflineSessionIdleTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offlineSessionMaxLifespanEnabled")]
        public bool? OfflineSessionMaxLifespanEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offlineSessionMaxLifespan")]
        public int? OfflineSessionMaxLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSessionIdleTimeout")]
        public int? ClientSessionIdleTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSessionMaxLifespan")]
        public int? ClientSessionMaxLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientOfflineSessionIdleTimeout")]
        public int? ClientOfflineSessionIdleTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientOfflineSessionMaxLifespan")]
        public int? ClientOfflineSessionMaxLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessCodeLifespan")]
        public int? AccessCodeLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessCodeLifespanUserAction")]
        public int? AccessCodeLifespanUserAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessCodeLifespanLogin")]
        public int? AccessCodeLifespanLogin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionTokenGeneratedByAdminLifespan")]
        public int? ActionTokenGeneratedByAdminLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionTokenGeneratedByUserLifespan")]
        public int? ActionTokenGeneratedByUserLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2DeviceCodeLifespan")]
        public int? Oauth2DeviceCodeLifespan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2DevicePollingInterval")]
        public int? Oauth2DevicePollingInterval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sslRequired")]
        public string? SslRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordCredentialGrantAllowed")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PasswordCredentialGrantAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationAllowed")]
        public bool? RegistrationAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationEmailAsUsername")]
        public bool? RegistrationEmailAsUsername { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rememberMe")]
        public bool? RememberMe { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifyEmail")]
        public bool? VerifyEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loginWithEmailAllowed")]
        public bool? LoginWithEmailAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicateEmailsAllowed")]
        public bool? DuplicateEmailsAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetPasswordAllowed")]
        public bool? ResetPasswordAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editUsernameAllowed")]
        public bool? EditUsernameAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userCacheEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UserCacheEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmCacheEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RealmCacheEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bruteForceProtected")]
        public bool? BruteForceProtected { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanentLockout")]
        public bool? PermanentLockout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTemporaryLockouts")]
        public int? MaxTemporaryLockouts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bruteForceStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Keycloak.Sdk.JsonConverters.BruteForceStrategyJsonConverter))]
        public global::Loud.Technology.Keycloak.Sdk.BruteForceStrategy? BruteForceStrategy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFailureWaitSeconds")]
        public int? MaxFailureWaitSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumQuickLoginWaitSeconds")]
        public int? MinimumQuickLoginWaitSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitIncrementSeconds")]
        public int? WaitIncrementSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quickLoginCheckMilliSeconds")]
        public long? QuickLoginCheckMilliSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDeltaTimeSeconds")]
        public int? MaxDeltaTimeSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureFactor")]
        public int? FailureFactor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSecondaryAuthFailures")]
        public int? MaxSecondaryAuthFailures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateKey")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PrivateKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PublicKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Certificate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeSecret")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CodeSecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::Loud.Technology.Keycloak.Sdk.RolesRepresentation? Roles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? Groups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoles")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? DefaultRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRole")]
        public global::Loud.Technology.Keycloak.Sdk.RoleRepresentation? DefaultRole { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminPermissionsClient")]
        public global::Loud.Technology.Keycloak.Sdk.ClientRepresentation? AdminPermissionsClient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultGroups")]
        public global::System.Collections.Generic.IList<string>? DefaultGroups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredCredentials")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RequiredCredentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordPolicy")]
        public string? PasswordPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyType")]
        public string? OtpPolicyType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyAlgorithm")]
        public string? OtpPolicyAlgorithm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyInitialCounter")]
        public int? OtpPolicyInitialCounter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyDigits")]
        public int? OtpPolicyDigits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyLookAheadWindow")]
        public int? OtpPolicyLookAheadWindow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyPeriod")]
        public int? OtpPolicyPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpPolicyCodeReusable")]
        public bool? OtpPolicyCodeReusable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpSupportedApplications")]
        public global::System.Collections.Generic.IList<string>? OtpSupportedApplications { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizationTexts")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? LocalizationTexts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyRpEntityName")]
        public string? WebAuthnPolicyRpEntityName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicySignatureAlgorithms")]
        public global::System.Collections.Generic.IList<string>? WebAuthnPolicySignatureAlgorithms { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyRpId")]
        public string? WebAuthnPolicyRpId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyAttestationConveyancePreference")]
        public string? WebAuthnPolicyAttestationConveyancePreference { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyAuthenticatorAttachment")]
        public string? WebAuthnPolicyAuthenticatorAttachment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyRequireResidentKey")]
        public string? WebAuthnPolicyRequireResidentKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyResidentKey")]
        public string? WebAuthnPolicyResidentKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyUserVerificationRequirement")]
        public string? WebAuthnPolicyUserVerificationRequirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyCreateTimeout")]
        public int? WebAuthnPolicyCreateTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyAvoidSameAuthenticatorRegister")]
        public bool? WebAuthnPolicyAvoidSameAuthenticatorRegister { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyAcceptableAaguids")]
        public global::System.Collections.Generic.IList<string>? WebAuthnPolicyAcceptableAaguids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyExtraOrigins")]
        public global::System.Collections.Generic.IList<string>? WebAuthnPolicyExtraOrigins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessRpEntityName")]
        public string? WebAuthnPolicyPasswordlessRpEntityName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessSignatureAlgorithms")]
        public global::System.Collections.Generic.IList<string>? WebAuthnPolicyPasswordlessSignatureAlgorithms { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessRpId")]
        public string? WebAuthnPolicyPasswordlessRpId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessAttestationConveyancePreference")]
        public string? WebAuthnPolicyPasswordlessAttestationConveyancePreference { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessAuthenticatorAttachment")]
        public string? WebAuthnPolicyPasswordlessAuthenticatorAttachment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessRequireResidentKey")]
        public string? WebAuthnPolicyPasswordlessRequireResidentKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessResidentKey")]
        public string? WebAuthnPolicyPasswordlessResidentKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessUserVerificationRequirement")]
        public string? WebAuthnPolicyPasswordlessUserVerificationRequirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessCreateTimeout")]
        public int? WebAuthnPolicyPasswordlessCreateTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister")]
        public bool? WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessAcceptableAaguids")]
        public global::System.Collections.Generic.IList<string>? WebAuthnPolicyPasswordlessAcceptableAaguids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessExtraOrigins")]
        public global::System.Collections.Generic.IList<string>? WebAuthnPolicyPasswordlessExtraOrigins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessPasskeysEnabled")]
        public bool? WebAuthnPolicyPasswordlessPasskeysEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthnPolicyPasswordlessMediation")]
        public string? WebAuthnPolicyPasswordlessMediation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientProfiles")]
        public global::Loud.Technology.Keycloak.Sdk.ClientProfilesRepresentation? ClientProfiles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientPolicies")]
        public global::Loud.Technology.Keycloak.Sdk.ClientPoliciesRepresentation? ClientPolicies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>? Users { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federatedUsers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>? FederatedUsers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeMappings")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>? ScopeMappings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientScopeMappings")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>>? ClientScopeMappings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clients")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>? Clients { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientScopes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientScopeRepresentation>? ClientScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDefaultClientScopes")]
        public global::System.Collections.Generic.IList<string>? DefaultDefaultClientScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultOptionalClientScopes")]
        public global::System.Collections.Generic.IList<string>? DefaultOptionalClientScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserSecurityHeaders")]
        public global::System.Collections.Generic.Dictionary<string, string>? BrowserSecurityHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtpServer")]
        public global::System.Collections.Generic.Dictionary<string, string>? SmtpServer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFederationProviders")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserFederationProviderRepresentation>? UserFederationProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFederationMappers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserFederationMapperRepresentation>? UserFederationMappers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loginTheme")]
        public string? LoginTheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountTheme")]
        public string? AccountTheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminTheme")]
        public string? AdminTheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailTheme")]
        public string? EmailTheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventsEnabled")]
        public bool? EventsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventsExpiration")]
        public long? EventsExpiration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventsListeners")]
        public global::System.Collections.Generic.IList<string>? EventsListeners { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledEventTypes")]
        public global::System.Collections.Generic.IList<string>? EnabledEventTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminEventsEnabled")]
        public bool? AdminEventsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminEventsDetailsEnabled")]
        public bool? AdminEventsDetailsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProviders")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>? IdentityProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityProviderMappers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderMapperRepresentation>? IdentityProviderMappers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolMappers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? ProtocolMappers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentExportRepresentation>>? Components { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internationalizationEnabled")]
        public bool? InternationalizationEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedLocales")]
        public global::System.Collections.Generic.IList<string>? SupportedLocales { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultLocale")]
        public string? DefaultLocale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationFlows")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticationFlowRepresentation>? AuthenticationFlows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticatorConfig")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticatorConfigRepresentation>? AuthenticatorConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredActions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RequiredActionProviderRepresentation>? RequiredActions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserFlow")]
        public string? BrowserFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationFlow")]
        public string? RegistrationFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directGrantFlow")]
        public string? DirectGrantFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetCredentialsFlow")]
        public string? ResetCredentialsFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientAuthenticationFlow")]
        public string? ClientAuthenticationFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerAuthenticationFlow")]
        public string? DockerAuthenticationFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstBrokerLoginFlow")]
        public string? FirstBrokerLoginFlow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keycloakVersion")]
        public string? KeycloakVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userManagedAccessAllowed")]
        public bool? UserManagedAccessAllowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationsEnabled")]
        public bool? OrganizationsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation>? Organizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiableCredentialsEnabled")]
        public bool? VerifiableCredentialsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminPermissionsEnabled")]
        public bool? AdminPermissionsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Social { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateProfileOnInitialSocialLogin")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UpdateProfileOnInitialSocialLogin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialProviders")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? SocialProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicationScopeMappings")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>>? ApplicationScopeMappings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applications")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ApplicationRepresentation>? Applications { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauthClients")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OAuthClientRepresentation>? OauthClients { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientTemplates")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientTemplateRepresentation>? ClientTemplates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scimApiEnabled")]
        public bool? ScimApiEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealmRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="realm"></param>
        /// <param name="displayName"></param>
        /// <param name="displayNameHtml"></param>
        /// <param name="notBefore"></param>
        /// <param name="defaultSignatureAlgorithm"></param>
        /// <param name="revokeRefreshToken"></param>
        /// <param name="refreshTokenMaxReuse"></param>
        /// <param name="accessTokenLifespan"></param>
        /// <param name="accessTokenLifespanForImplicitFlow"></param>
        /// <param name="ssoSessionIdleTimeout"></param>
        /// <param name="ssoSessionMaxLifespan"></param>
        /// <param name="ssoSessionIdleTimeoutRememberMe"></param>
        /// <param name="ssoSessionMaxLifespanRememberMe"></param>
        /// <param name="offlineSessionIdleTimeout"></param>
        /// <param name="offlineSessionMaxLifespanEnabled"></param>
        /// <param name="offlineSessionMaxLifespan"></param>
        /// <param name="clientSessionIdleTimeout"></param>
        /// <param name="clientSessionMaxLifespan"></param>
        /// <param name="clientOfflineSessionIdleTimeout"></param>
        /// <param name="clientOfflineSessionMaxLifespan"></param>
        /// <param name="accessCodeLifespan"></param>
        /// <param name="accessCodeLifespanUserAction"></param>
        /// <param name="accessCodeLifespanLogin"></param>
        /// <param name="actionTokenGeneratedByAdminLifespan"></param>
        /// <param name="actionTokenGeneratedByUserLifespan"></param>
        /// <param name="oauth2DeviceCodeLifespan"></param>
        /// <param name="oauth2DevicePollingInterval"></param>
        /// <param name="enabled"></param>
        /// <param name="sslRequired"></param>
        /// <param name="registrationAllowed"></param>
        /// <param name="registrationEmailAsUsername"></param>
        /// <param name="rememberMe"></param>
        /// <param name="verifyEmail"></param>
        /// <param name="loginWithEmailAllowed"></param>
        /// <param name="duplicateEmailsAllowed"></param>
        /// <param name="resetPasswordAllowed"></param>
        /// <param name="editUsernameAllowed"></param>
        /// <param name="bruteForceProtected"></param>
        /// <param name="permanentLockout"></param>
        /// <param name="maxTemporaryLockouts"></param>
        /// <param name="bruteForceStrategy"></param>
        /// <param name="maxFailureWaitSeconds"></param>
        /// <param name="minimumQuickLoginWaitSeconds"></param>
        /// <param name="waitIncrementSeconds"></param>
        /// <param name="quickLoginCheckMilliSeconds"></param>
        /// <param name="maxDeltaTimeSeconds"></param>
        /// <param name="failureFactor"></param>
        /// <param name="maxSecondaryAuthFailures"></param>
        /// <param name="roles"></param>
        /// <param name="groups"></param>
        /// <param name="defaultRole"></param>
        /// <param name="adminPermissionsClient"></param>
        /// <param name="defaultGroups"></param>
        /// <param name="passwordPolicy"></param>
        /// <param name="otpPolicyType"></param>
        /// <param name="otpPolicyAlgorithm"></param>
        /// <param name="otpPolicyInitialCounter"></param>
        /// <param name="otpPolicyDigits"></param>
        /// <param name="otpPolicyLookAheadWindow"></param>
        /// <param name="otpPolicyPeriod"></param>
        /// <param name="otpPolicyCodeReusable"></param>
        /// <param name="otpSupportedApplications"></param>
        /// <param name="localizationTexts"></param>
        /// <param name="webAuthnPolicyRpEntityName"></param>
        /// <param name="webAuthnPolicySignatureAlgorithms"></param>
        /// <param name="webAuthnPolicyRpId"></param>
        /// <param name="webAuthnPolicyAttestationConveyancePreference"></param>
        /// <param name="webAuthnPolicyAuthenticatorAttachment"></param>
        /// <param name="webAuthnPolicyRequireResidentKey"></param>
        /// <param name="webAuthnPolicyResidentKey"></param>
        /// <param name="webAuthnPolicyUserVerificationRequirement"></param>
        /// <param name="webAuthnPolicyCreateTimeout"></param>
        /// <param name="webAuthnPolicyAvoidSameAuthenticatorRegister"></param>
        /// <param name="webAuthnPolicyAcceptableAaguids"></param>
        /// <param name="webAuthnPolicyExtraOrigins"></param>
        /// <param name="webAuthnPolicyPasswordlessRpEntityName"></param>
        /// <param name="webAuthnPolicyPasswordlessSignatureAlgorithms"></param>
        /// <param name="webAuthnPolicyPasswordlessRpId"></param>
        /// <param name="webAuthnPolicyPasswordlessAttestationConveyancePreference"></param>
        /// <param name="webAuthnPolicyPasswordlessAuthenticatorAttachment"></param>
        /// <param name="webAuthnPolicyPasswordlessRequireResidentKey"></param>
        /// <param name="webAuthnPolicyPasswordlessResidentKey"></param>
        /// <param name="webAuthnPolicyPasswordlessUserVerificationRequirement"></param>
        /// <param name="webAuthnPolicyPasswordlessCreateTimeout"></param>
        /// <param name="webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister"></param>
        /// <param name="webAuthnPolicyPasswordlessAcceptableAaguids"></param>
        /// <param name="webAuthnPolicyPasswordlessExtraOrigins"></param>
        /// <param name="webAuthnPolicyPasswordlessPasskeysEnabled"></param>
        /// <param name="webAuthnPolicyPasswordlessMediation"></param>
        /// <param name="clientProfiles"></param>
        /// <param name="clientPolicies"></param>
        /// <param name="users"></param>
        /// <param name="federatedUsers"></param>
        /// <param name="scopeMappings"></param>
        /// <param name="clientScopeMappings"></param>
        /// <param name="clients"></param>
        /// <param name="clientScopes"></param>
        /// <param name="defaultDefaultClientScopes"></param>
        /// <param name="defaultOptionalClientScopes"></param>
        /// <param name="browserSecurityHeaders"></param>
        /// <param name="smtpServer"></param>
        /// <param name="userFederationProviders"></param>
        /// <param name="userFederationMappers"></param>
        /// <param name="loginTheme"></param>
        /// <param name="accountTheme"></param>
        /// <param name="adminTheme"></param>
        /// <param name="emailTheme"></param>
        /// <param name="eventsEnabled"></param>
        /// <param name="eventsExpiration"></param>
        /// <param name="eventsListeners"></param>
        /// <param name="enabledEventTypes"></param>
        /// <param name="adminEventsEnabled"></param>
        /// <param name="adminEventsDetailsEnabled"></param>
        /// <param name="identityProviders"></param>
        /// <param name="identityProviderMappers"></param>
        /// <param name="protocolMappers"></param>
        /// <param name="components"></param>
        /// <param name="internationalizationEnabled"></param>
        /// <param name="supportedLocales"></param>
        /// <param name="defaultLocale"></param>
        /// <param name="authenticationFlows"></param>
        /// <param name="authenticatorConfig"></param>
        /// <param name="requiredActions"></param>
        /// <param name="browserFlow"></param>
        /// <param name="registrationFlow"></param>
        /// <param name="directGrantFlow"></param>
        /// <param name="resetCredentialsFlow"></param>
        /// <param name="clientAuthenticationFlow"></param>
        /// <param name="dockerAuthenticationFlow"></param>
        /// <param name="firstBrokerLoginFlow"></param>
        /// <param name="attributes"></param>
        /// <param name="keycloakVersion"></param>
        /// <param name="userManagedAccessAllowed"></param>
        /// <param name="organizationsEnabled"></param>
        /// <param name="organizations"></param>
        /// <param name="verifiableCredentialsEnabled"></param>
        /// <param name="adminPermissionsEnabled"></param>
        /// <param name="scimApiEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealmRepresentation(
            string? id,
            string? realm,
            string? displayName,
            string? displayNameHtml,
            int? notBefore,
            string? defaultSignatureAlgorithm,
            bool? revokeRefreshToken,
            int? refreshTokenMaxReuse,
            int? accessTokenLifespan,
            int? accessTokenLifespanForImplicitFlow,
            int? ssoSessionIdleTimeout,
            int? ssoSessionMaxLifespan,
            int? ssoSessionIdleTimeoutRememberMe,
            int? ssoSessionMaxLifespanRememberMe,
            int? offlineSessionIdleTimeout,
            bool? offlineSessionMaxLifespanEnabled,
            int? offlineSessionMaxLifespan,
            int? clientSessionIdleTimeout,
            int? clientSessionMaxLifespan,
            int? clientOfflineSessionIdleTimeout,
            int? clientOfflineSessionMaxLifespan,
            int? accessCodeLifespan,
            int? accessCodeLifespanUserAction,
            int? accessCodeLifespanLogin,
            int? actionTokenGeneratedByAdminLifespan,
            int? actionTokenGeneratedByUserLifespan,
            int? oauth2DeviceCodeLifespan,
            int? oauth2DevicePollingInterval,
            bool? enabled,
            string? sslRequired,
            bool? registrationAllowed,
            bool? registrationEmailAsUsername,
            bool? rememberMe,
            bool? verifyEmail,
            bool? loginWithEmailAllowed,
            bool? duplicateEmailsAllowed,
            bool? resetPasswordAllowed,
            bool? editUsernameAllowed,
            bool? bruteForceProtected,
            bool? permanentLockout,
            int? maxTemporaryLockouts,
            global::Loud.Technology.Keycloak.Sdk.BruteForceStrategy? bruteForceStrategy,
            int? maxFailureWaitSeconds,
            int? minimumQuickLoginWaitSeconds,
            int? waitIncrementSeconds,
            long? quickLoginCheckMilliSeconds,
            int? maxDeltaTimeSeconds,
            int? failureFactor,
            int? maxSecondaryAuthFailures,
            global::Loud.Technology.Keycloak.Sdk.RolesRepresentation? roles,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.GroupRepresentation>? groups,
            global::Loud.Technology.Keycloak.Sdk.RoleRepresentation? defaultRole,
            global::Loud.Technology.Keycloak.Sdk.ClientRepresentation? adminPermissionsClient,
            global::System.Collections.Generic.IList<string>? defaultGroups,
            string? passwordPolicy,
            string? otpPolicyType,
            string? otpPolicyAlgorithm,
            int? otpPolicyInitialCounter,
            int? otpPolicyDigits,
            int? otpPolicyLookAheadWindow,
            int? otpPolicyPeriod,
            bool? otpPolicyCodeReusable,
            global::System.Collections.Generic.IList<string>? otpSupportedApplications,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? localizationTexts,
            string? webAuthnPolicyRpEntityName,
            global::System.Collections.Generic.IList<string>? webAuthnPolicySignatureAlgorithms,
            string? webAuthnPolicyRpId,
            string? webAuthnPolicyAttestationConveyancePreference,
            string? webAuthnPolicyAuthenticatorAttachment,
            string? webAuthnPolicyRequireResidentKey,
            string? webAuthnPolicyResidentKey,
            string? webAuthnPolicyUserVerificationRequirement,
            int? webAuthnPolicyCreateTimeout,
            bool? webAuthnPolicyAvoidSameAuthenticatorRegister,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyAcceptableAaguids,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyExtraOrigins,
            string? webAuthnPolicyPasswordlessRpEntityName,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyPasswordlessSignatureAlgorithms,
            string? webAuthnPolicyPasswordlessRpId,
            string? webAuthnPolicyPasswordlessAttestationConveyancePreference,
            string? webAuthnPolicyPasswordlessAuthenticatorAttachment,
            string? webAuthnPolicyPasswordlessRequireResidentKey,
            string? webAuthnPolicyPasswordlessResidentKey,
            string? webAuthnPolicyPasswordlessUserVerificationRequirement,
            int? webAuthnPolicyPasswordlessCreateTimeout,
            bool? webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyPasswordlessAcceptableAaguids,
            global::System.Collections.Generic.IList<string>? webAuthnPolicyPasswordlessExtraOrigins,
            bool? webAuthnPolicyPasswordlessPasskeysEnabled,
            string? webAuthnPolicyPasswordlessMediation,
            global::Loud.Technology.Keycloak.Sdk.ClientProfilesRepresentation? clientProfiles,
            global::Loud.Technology.Keycloak.Sdk.ClientPoliciesRepresentation? clientPolicies,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>? users,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserRepresentation>? federatedUsers,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>? scopeMappings,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ScopeMappingRepresentation>>? clientScopeMappings,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientRepresentation>? clients,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ClientScopeRepresentation>? clientScopes,
            global::System.Collections.Generic.IList<string>? defaultDefaultClientScopes,
            global::System.Collections.Generic.IList<string>? defaultOptionalClientScopes,
            global::System.Collections.Generic.Dictionary<string, string>? browserSecurityHeaders,
            global::System.Collections.Generic.Dictionary<string, string>? smtpServer,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserFederationProviderRepresentation>? userFederationProviders,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.UserFederationMapperRepresentation>? userFederationMappers,
            string? loginTheme,
            string? accountTheme,
            string? adminTheme,
            string? emailTheme,
            bool? eventsEnabled,
            long? eventsExpiration,
            global::System.Collections.Generic.IList<string>? eventsListeners,
            global::System.Collections.Generic.IList<string>? enabledEventTypes,
            bool? adminEventsEnabled,
            bool? adminEventsDetailsEnabled,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderRepresentation>? identityProviders,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.IdentityProviderMapperRepresentation>? identityProviderMappers,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ProtocolMapperRepresentation>? protocolMappers,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.ComponentExportRepresentation>>? components,
            bool? internationalizationEnabled,
            global::System.Collections.Generic.IList<string>? supportedLocales,
            string? defaultLocale,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticationFlowRepresentation>? authenticationFlows,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.AuthenticatorConfigRepresentation>? authenticatorConfig,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.RequiredActionProviderRepresentation>? requiredActions,
            string? browserFlow,
            string? registrationFlow,
            string? directGrantFlow,
            string? resetCredentialsFlow,
            string? clientAuthenticationFlow,
            string? dockerAuthenticationFlow,
            string? firstBrokerLoginFlow,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            string? keycloakVersion,
            bool? userManagedAccessAllowed,
            bool? organizationsEnabled,
            global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation>? organizations,
            bool? verifiableCredentialsEnabled,
            bool? adminPermissionsEnabled,
            bool? scimApiEnabled)
        {
            this.Id = id;
            this.Realm = realm;
            this.DisplayName = displayName;
            this.DisplayNameHtml = displayNameHtml;
            this.NotBefore = notBefore;
            this.DefaultSignatureAlgorithm = defaultSignatureAlgorithm;
            this.RevokeRefreshToken = revokeRefreshToken;
            this.RefreshTokenMaxReuse = refreshTokenMaxReuse;
            this.AccessTokenLifespan = accessTokenLifespan;
            this.AccessTokenLifespanForImplicitFlow = accessTokenLifespanForImplicitFlow;
            this.SsoSessionIdleTimeout = ssoSessionIdleTimeout;
            this.SsoSessionMaxLifespan = ssoSessionMaxLifespan;
            this.SsoSessionIdleTimeoutRememberMe = ssoSessionIdleTimeoutRememberMe;
            this.SsoSessionMaxLifespanRememberMe = ssoSessionMaxLifespanRememberMe;
            this.OfflineSessionIdleTimeout = offlineSessionIdleTimeout;
            this.OfflineSessionMaxLifespanEnabled = offlineSessionMaxLifespanEnabled;
            this.OfflineSessionMaxLifespan = offlineSessionMaxLifespan;
            this.ClientSessionIdleTimeout = clientSessionIdleTimeout;
            this.ClientSessionMaxLifespan = clientSessionMaxLifespan;
            this.ClientOfflineSessionIdleTimeout = clientOfflineSessionIdleTimeout;
            this.ClientOfflineSessionMaxLifespan = clientOfflineSessionMaxLifespan;
            this.AccessCodeLifespan = accessCodeLifespan;
            this.AccessCodeLifespanUserAction = accessCodeLifespanUserAction;
            this.AccessCodeLifespanLogin = accessCodeLifespanLogin;
            this.ActionTokenGeneratedByAdminLifespan = actionTokenGeneratedByAdminLifespan;
            this.ActionTokenGeneratedByUserLifespan = actionTokenGeneratedByUserLifespan;
            this.Oauth2DeviceCodeLifespan = oauth2DeviceCodeLifespan;
            this.Oauth2DevicePollingInterval = oauth2DevicePollingInterval;
            this.Enabled = enabled;
            this.SslRequired = sslRequired;
            this.RegistrationAllowed = registrationAllowed;
            this.RegistrationEmailAsUsername = registrationEmailAsUsername;
            this.RememberMe = rememberMe;
            this.VerifyEmail = verifyEmail;
            this.LoginWithEmailAllowed = loginWithEmailAllowed;
            this.DuplicateEmailsAllowed = duplicateEmailsAllowed;
            this.ResetPasswordAllowed = resetPasswordAllowed;
            this.EditUsernameAllowed = editUsernameAllowed;
            this.BruteForceProtected = bruteForceProtected;
            this.PermanentLockout = permanentLockout;
            this.MaxTemporaryLockouts = maxTemporaryLockouts;
            this.BruteForceStrategy = bruteForceStrategy;
            this.MaxFailureWaitSeconds = maxFailureWaitSeconds;
            this.MinimumQuickLoginWaitSeconds = minimumQuickLoginWaitSeconds;
            this.WaitIncrementSeconds = waitIncrementSeconds;
            this.QuickLoginCheckMilliSeconds = quickLoginCheckMilliSeconds;
            this.MaxDeltaTimeSeconds = maxDeltaTimeSeconds;
            this.FailureFactor = failureFactor;
            this.MaxSecondaryAuthFailures = maxSecondaryAuthFailures;
            this.Roles = roles;
            this.Groups = groups;
            this.DefaultRole = defaultRole;
            this.AdminPermissionsClient = adminPermissionsClient;
            this.DefaultGroups = defaultGroups;
            this.PasswordPolicy = passwordPolicy;
            this.OtpPolicyType = otpPolicyType;
            this.OtpPolicyAlgorithm = otpPolicyAlgorithm;
            this.OtpPolicyInitialCounter = otpPolicyInitialCounter;
            this.OtpPolicyDigits = otpPolicyDigits;
            this.OtpPolicyLookAheadWindow = otpPolicyLookAheadWindow;
            this.OtpPolicyPeriod = otpPolicyPeriod;
            this.OtpPolicyCodeReusable = otpPolicyCodeReusable;
            this.OtpSupportedApplications = otpSupportedApplications;
            this.LocalizationTexts = localizationTexts;
            this.WebAuthnPolicyRpEntityName = webAuthnPolicyRpEntityName;
            this.WebAuthnPolicySignatureAlgorithms = webAuthnPolicySignatureAlgorithms;
            this.WebAuthnPolicyRpId = webAuthnPolicyRpId;
            this.WebAuthnPolicyAttestationConveyancePreference = webAuthnPolicyAttestationConveyancePreference;
            this.WebAuthnPolicyAuthenticatorAttachment = webAuthnPolicyAuthenticatorAttachment;
            this.WebAuthnPolicyRequireResidentKey = webAuthnPolicyRequireResidentKey;
            this.WebAuthnPolicyResidentKey = webAuthnPolicyResidentKey;
            this.WebAuthnPolicyUserVerificationRequirement = webAuthnPolicyUserVerificationRequirement;
            this.WebAuthnPolicyCreateTimeout = webAuthnPolicyCreateTimeout;
            this.WebAuthnPolicyAvoidSameAuthenticatorRegister = webAuthnPolicyAvoidSameAuthenticatorRegister;
            this.WebAuthnPolicyAcceptableAaguids = webAuthnPolicyAcceptableAaguids;
            this.WebAuthnPolicyExtraOrigins = webAuthnPolicyExtraOrigins;
            this.WebAuthnPolicyPasswordlessRpEntityName = webAuthnPolicyPasswordlessRpEntityName;
            this.WebAuthnPolicyPasswordlessSignatureAlgorithms = webAuthnPolicyPasswordlessSignatureAlgorithms;
            this.WebAuthnPolicyPasswordlessRpId = webAuthnPolicyPasswordlessRpId;
            this.WebAuthnPolicyPasswordlessAttestationConveyancePreference = webAuthnPolicyPasswordlessAttestationConveyancePreference;
            this.WebAuthnPolicyPasswordlessAuthenticatorAttachment = webAuthnPolicyPasswordlessAuthenticatorAttachment;
            this.WebAuthnPolicyPasswordlessRequireResidentKey = webAuthnPolicyPasswordlessRequireResidentKey;
            this.WebAuthnPolicyPasswordlessResidentKey = webAuthnPolicyPasswordlessResidentKey;
            this.WebAuthnPolicyPasswordlessUserVerificationRequirement = webAuthnPolicyPasswordlessUserVerificationRequirement;
            this.WebAuthnPolicyPasswordlessCreateTimeout = webAuthnPolicyPasswordlessCreateTimeout;
            this.WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister = webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister;
            this.WebAuthnPolicyPasswordlessAcceptableAaguids = webAuthnPolicyPasswordlessAcceptableAaguids;
            this.WebAuthnPolicyPasswordlessExtraOrigins = webAuthnPolicyPasswordlessExtraOrigins;
            this.WebAuthnPolicyPasswordlessPasskeysEnabled = webAuthnPolicyPasswordlessPasskeysEnabled;
            this.WebAuthnPolicyPasswordlessMediation = webAuthnPolicyPasswordlessMediation;
            this.ClientProfiles = clientProfiles;
            this.ClientPolicies = clientPolicies;
            this.Users = users;
            this.FederatedUsers = federatedUsers;
            this.ScopeMappings = scopeMappings;
            this.ClientScopeMappings = clientScopeMappings;
            this.Clients = clients;
            this.ClientScopes = clientScopes;
            this.DefaultDefaultClientScopes = defaultDefaultClientScopes;
            this.DefaultOptionalClientScopes = defaultOptionalClientScopes;
            this.BrowserSecurityHeaders = browserSecurityHeaders;
            this.SmtpServer = smtpServer;
            this.UserFederationProviders = userFederationProviders;
            this.UserFederationMappers = userFederationMappers;
            this.LoginTheme = loginTheme;
            this.AccountTheme = accountTheme;
            this.AdminTheme = adminTheme;
            this.EmailTheme = emailTheme;
            this.EventsEnabled = eventsEnabled;
            this.EventsExpiration = eventsExpiration;
            this.EventsListeners = eventsListeners;
            this.EnabledEventTypes = enabledEventTypes;
            this.AdminEventsEnabled = adminEventsEnabled;
            this.AdminEventsDetailsEnabled = adminEventsDetailsEnabled;
            this.IdentityProviders = identityProviders;
            this.IdentityProviderMappers = identityProviderMappers;
            this.ProtocolMappers = protocolMappers;
            this.Components = components;
            this.InternationalizationEnabled = internationalizationEnabled;
            this.SupportedLocales = supportedLocales;
            this.DefaultLocale = defaultLocale;
            this.AuthenticationFlows = authenticationFlows;
            this.AuthenticatorConfig = authenticatorConfig;
            this.RequiredActions = requiredActions;
            this.BrowserFlow = browserFlow;
            this.RegistrationFlow = registrationFlow;
            this.DirectGrantFlow = directGrantFlow;
            this.ResetCredentialsFlow = resetCredentialsFlow;
            this.ClientAuthenticationFlow = clientAuthenticationFlow;
            this.DockerAuthenticationFlow = dockerAuthenticationFlow;
            this.FirstBrokerLoginFlow = firstBrokerLoginFlow;
            this.Attributes = attributes;
            this.KeycloakVersion = keycloakVersion;
            this.UserManagedAccessAllowed = userManagedAccessAllowed;
            this.OrganizationsEnabled = organizationsEnabled;
            this.Organizations = organizations;
            this.VerifiableCredentialsEnabled = verifiableCredentialsEnabled;
            this.AdminPermissionsEnabled = adminPermissionsEnabled;
            this.ScimApiEnabled = scimApiEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealmRepresentation" /> class.
        /// </summary>
        public RealmRepresentation()
        {
        }

    }
}