#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Retrieve a layout<br/>
        /// Fetches details of a specific layout by its unique identifier **layoutId**
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerGetResponse> LayoutsControllerGetAsync(
            string layoutId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}