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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse> SubscribersV1ControllerBulkCreateSubscribersAsync(

            global::Novu.BulkSubscriberCreateDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create subscribers<br/>
        ///       Using this endpoint multiple subscribers can be created at once. The bulk API is limited to 500 subscribers per request.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse>> SubscribersV1ControllerBulkCreateSubscribersAsResponseAsync(

            global::Novu.BulkSubscriberCreateDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create subscribers<br/>
        ///       Using this endpoint multiple subscribers can be created at once. The bulk API is limited to 500 subscribers per request.<br/>
        ///     
        /// </summary>
        /// <param name="subscribers">
        /// An array of subscribers to be created in bulk.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersV1ControllerBulkCreateSubscribersResponse> SubscribersV1ControllerBulkCreateSubscribersAsync(
            global::System.Collections.Generic.IList<global::Novu.CreateSubscriberRequestDto> subscribers,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}