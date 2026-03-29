
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateSubscriberPreferenceItemDto
    {
        /// <summary>
        /// Channel-specific preference settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PatchPreferenceChannelsDto Channels { get; set; }

        /// <summary>
        /// Workflow internal _id, identifier or slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSubscriberPreferenceItemDto" /> class.
        /// </summary>
        /// <param name="channels">
        /// Channel-specific preference settings
        /// </param>
        /// <param name="workflowId">
        /// Workflow internal _id, identifier or slug
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateSubscriberPreferenceItemDto(
            global::Novu.PatchPreferenceChannelsDto channels,
            string workflowId)
        {
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSubscriberPreferenceItemDto" /> class.
        /// </summary>
        public BulkUpdateSubscriberPreferenceItemDto()
        {
        }
    }
}