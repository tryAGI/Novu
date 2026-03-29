#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Check topic subscriber<br/>
        /// Check if a subscriber belongs to a certain topic
        /// </summary>
        /// <param name="externalSubscriberId"></param>
        /// <param name="topicKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicSubscriberDto> TopicsV1ControllerGetTopicSubscriberAsync(
            string externalSubscriberId,
            string topicKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}