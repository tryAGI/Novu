#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Create topic subscriptions<br/>
        /// This api will create subscription for subscriberIds for a topic. <br/>
        ///       Its like subscribing to a common interest group. if topic does not exist, it will be created.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerCreateTopicSubscriptionsResponse> TopicsControllerCreateTopicSubscriptionsAsync(
            string topicKey,

            global::Novu.CreateTopicSubscriptionsRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create topic subscriptions<br/>
        /// This api will create subscription for subscriberIds for a topic. <br/>
        ///       Its like subscribing to a common interest group. if topic does not exist, it will be created.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerCreateTopicSubscriptionsResponse>> TopicsControllerCreateTopicSubscriptionsAsResponseAsync(
            string topicKey,

            global::Novu.CreateTopicSubscriptionsRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create topic subscriptions<br/>
        /// This api will create subscription for subscriberIds for a topic. <br/>
        ///       Its like subscribing to a common interest group. if topic does not exist, it will be created.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="subscriptions">
        /// List of subscriptions to subscribe to the topic (max: 100). Can be either a string array of subscriber IDs or an array of objects with identifier and subscriberId<br/>
        /// Example: [{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"identifier":"subscriber-456-subscription-b","subscriberId":"subscriber-456"}]
        /// </param>
        /// <param name="name">
        /// The name of the topic<br/>
        /// Example: My Topic
        /// </param>
        /// <param name="context"></param>
        /// <param name="preferences">
        /// The preferences of the topic. Can be a simple workflow ID string, workflow preference object, or group filter object<br/>
        /// Example: [{"workflowId":"workflow-123","condition":{"===":[{"var":"tier"},"premium"]}}]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerCreateTopicSubscriptionsResponse> TopicsControllerCreateTopicSubscriptionsAsync(
            string topicKey,
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? subscriptions = default,
            string? name = default,
            object? context = default,
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? preferences = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}