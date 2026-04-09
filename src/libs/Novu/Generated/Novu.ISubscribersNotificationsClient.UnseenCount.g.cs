#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Retrieve unseen notifications count<br/>
        /// Retrieve unseen in-app (inbox) notifications count for a subscriber by its unique key identifier **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="seen">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerGetUnseenCountResponse> UnseenCountAsync(
            string subscriberId,
            bool? seen = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve unseen notifications count<br/>
        /// Retrieve unseen in-app (inbox) notifications count for a subscriber by its unique key identifier **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="seen">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersV1ControllerGetUnseenCountResponse>> UnseenCountAsResponseAsync(
            string subscriberId,
            bool? seen = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}