#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// List topic subscriptions<br/>
        /// List all subscriptions of subscribers for a topic.<br/>
        ///     Checkout all available filters in the query section.
        /// </summary>
        /// <param name="topicKey"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="subscriberId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerListTopicSubscriptionsResponse> TopicsControllerListTopicSubscriptionsAsync(
            string topicKey,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? subscriberId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}