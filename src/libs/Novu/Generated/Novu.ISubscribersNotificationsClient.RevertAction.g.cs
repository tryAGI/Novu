#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Revert a notification action<br/>
        /// Revert a single in-app (inbox) notification's action (primary or secondary) to pending state by its unique identifier **notificationId** and action type **actionType**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="actionType"></param>
        /// <param name="contextKeys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.InboxNotificationDto> RevertActionAsync(
            string subscriberId,
            string notificationId,
            global::Novu.SubscribersControllerRevertNotificationActionActionType actionType,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revert a notification action<br/>
        /// Revert a single in-app (inbox) notification's action (primary or secondary) to pending state by its unique identifier **notificationId** and action type **actionType**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="actionType"></param>
        /// <param name="contextKeys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.InboxNotificationDto>> RevertActionAsResponseAsync(
            string subscriberId,
            string notificationId,
            global::Novu.SubscribersControllerRevertNotificationActionActionType actionType,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}