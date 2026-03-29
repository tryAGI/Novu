
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTopicSubscriptionsRequestDto
    {
        /// <summary>
        /// List of subscriber identifiers to unsubscribe from the topic (max: 100). @deprecated Use the "subscriptions" property instead.<br/>
        /// Example: [subscriberId1, subscriberId2]
        /// </summary>
        /// <example>[subscriberId1, subscriberId2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberIds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SubscriberIds { get; set; }

        /// <summary>
        /// List of subscriptions to unsubscribe from the topic (max: 100). Can be either a string array of subscriber IDs or an array of objects with identifier and/or subscriberId. If only subscriberId is provided, all subscriptions for that subscriber within the topic will be deleted.<br/>
        /// Example: [{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"subscriberId":"subscriber-456"}, {"identifier":"subscriber-789-subscription-b"}]
        /// </summary>
        /// <example>[{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"subscriberId":"subscriber-456"}, {"identifier":"subscriber-789-subscription-b"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? Subscriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicSubscriptionsRequestDto" /> class.
        /// </summary>
        /// <param name="subscriptions">
        /// List of subscriptions to unsubscribe from the topic (max: 100). Can be either a string array of subscriber IDs or an array of objects with identifier and/or subscriberId. If only subscriberId is provided, all subscriptions for that subscriber within the topic will be deleted.<br/>
        /// Example: [{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"subscriberId":"subscriber-456"}, {"identifier":"subscriber-789-subscription-b"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTopicSubscriptionsRequestDto(
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? subscriptions)
        {
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTopicSubscriptionsRequestDto" /> class.
        /// </summary>
        public DeleteTopicSubscriptionsRequestDto()
        {
        }
    }
}