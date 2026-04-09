#nullable enable

namespace Novu
{
    public partial interface ISubscribersTopicsClient
    {
        /// <summary>
        /// Retrieve subscriber subscriptions<br/>
        /// Retrieve subscriber's topic subscriptions by its unique key identifier **subscriberId**. <br/>
        ///     Checkout all available filters in the query section.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="key"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerListSubscriberTopicsResponse> List2Async(
            string subscriberId,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? key = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve subscriber subscriptions<br/>
        /// Retrieve subscriber's topic subscriptions by its unique key identifier **subscriberId**. <br/>
        ///     Checkout all available filters in the query section.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="key"></param>
        /// <param name="contextKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerListSubscriberTopicsResponse>> List2AsResponseAsync(
            string subscriberId,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.SubscribersControllerListSubscriberTopicsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? key = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}