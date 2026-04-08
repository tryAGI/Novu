#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Retrieve subscriber notifications<br/>
        /// Retrieve in-app (inbox) notifications for a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     Supports filtering by tags, read/archived/snoozed/seen state, data attributes, severity, date range, and context keys.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="after"></param>
        /// <param name="offset"></param>
        /// <param name="read"></param>
        /// <param name="archived"></param>
        /// <param name="snoozed"></param>
        /// <param name="seen"></param>
        /// <param name="data"></param>
        /// <param name="severity"></param>
        /// <param name="createdGte"></param>
        /// <param name="createdLte"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerGetSubscriberNotificationsResponse> SubscribersControllerGetSubscriberNotificationsAsync(
            string subscriberId,
            double? limit = default,
            string? after = default,
            double? offset = default,
            bool? read = default,
            bool? archived = default,
            bool? snoozed = default,
            bool? seen = default,
            string? data = default,
            global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? severity = default,
            double? createdGte = default,
            double? createdLte = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve subscriber notifications<br/>
        /// Retrieve in-app (inbox) notifications for a subscriber by its unique key identifier **subscriberId**. <br/>
        ///     Supports filtering by tags, read/archived/snoozed/seen state, data attributes, severity, date range, and context keys.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="after"></param>
        /// <param name="offset"></param>
        /// <param name="read"></param>
        /// <param name="archived"></param>
        /// <param name="snoozed"></param>
        /// <param name="seen"></param>
        /// <param name="data"></param>
        /// <param name="severity"></param>
        /// <param name="createdGte"></param>
        /// <param name="createdLte"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerGetSubscriberNotificationsResponse>> SubscribersControllerGetSubscriberNotificationsAsResponseAsync(
            string subscriberId,
            double? limit = default,
            string? after = default,
            double? offset = default,
            bool? read = default,
            bool? archived = default,
            bool? snoozed = default,
            bool? seen = default,
            string? data = default,
            global::System.Collections.Generic.IList<global::Novu.SubscribersControllerGetSubscriberNotificationsSeverityItem>? severity = default,
            double? createdGte = default,
            double? createdLte = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}