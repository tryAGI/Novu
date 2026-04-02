#nullable enable

namespace Novu
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// List all events<br/>
        /// List all notification events (triggered events) for the current environment. <br/>
        ///     This API supports filtering by **channels**, **templates**, **emails**, **subscriberIds**, **transactionId**, **topicKey**, **severity**, **contextKeys**. <br/>
        ///     Checkout all available filters in the query section.<br/>
        ///     This API returns event triggers, to list each channel notifications, check messages APIs.
        /// </summary>
        /// <param name="channels"></param>
        /// <param name="templates"></param>
        /// <param name="emails"></param>
        /// <param name="search"></param>
        /// <param name="subscriberIds"></param>
        /// <param name="severity"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="transactionId"></param>
        /// <param name="topicKey"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ActivitiesResponseDto> NotificationsControllerListNotificationsAsync(
            global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? channels = default,
            global::System.Collections.Generic.IList<string>? templates = default,
            global::System.Collections.Generic.IList<string>? emails = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? subscriberIds = default,
            global::System.Collections.Generic.IList<string>? severity = default,
            double? page = default,
            double? limit = default,
            string? transactionId = default,
            string? topicKey = default,
            string? subscriptionId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all events<br/>
        /// List all notification events (triggered events) for the current environment. <br/>
        ///     This API supports filtering by **channels**, **templates**, **emails**, **subscriberIds**, **transactionId**, **topicKey**, **severity**, **contextKeys**. <br/>
        ///     Checkout all available filters in the query section.<br/>
        ///     This API returns event triggers, to list each channel notifications, check messages APIs.
        /// </summary>
        /// <param name="channels"></param>
        /// <param name="templates"></param>
        /// <param name="emails"></param>
        /// <param name="search"></param>
        /// <param name="subscriberIds"></param>
        /// <param name="severity"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="transactionId"></param>
        /// <param name="topicKey"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="contextKeys"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ActivitiesResponseDto>> NotificationsControllerListNotificationsAsResponseAsync(
            global::System.Collections.Generic.IList<global::Novu.ChannelTypeEnum>? channels = default,
            global::System.Collections.Generic.IList<string>? templates = default,
            global::System.Collections.Generic.IList<string>? emails = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? subscriberIds = default,
            global::System.Collections.Generic.IList<string>? severity = default,
            double? page = default,
            double? limit = default,
            string? transactionId = default,
            string? topicKey = default,
            string? subscriptionId = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}