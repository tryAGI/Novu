#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Update all notifications state<br/>
        /// Update all subscriber in-app (inbox) notifications state such as read, unread, seen or unseen by **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> SubscribersV1ControllerMarkAllUnreadAsReadAsync(
            string subscriberId,

            global::Novu.MarkAllMessageAsRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update all notifications state<br/>
        /// Update all subscriber in-app (inbox) notifications state such as read, unread, seen or unseen by **subscriberId**.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="feedIdentifier">
        /// Optional feed identifier or array of feed identifiers
        /// </param>
        /// <param name="markAs">
        /// Mark all subscriber messages as read, unread, seen or unseen
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<double> SubscribersV1ControllerMarkAllUnreadAsReadAsync(
            string subscriberId,
            global::Novu.MarkAllMessageAsRequestDtoMarkAs markAs,
            global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? feedIdentifier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}