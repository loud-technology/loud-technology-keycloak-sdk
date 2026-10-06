
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealmEventsConfigRepresentation
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealmEventsConfigRepresentation" /> class.
        /// </summary>
        /// <param name="eventsEnabled"></param>
        /// <param name="eventsExpiration"></param>
        /// <param name="eventsListeners"></param>
        /// <param name="enabledEventTypes"></param>
        /// <param name="adminEventsEnabled"></param>
        /// <param name="adminEventsDetailsEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealmEventsConfigRepresentation(
            bool? eventsEnabled,
            long? eventsExpiration,
            global::System.Collections.Generic.IList<string>? eventsListeners,
            global::System.Collections.Generic.IList<string>? enabledEventTypes,
            bool? adminEventsEnabled,
            bool? adminEventsDetailsEnabled)
        {
            this.EventsEnabled = eventsEnabled;
            this.EventsExpiration = eventsExpiration;
            this.EventsListeners = eventsListeners;
            this.EnabledEventTypes = enabledEventTypes;
            this.AdminEventsEnabled = adminEventsEnabled;
            this.AdminEventsDetailsEnabled = adminEventsDetailsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealmEventsConfigRepresentation" /> class.
        /// </summary>
        public RealmEventsConfigRepresentation()
        {
        }

    }
}