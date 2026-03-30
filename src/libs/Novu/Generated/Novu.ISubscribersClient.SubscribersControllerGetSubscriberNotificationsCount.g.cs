#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Retrieve subscriber notifications count<br/>
        /// Retrieve count of notifications for a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     Supports multiple filters to count notifications by different criteria, including context keys.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerGetSubscriberNotificationsCountResponse> SubscribersControllerGetSubscriberNotificationsCountAsync(
            string subscriberId,
            string filters,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}