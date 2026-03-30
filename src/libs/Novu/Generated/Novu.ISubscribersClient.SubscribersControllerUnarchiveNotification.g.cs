#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Unarchive notification<br/>
        /// Unarchive a specific notification by its unique identifier **notificationId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.InboxNotificationDto> SubscribersControllerUnarchiveNotificationAsync(
            string subscriberId,
            string notificationId,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}