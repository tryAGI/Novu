#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Update subscriber online status<br/>
        /// Update the subscriber online status by its unique key identifier **subscriberId**
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse> SubscribersV1ControllerUpdateSubscriberOnlineFlagAsync(
            string subscriberId,

            global::Novu.UpdateSubscriberOnlineFlagRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update subscriber online status<br/>
        /// Update the subscriber online status by its unique key identifier **subscriberId**
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="isOnline"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse> SubscribersV1ControllerUpdateSubscriberOnlineFlagAsync(
            string subscriberId,
            bool isOnline,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}