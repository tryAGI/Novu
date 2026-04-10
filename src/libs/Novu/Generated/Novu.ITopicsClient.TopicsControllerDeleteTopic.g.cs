#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Delete a topic<br/>
        /// Delete a topic by its unique key identifier **topicKey**. <br/>
        ///     This action is irreversible and will remove all subscriptions to the topic.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerDeleteTopicResponse> TopicsControllerDeleteTopicAsync(
            string topicKey,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a topic<br/>
        /// Delete a topic by its unique key identifier **topicKey**. <br/>
        ///     This action is irreversible and will remove all subscriptions to the topic.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerDeleteTopicResponse>> TopicsControllerDeleteTopicAsResponseAsync(
            string topicKey,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}