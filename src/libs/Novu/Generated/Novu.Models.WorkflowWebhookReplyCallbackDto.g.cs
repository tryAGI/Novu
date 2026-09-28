
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowWebhookReplyCallbackDto
    {
        /// <summary>
        /// Whether reply callbacks are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Reply callback URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWebhookReplyCallbackDto" /> class.
        /// </summary>
        /// <param name="active">
        /// Whether reply callbacks are enabled
        /// </param>
        /// <param name="url">
        /// Reply callback URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowWebhookReplyCallbackDto(
            bool active,
            string url)
        {
            this.Active = active;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWebhookReplyCallbackDto" /> class.
        /// </summary>
        public WorkflowWebhookReplyCallbackDto()
        {
        }

    }
}