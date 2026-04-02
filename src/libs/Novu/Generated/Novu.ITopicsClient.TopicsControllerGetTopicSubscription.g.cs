#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Retrieve a topic subscription<br/>
        /// Retrieve a subscription by its unique identifier for a topic.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="identifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerGetTopicSubscriptionResponse> TopicsControllerGetTopicSubscriptionAsync(
            string topicKey,
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a topic subscription<br/>
        /// Retrieve a subscription by its unique identifier for a topic.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="identifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerGetTopicSubscriptionResponse>> TopicsControllerGetTopicSubscriptionAsResponseAsync(
            string topicKey,
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}