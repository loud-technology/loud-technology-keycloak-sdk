
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Confirmation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x5t#S256")]
        public string? X5t_S256 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jkt")]
        public string? Jkt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kc-jkt-type")]
        public string? KcJktType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Confirmation" /> class.
        /// </summary>
        /// <param name="x5t_S256"></param>
        /// <param name="jkt"></param>
        /// <param name="kcJktType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Confirmation(
            string? x5t_S256,
            string? jkt,
            string? kcJktType)
        {
            this.X5t_S256 = x5t_S256;
            this.Jkt = jkt;
            this.KcJktType = kcJktType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Confirmation" /> class.
        /// </summary>
        public Confirmation()
        {
        }

    }
}