#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Delete topic subscriptions<br/>
        /// Delete subscriptions for subscriberIds for a topic.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DeleteTopicSubscriptionsResponseDto> TopicsControllerDeleteTopicSubscriptionsAsync(
            string topicKey,

            global::Novu.DeleteTopicSubscriptionsRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete topic subscriptions<br/>
        /// Delete subscriptions for subscriberIds for a topic.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="subscriptions">
        /// List of subscriptions to unsubscribe from the topic (max: 100). Can be either a string array of subscriber IDs or an array of objects with identifier and/or subscriberId. If only subscriberId is provided, all subscriptions for that subscriber within the topic will be deleted.<br/>
        /// Example: [{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"subscriberId":"subscriber-456"}, {"identifier":"subscriber-789-subscription-b"}]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DeleteTopicSubscriptionsResponseDto> TopicsControllerDeleteTopicSubscriptionsAsync(
            string topicKey,
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.DeleteTopicSubscriberIdentifierDto>>? subscriptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}