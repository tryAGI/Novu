#nullable enable

namespace Novu
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Delete a message<br/>
        /// Delete a message entity from the Novu platform by **messageId**. <br/>
        ///     This action is irreversible. **messageId** is required and of mongodbId type.
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.MessagesControllerDeleteMessageResponse> MessagesControllerDeleteMessageAsync(
            string messageId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a message<br/>
        /// Delete a message entity from the Novu platform by **messageId**. <br/>
        ///     This action is irreversible. **messageId** is required and of mongodbId type.
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.MessagesControllerDeleteMessageResponse>> MessagesControllerDeleteMessageAsResponseAsync(
            string messageId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}