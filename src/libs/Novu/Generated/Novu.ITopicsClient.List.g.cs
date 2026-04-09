#nullable enable

namespace Novu
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// List all topics<br/>
        /// This api returns a paginated list of topics.<br/>
        ///     Topics can be filtered by **key**, **name**, or **includeCursor** to paginate through the list. <br/>
        ///     Checkout all available filters in the query section.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.TopicsControllerListTopicsResponse> ListAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.TopicsControllerListTopicsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? key = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all topics<br/>
        /// This api returns a paginated list of topics.<br/>
        ///     Topics can be filtered by **key**, **name**, or **includeCursor** to paginate through the list. <br/>
        ///     Checkout all available filters in the query section.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.TopicsControllerListTopicsResponse>> ListAsResponseAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.TopicsControllerListTopicsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? key = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}