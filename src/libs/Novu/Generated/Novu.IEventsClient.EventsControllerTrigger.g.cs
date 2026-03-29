#nullable enable

namespace Novu
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Trigger event<br/>
        ///     Trigger event is the main (and only) way to send notifications to subscribers. The trigger identifier is used to match the particular workflow associated with it. Maximum number of recipients can be 100. Additional information can be passed according the body interface below.<br/>
        ///     To prevent duplicate triggers, you can optionally pass a **transactionId** in the request body. If the same **transactionId** is used again, the trigger will be ignored. The retention period depends on your billing tier.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerTriggerResponse> EventsControllerTriggerAsync(

            global::Novu.TriggerEventRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger event<br/>
        ///     Trigger event is the main (and only) way to send notifications to subscribers. The trigger identifier is used to match the particular workflow associated with it. Maximum number of recipients can be 100. Additional information can be passed according the body interface below.<br/>
        ///     To prevent duplicate triggers, you can optionally pass a **transactionId** in the request body. If the same **transactionId** is used again, the trigger will be ignored. The retention period depends on your billing tier.
        /// </summary>
        /// <param name="name">
        /// The trigger identifier of the workflow you wish to send. This identifier can be found on the workflow page.<br/>
        /// Example: workflow_identifier
        /// </param>
        /// <param name="payload">
        /// The payload object is used to pass additional custom information that could be <br/>
        ///     used to render the workflow, or perform routing rules based on it. <br/>
        ///       This data will also be available when fetching the notifications feed from the API to display certain parts of the UI.<br/>
        /// Example: {"comment_id":"string","post":{"text":"string"}}
        /// </param>
        /// <param name="overrides">
        /// This could be used to override provider specific configurations<br/>
        /// Example: {"fcm":{"data":{"key":"value"}}}
        /// </param>
        /// <param name="to">
        /// The recipients list of people who will receive the notification. Maximum number of recipients can be 100.
        /// </param>
        /// <param name="transactionId">
        /// A unique identifier for deduplication. If the same **transactionId** is sent again, <br/>
        ///       the trigger is ignored. Useful to prevent duplicate notifications. The retention period depends on your billing tier.
        /// </param>
        /// <param name="actor">
        /// It is used to display the Avatar of the provided actor's subscriber id or actor object.<br/>
        ///     If a new actor object is provided, we will create a new subscriber in our system
        /// </param>
        /// <param name="tenant">
        /// It is used to specify a tenant context during trigger event.<br/>
        ///     Existing tenants will be updated with the provided details.
        /// </param>
        /// <param name="context"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EventsControllerTriggerResponse> EventsControllerTriggerAsync(
            string name,
            global::Novu.OneOf<global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto, string>>, string, global::Novu.SubscriberPayloadDto, global::Novu.TopicPayloadDto> to,
            object? payload = default,
            global::Novu.TriggerOverrides? overrides = default,
            string? transactionId = default,
            global::Novu.OneOf<string, global::Novu.SubscriberPayloadDto>? actor = default,
            global::Novu.OneOf<string, global::Novu.TenantPayloadDto>? tenant = default,
            object? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}