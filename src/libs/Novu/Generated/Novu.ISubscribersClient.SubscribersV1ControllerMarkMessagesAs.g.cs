#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Update notifications state<br/>
        /// Update subscriber's multiple in-app (inbox) notifications state such as seen, read, unseen or unread by **subscriberId**. <br/>
        ///       **messageId** is of type mongodbId of notifications
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerMarkMessagesAsResponse> SubscribersV1ControllerMarkMessagesAsAsync(
            string subscriberId,

            global::Novu.MessageMarkAsRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update notifications state<br/>
        /// Update subscriber's multiple in-app (inbox) notifications state such as seen, read, unseen or unread by **subscriberId**. <br/>
        ///       **messageId** is of type mongodbId of notifications
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="messageId"></param>
        /// <param name="markAs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerMarkMessagesAsResponse> SubscribersV1ControllerMarkMessagesAsAsync(
            string subscriberId,
            global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>> messageId,
            global::Novu.MessageMarkAsRequestDtoMarkAs markAs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}