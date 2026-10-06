
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserFederationProviderRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerName")]
        public string? ProviderName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::System.Collections.Generic.Dictionary<string, string>? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullSyncPeriod")]
        public int? FullSyncPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changedSyncPeriod")]
        public int? ChangedSyncPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSync")]
        public int? LastSync { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFederationProviderRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="providerName"></param>
        /// <param name="config"></param>
        /// <param name="priority"></param>
        /// <param name="fullSyncPeriod"></param>
        /// <param name="changedSyncPeriod"></param>
        /// <param name="lastSync"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserFederationProviderRepresentation(
            string? id,
            string? displayName,
            string? providerName,
            global::System.Collections.Generic.Dictionary<string, string>? config,
            int? priority,
            int? fullSyncPeriod,
            int? changedSyncPeriod,
            int? lastSync)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.ProviderName = providerName;
            this.Config = config;
            this.Priority = priority;
            this.FullSyncPeriod = fullSyncPeriod;
            this.ChangedSyncPeriod = changedSyncPeriod;
            this.LastSync = lastSync;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFederationProviderRepresentation" /> class.
        /// </summary>
        public UserFederationProviderRepresentation()
        {
        }

    }
}