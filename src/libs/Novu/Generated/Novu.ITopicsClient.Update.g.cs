#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Update a topic<br/>
        /// Update a topic name by its unique key identifier **topicKey**
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpdateTopicResponse> UpdateAsync(
            string topicKey,

            global::Novu.UpdateTopicRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a topic<br/>
        /// Update a topic name by its unique key identifier **topicKey**
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerUpdateTopicResponse>> UpdateAsResponseAsync(
            string topicKey,

            global::Novu.UpdateTopicRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a topic<br/>
        /// Update a topic name by its unique key identifier **topicKey**
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="name">
        /// The display name for the topic<br/>
        /// Example: Updated Topic Name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpdateTopicResponse> UpdateAsync(
            string topicKey,
            string name,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}