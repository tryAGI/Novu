
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriberNotificationsResponseDto
    {
        /// <summary>
        /// Array of notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto> Data { get; set; }

        /// <summary>
        /// Indicates if there are more notifications available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The filter applied to the notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriberNotificationsResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of notifications
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more notifications available
        /// </param>
        /// <param name="filter">
        /// The filter applied to the notifications
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSubscriberNotificationsResponseDto(
            global::System.Collections.Generic.IList<global::Novu.InboxNotificationDto> data,
            bool hasMore,
            object filter)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriberNotificationsResponseDto" /> class.
        /// </summary>
        public GetSubscriberNotificationsResponseDto()
        {
        }
    }
}