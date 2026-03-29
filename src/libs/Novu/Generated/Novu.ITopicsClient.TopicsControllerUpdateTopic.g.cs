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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpdateTopicResponse> TopicsControllerUpdateTopicAsync(
            string topicKey,

            global::Novu.UpdateTopicRequestDto request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerUpdateTopicResponse> TopicsControllerUpdateTopicAsync(
            string topicKey,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}