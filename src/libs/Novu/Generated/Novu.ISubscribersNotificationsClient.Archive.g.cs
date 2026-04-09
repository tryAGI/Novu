#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Archive a notification<br/>
        /// Archive a specific in-app (inbox) notification by its unique identifier **notificationId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.InboxNotificationDto> ArchiveAsync(
            string subscriberId,
            string notificationId,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive a notification<br/>
        /// Archive a specific in-app (inbox) notification by its unique identifier **notificationId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.InboxNotificationDto>> ArchiveAsResponseAsync(
            string subscriberId,
            string notificationId,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}