#nullable enable

namespace Novu
{
    public partial interface IContextsClient
    {
        /// <summary>
        /// List all contexts<br/>
        /// Retrieve a paginated list of all contexts, optionally filtered by type and key pattern.<br/>
        ///       **type** and **id** are optional fields, if provided, only contexts with the matching type and id will be returned.<br/>
        ///       **search** is an optional field, if provided, only contexts with the matching key pattern will be returned.<br/>
        ///       Checkout all possible parameters in the query section below for more details
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ContextsControllerListContextsResponse> ContextsControllerListContextsAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.ContextsControllerListContextsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? id = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}