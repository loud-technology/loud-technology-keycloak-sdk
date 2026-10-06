
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GlobalRequestResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successRequests")]
        public global::System.Collections.Generic.IList<string>? SuccessRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedRequests")]
        public global::System.Collections.Generic.IList<string>? FailedRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalRequestResult" /> class.
        /// </summary>
        /// <param name="successRequests"></param>
        /// <param name="failedRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlobalRequestResult(
            global::System.Collections.Generic.IList<string>? successRequests,
            global::System.Collections.Generic.IList<string>? failedRequests)
        {
            this.SuccessRequests = successRequests;
            this.FailedRequests = failedRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalRequestResult" /> class.
        /// </summary>
        public GlobalRequestResult()
        {
        }

    }
}