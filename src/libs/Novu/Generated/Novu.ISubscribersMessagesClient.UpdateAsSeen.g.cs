#nullable enable

namespace Novu
{
    public partial interface ISubscribersMessagesClient
    {
        /// <summary>
        /// Update notification action status<br/>
        /// Update in-app (inbox) notification's action status by its unique key identifier **messageId** and type field **type**. <br/>
        ///       **type** field can be **primary** or **secondary**
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="type"></param>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse> UpdateAsSeenAsync(
            string messageId,
            object type,
            string subscriberId,

            global::Novu.MarkMessageActionAsSeenDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update notification action status<br/>
        /// Update in-app (inbox) notification's action status by its unique key identifier **messageId** and type field **type**. <br/>
        ///       **type** field can be **primary** or **secondary**
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="type"></param>
        /// <param name="subscriberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse>> UpdateAsSeenAsResponseAsync(
            string messageId,
            object type,
            string subscriberId,

            global::Novu.MarkMessageActionAsSeenDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update notification action status<br/>
        /// Update in-app (inbox) notification's action status by its unique key identifier **messageId** and type field **type**. <br/>
        ///       **type** field can be **primary** or **secondary**
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="type"></param>
        /// <param name="subscriberId"></param>
        /// <param name="status">
        /// Message action status
        /// </param>
        /// <param name="payload">
        /// Message action payload
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerMarkActionAsSeenResponse> UpdateAsSeenAsync(
            string messageId,
            object type,
            string subscriberId,
            global::Novu.MarkMessageActionAsSeenDtoStatus status,
            object? payload = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}