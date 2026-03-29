#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Delete a layout<br/>
        /// Removes a specific layout by its unique identifier **layoutId**
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task LayoutsControllerDeleteAsync(
            string layoutId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}