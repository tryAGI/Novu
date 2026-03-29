#nullable enable

namespace Novu
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Cancel triggered event<br/>
        ///     Using a previously generated transactionId during the event trigger,<br/>
        ///      will cancel any active or pending workflows. This is useful to cancel active digests, delays etc...<br/>
        ///     
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> EventsControllerCancelAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}