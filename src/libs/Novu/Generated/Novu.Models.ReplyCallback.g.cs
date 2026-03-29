
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplyCallback
    {
        /// <summary>
        /// Indicates whether the reply callback is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The URL to which replies should be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyCallback" /> class.
        /// </summary>
        /// <param name="active">
        /// Indicates whether the reply callback is active.
        /// </param>
        /// <param name="url">
        /// The URL to which replies should be sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyCallback(
            bool? active,
            string? url)
        {
            this.Active = active;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyCallback" /> class.
        /// </summary>
        public ReplyCallback()
        {
        }
    }
}