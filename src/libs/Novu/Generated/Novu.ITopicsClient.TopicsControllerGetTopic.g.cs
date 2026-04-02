#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Retrieve a topic<br/>
        /// Retrieve a topic by its unique key identifier **topicKey**
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerGetTopicResponse> TopicsControllerGetTopicAsync(
            string topicKey,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a topic<br/>
        /// Retrieve a topic by its unique key identifier **topicKey**
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerGetTopicResponse>> TopicsControllerGetTopicAsResponseAsync(
            string topicKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}