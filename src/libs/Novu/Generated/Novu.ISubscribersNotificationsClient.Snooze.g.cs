#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Snooze a notification<br/>
        /// Snooze a specific in-app (inbox) notification by its unique identifier **notificationId** until a specified time.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.InboxNotificationDto> SnoozeAsync(
            string subscriberId,
            string notificationId,

            global::Novu.SnoozeSubscriberNotificationDto request,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snooze a notification<br/>
        /// Snooze a specific in-app (inbox) notification by its unique identifier **notificationId** until a specified time.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.InboxNotificationDto>> SnoozeAsResponseAsync(
            string subscriberId,
            string notificationId,

            global::Novu.SnoozeSubscriberNotificationDto request,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snooze a notification<br/>
        /// Snooze a specific in-app (inbox) notification by its unique identifier **notificationId** until a specified time.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="snoozeUntil">
        /// The date and time until which the notification should be snoozed<br/>
        /// Example: 2026-03-01T10:00:00Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.InboxNotificationDto> SnoozeAsync(
            string subscriberId,
            string notificationId,
            global::System.DateTime snoozeUntil,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}