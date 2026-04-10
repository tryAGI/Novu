#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Mark notifications as seen<br/>
        /// Mark specific and multiple in-app (inbox) notifications as seen. Supports context-based filtering.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task MarkAsSeenAsync(
            string subscriberId,

            global::Novu.MarkSubscriberNotificationsAsSeenDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mark notifications as seen<br/>
        /// Mark specific and multiple in-app (inbox) notifications as seen. Supports context-based filtering.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="notificationIds">
        /// Specific notification IDs to mark as seen
        /// </param>
        /// <param name="tags">
        /// Filter notifications by workflow tags (OR for string[], or { and: [{ or: string[] }, ...] } for AND of OR-groups).
        /// </param>
        /// <param name="data">
        /// Filter notifications by data attributes (JSON string)
        /// </param>
        /// <param name="contextKeys">
        /// Context keys for filtering notifications
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task MarkAsSeenAsync(
            string subscriberId,
            global::System.Collections.Generic.IList<string>? notificationIds = default,
            object? tags = default,
            string? data = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}