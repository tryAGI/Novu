#nullable enable

namespace Novu
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Bulk trigger event<br/>
        ///       Using this endpoint you can trigger multiple events at once, to avoid multiple calls to the API.<br/>
        ///       The bulk API is limited to 100 events per request.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerTriggerBulkResponse> TriggerBulkAsync(

            global::Novu.BulkTriggerEventDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk trigger event<br/>
        ///       Using this endpoint you can trigger multiple events at once, to avoid multiple calls to the API.<br/>
        ///       The bulk API is limited to 100 events per request.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EventsControllerTriggerBulkResponse>> TriggerBulkAsResponseAsync(

            global::Novu.BulkTriggerEventDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk trigger event<br/>
        ///       Using this endpoint you can trigger multiple events at once, to avoid multiple calls to the API.<br/>
        ///       The bulk API is limited to 100 events per request.<br/>
        ///     
        /// </summary>
        /// <param name="events"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerTriggerBulkResponse> TriggerBulkAsync(
            global::System.Collections.Generic.IList<global::Novu.TriggerEventRequestDto> events,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}