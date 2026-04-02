#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Get layout usage<br/>
        /// Retrieves information about workflows that use the specified layout by its unique identifier **layoutId**
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerGetUsageResponse> LayoutsControllerGetUsageAsync(
            string layoutId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get layout usage<br/>
        /// Retrieves information about workflows that use the specified layout by its unique identifier **layoutId**
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.LayoutsControllerGetUsageResponse>> LayoutsControllerGetUsageAsResponseAsync(
            string layoutId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}