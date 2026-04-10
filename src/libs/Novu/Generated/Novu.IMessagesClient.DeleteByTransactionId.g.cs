#nullable enable

namespace Novu
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Delete messages by transactionId<br/>
        /// Delete multiple messages from the Novu platform using **transactionId** of triggered event. <br/>
        ///     This API supports filtering by **channel** and delete all messages associated with the **transactionId**.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByTransactionIdAsync(
            string transactionId,
            global::Novu.MessagesControllerDeleteMessagesByTransactionIdChannel? channel = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}