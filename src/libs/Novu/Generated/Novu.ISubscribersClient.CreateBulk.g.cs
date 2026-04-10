#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Bulk create subscribers<br/>
        ///       Using this endpoint multiple subscribers can be created at once. The bulk API is limited to 500 subscribers per request.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse> CreateBulkAsync(

            global::Novu.BulkSubscriberCreateDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create subscribers<br/>
        ///       Using this endpoint multiple subscribers can be created at once. The bulk API is limited to 500 subscribers per request.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse>> CreateBulkAsResponseAsync(

            global::Novu.BulkSubscriberCreateDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create subscribers<br/>
        ///       Using this endpoint multiple subscribers can be created at once. The bulk API is limited to 500 subscribers per request.<br/>
        ///     
        /// </summary>
        /// <param name="subscribers">
        /// An array of subscribers to be created in bulk.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse> CreateBulkAsync(
            global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto> subscribers,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}