#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// List all layouts<br/>
        /// Retrieves a list of layouts with optional filtering and pagination
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerListResponse> LayoutsControllerListAsync(
            double? limit = default,
            double? offset = default,
            global::Novu.DirectionEnum? orderDirection = default,
            global::Novu.LayoutResponseDtoSortField? orderBy = default,
            string? query = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}