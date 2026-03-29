
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTopicSubscriberIdentifierDto
    {
        /// <summary>
        /// Unique identifier for this subscription. If provided, deletes only this specific subscription.<br/>
        /// Example: subscriber-123-subscription-a
        /// </summary>
        /// <example>subscriber-123-subscription-a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The subscriber ID. If provided without identifier, deletes all subscriptions for this subscriber within the topic.<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicSubscriberIdentifierDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Unique identifier for this subscription. If provided, deletes only this specific subscription.<br/>
        /// Example: subscriber-123-subscription-a
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID. If provided without identifier, deletes all subscriptions for this subscriber within the topic.<br/>
        /// Example: subscriber-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTopicSubscriberIdentifierDto(
            string? identifier,
            string? subscriberId)
        {
            this.Identifier = identifier;
            this.SubscriberId = subscriberId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicSubscriberIdentifierDto" /> class.
        /// </summary>
        public DeleteTopicSubscriberIdentifierDto()
        {
        }
    }
}