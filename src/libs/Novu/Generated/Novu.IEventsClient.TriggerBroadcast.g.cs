#nullable enable

namespace Novu
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Broadcast event to all<br/>
        /// Trigger a broadcast event to all existing subscribers, could be used to send announcements, etc.<br/>
        ///       In the future could be used to trigger events to a subset of subscribers based on defined filters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerBroadcastEventToAllResponse> TriggerBroadcastAsync(

            global::Novu.TriggerEventToAllRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Broadcast event to all<br/>
        /// Trigger a broadcast event to all existing subscribers, could be used to send announcements, etc.<br/>
        ///       In the future could be used to trigger events to a subset of subscribers based on defined filters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EventsControllerBroadcastEventToAllResponse>> TriggerBroadcastAsResponseAsync(

            global::Novu.TriggerEventToAllRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Broadcast event to all<br/>
        /// Trigger a broadcast event to all existing subscribers, could be used to send announcements, etc.<br/>
        ///       In the future could be used to trigger events to a subset of subscribers based on defined filters.
        /// </summary>
        /// <param name="name">
        /// The trigger identifier associated for the template you wish to send. This identifier can be found on the template page.
        /// </param>
        /// <param name="payload">
        /// The payload object is used to pass additional information that <br/>
        ///     could be used to render the template, or perform routing rules based on it. <br/>
        ///       For In-App channel, payload data are also available in &lt;Inbox /&gt;<br/>
        /// Example: {"comment_id":"string","post":{"text":"string"}}
        /// </param>
        /// <param name="overrides">
        /// This could be used to override provider specific configurations<br/>
        /// Example: {"fcm":{"data":{"key":"value"}}}
        /// </param>
        /// <param name="transactionId">
        /// A unique identifier for this transaction, we will generated a UUID if not provided.
        /// </param>
        /// <param name="actor">
        /// It is used to display the Avatar of the provided actor's subscriber id or actor object.<br/>
        ///     If a new actor object is provided, we will create a new subscriber in our system<br/>
        ///     
        /// </param>
        /// <param name="tenant">
        /// It is used to specify a tenant context during trigger event.<br/>
        ///     If a new tenant object is provided, we will create a new tenant.<br/>
        ///     
        /// </param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerBroadcastEventToAllResponse> TriggerBroadcastAsync(
            string name,
            object payload,
            global::Novu.TriggerOverrides? overrides = default,
            string? transactionId = default,
            global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? actor = default,
            global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? tenant = default,
            object? context = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}