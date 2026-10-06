
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminEventRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public long? Time { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realmId")]
        public string? RealmId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authDetails")]
        public global::Loud.Technology.Keycloak.Sdk.AuthDetailsRepresentation? AuthDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationType")]
        public string? OperationType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        public string? ResourceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourcePath")]
        public string? ResourcePath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representation")]
        public string? Representation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.Dictionary<string, string>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminEventRepresentation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <param name="realmId"></param>
        /// <param name="authDetails"></param>
        /// <param name="operationType"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourcePath"></param>
        /// <param name="representation"></param>
        /// <param name="error"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminEventRepresentation(
            string? id,
            long? time,
            string? realmId,
            global::Loud.Technology.Keycloak.Sdk.AuthDetailsRepresentation? authDetails,
            string? operationType,
            string? resourceType,
            string? resourcePath,
            string? representation,
            string? error,
            global::System.Collections.Generic.Dictionary<string, string>? details)
        {
            this.Id = id;
            this.Time = time;
            this.RealmId = realmId;
            this.AuthDetails = authDetails;
            this.OperationType = operationType;
            this.ResourceType = resourceType;
            this.ResourcePath = resourcePath;
            this.Representation = representation;
            this.Error = error;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminEventRepresentation" /> class.
        /// </summary>
        public AdminEventRepresentation()
        {
        }

    }
}