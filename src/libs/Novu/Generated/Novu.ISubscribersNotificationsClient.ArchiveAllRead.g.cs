#nullable enable

namespace Novu
{
    public partial interface ISubscribersNotificationsClient
    {
        /// <summary>
        /// Archive all read notifications<br/>
        /// Archive all read in-app (inbox) notifications matching the specified filters. Supports context-based filtering.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task ArchiveAllReadAsync(
            string subscriberId,

            global::Novu.UpdateAllSubscriberNotificationsDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive all read notifications<br/>
        /// Archive all read in-app (inbox) notifications matching the specified filters. Supports context-based filtering.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ArchiveAllReadAsync(
            string subscriberId,
            object? tags = default,
            string? data = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}