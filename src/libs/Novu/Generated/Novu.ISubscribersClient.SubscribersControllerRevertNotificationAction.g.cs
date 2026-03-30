#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Revert notification action<br/>
        /// Revert a notification action (primary or secondary) to pending state by its unique identifier **notificationId** and action type.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="actionType"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.InboxNotificationDto> SubscribersControllerRevertNotificationActionAsync(
            string subscriberId,
            string notificationId,
            global::Novu.SubscribersControllerRevertNotificationActionActionType actionType,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}