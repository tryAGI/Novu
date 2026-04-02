#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Update a topic subscription<br/>
        /// Update a subscription by its unique identifier for a topic. You can update the preferences and name associated with the subscription.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpdateTopicSubscriptionResponse> TopicsControllerUpdateTopicSubscriptionAsync(
            string topicKey,
            string identifier,

            global::Novu.UpdateTopicSubscriptionRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a topic subscription<br/>
        /// Update a subscription by its unique identifier for a topic. You can update the preferences and name associated with the subscription.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerUpdateTopicSubscriptionResponse>> TopicsControllerUpdateTopicSubscriptionAsResponseAsync(
            string topicKey,
            string identifier,

            global::Novu.UpdateTopicSubscriptionRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a topic subscription<br/>
        /// Update a subscription by its unique identifier for a topic. You can update the preferences and name associated with the subscription.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="identifier"></param>
        /// <param name="name">
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </param>
        /// <param name="preferences">
        /// The preferences of the topic. Can be a simple workflow ID string, workflow preference object, or group filter object<br/>
        /// Example: [{"workflowId":"workflow-123","condition":{"===":[{"var":"tier"},"premium"]}}]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpdateTopicSubscriptionResponse> TopicsControllerUpdateTopicSubscriptionAsync(
            string topicKey,
            string identifier,
            string? name = default,
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? preferences = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}