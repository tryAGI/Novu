
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkSubscriberNotificationsAsSeenDto
    {
        /// <summary>
        /// Specific notification IDs to mark as seen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationIds")]
        public global::System.Collections.Generic.IList<string>? NotificationIds { get; set; }

        /// <summary>
        /// Filter notifications by workflow tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Filter notifications by data attributes (JSON string)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Context keys for filtering notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkSubscriberNotificationsAsSeenDto" /> class.
        /// </summary>
        /// <param name="notificationIds">
        /// Specific notification IDs to mark as seen
        /// </param>
        /// <param name="tags">
        /// Filter notifications by workflow tags
        /// </param>
        /// <param name="data">
        /// Filter notifications by data attributes (JSON string)
        /// </param>
        /// <param name="contextKeys">
        /// Context keys for filtering notifications
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkSubscriberNotificationsAsSeenDto(
            global::System.Collections.Generic.IList<string>? notificationIds,
            global::System.Collections.Generic.IList<string>? tags,
            string? data,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.NotificationIds = notificationIds;
            this.Tags = tags;
            this.Data = data;
            this.ContextKeys = contextKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkSubscriberNotificationsAsSeenDto" /> class.
        /// </summary>
        public MarkSubscriberNotificationsAsSeenDto()
        {
        }
    }
}