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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerTriggerBulkResponse> EventsControllerTriggerBulkAsync(

            global::Novu.BulkTriggerEventDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk trigger event<br/>
        ///       Using this endpoint you can trigger multiple events at once, to avoid multiple calls to the API.<br/>
        ///       The bulk API is limited to 100 events per request.<br/>
        ///     
        /// </summary>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerTriggerBulkResponse> EventsControllerTriggerBulkAsync(
            global::System.Collections.Generic.IList<global::Novu.TriggerEventRequestDto> events,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}