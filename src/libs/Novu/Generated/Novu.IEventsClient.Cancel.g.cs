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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> CancelAsync(
            string transactionId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel triggered event<br/>
        ///     Using a previously generated transactionId during the event trigger,<br/>
        ///      will cancel any active or pending workflows. This is useful to cancel active digests, delays etc...<br/>
        ///     
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<bool>> CancelAsResponseAsync(
            string transactionId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}