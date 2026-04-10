#nullable enable

namespace Novu
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// List all messages<br/>
        /// List all messages for the current environment. <br/>
        ///     This API supports filtering by **channel**, **subscriberId**, and **transactionId**. <br/>
        ///     This API returns a paginated list of messages.
        /// </summary>
        /// <param name="channel">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="subscriberId"></param>
        /// <param name="transactionId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.MessagesResponseDto> MessagesControllerGetMessagesAsync(
            global::Novu.ChannelTypeEnum? channel = default,
            string? subscriberId = default,
            global::System.Collections.Generic.IList<string>? transactionId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            double? page = default,
            double? limit = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all messages<br/>
        /// List all messages for the current environment. <br/>
        ///     This API supports filtering by **channel**, **subscriberId**, and **transactionId**. <br/>
        ///     This API returns a paginated list of messages.
        /// </summary>
        /// <param name="channel">
        /// Channel type through which the message is sent
        /// </param>
        /// <param name="subscriberId"></param>
        /// <param name="transactionId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.MessagesResponseDto>> MessagesControllerGetMessagesAsResponseAsync(
            global::Novu.ChannelTypeEnum? channel = default,
            string? subscriberId = default,
            global::System.Collections.Generic.IList<string>? transactionId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            double? page = default,
            double? limit = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}