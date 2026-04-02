#nullable enable

namespace Novu
{
    public partial interface ISubscribersClient
    {
        /// <summary>
        /// Search subscribers<br/>
        /// Search subscribers by their **email**, **phone**, **subscriberId** and **name**. <br/>
        ///     The search is case sensitive and supports pagination.Checkout all available filters in the query section.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="subscriberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.SubscribersControllerSearchSubscribersResponse> SubscribersControllerSearchSubscribersAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.SubscribersControllerSearchSubscribersOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? email = default,
            string? name = default,
            string? phone = default,
            string? subscriberId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search subscribers<br/>
        /// Search subscribers by their **email**, **phone**, **subscriberId** and **name**. <br/>
        ///     The search is case sensitive and supports pagination.Checkout all available filters in the query section.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="subscriberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.SubscribersControllerSearchSubscribersResponse>> SubscribersControllerSearchSubscribersAsResponseAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.SubscribersControllerSearchSubscribersOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? email = default,
            string? name = default,
            string? phone = default,
            string? subscriberId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}