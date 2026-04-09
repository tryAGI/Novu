#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Retrieve subscriber notifications<br/>
        /// Retrieve subscriber in-app (inbox) notifications by its unique key identifier **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="page"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="read"></param>
        /// <param name="seen"></param>
        /// <param name="payload"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse> FeedAsync(
            string subscriberId,
            double? page = default,
            double? limit = default,
            bool? read = default,
            bool? seen = default,
            string? payload = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve subscriber notifications<br/>
        /// Retrieve subscriber in-app (inbox) notifications by its unique key identifier **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="page"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="read"></param>
        /// <param name="seen"></param>
        /// <param name="payload"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersV1ControllerGetNotificationsFeedResponse>> FeedAsResponseAsync(
            string subscriberId,
            double? page = default,
            double? limit = default,
            bool? read = default,
            bool? seen = default,
            string? payload = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}