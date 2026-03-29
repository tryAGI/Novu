
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityTopicDto
    {
        /// <summary>
        /// Internal Topic ID of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_topicId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicId { get; set; }

        /// <summary>
        /// Topic Key of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTopicDto" /> class.
        /// </summary>
        /// <param name="topicId">
        /// Internal Topic ID of the notification
        /// </param>
        /// <param name="topicKey">
        /// Topic Key of the notification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityTopicDto(
            string topicId,
            string topicKey)
        {
            this.TopicId = topicId ?? throw new global::System.ArgumentNullException(nameof(topicId));
            this.TopicKey = topicKey ?? throw new global::System.ArgumentNullException(nameof(topicKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTopicDto" /> class.
        /// </summary>
        public ActivityTopicDto()
        {
        }
    }
}