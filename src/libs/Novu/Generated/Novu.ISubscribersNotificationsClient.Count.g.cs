#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Retrieve subscriber notifications count<br/>
        /// Retrieve count of in-app (inbox) notifications for a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     Supports multiple filters to count in-app (inbox) notifications by different criteria, including context keys.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse> CountAsync(
            string subscriberId,
            string filters,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve subscriber notifications count<br/>
        /// Retrieve count of in-app (inbox) notifications for a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     Supports multiple filters to count in-app (inbox) notifications by different criteria, including context keys.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse>> CountAsResponseAsync(
            string subscriberId,
            string filters,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}