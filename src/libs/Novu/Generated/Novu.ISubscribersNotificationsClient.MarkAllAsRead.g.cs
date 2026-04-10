#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Mark all notifications as read<br/>
        /// Mark all in-app (inbox) notifications matching the specified filters as read. Supports context-based filtering.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task MarkAllAsReadAsync(
            string subscriberId,

            global::Novu.UpdateAllSubscriberNotificationsDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mark all notifications as read<br/>
        /// Mark all in-app (inbox) notifications matching the specified filters as read. Supports context-based filtering.
        /// </summary>
        /// <param name="subscriberId"></param>
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
        global::System.Threading.Tasks.Task MarkAllAsReadAsync(
            string subscriberId,
            object? tags = default,
            string? data = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}