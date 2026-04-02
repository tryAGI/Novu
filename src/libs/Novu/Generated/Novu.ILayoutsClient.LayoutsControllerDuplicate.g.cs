#nullable enable

namespace Novu
{
    public partial interface ILayoutsClient
    {
        /// <summary>
        /// Duplicate a layout<br/>
        /// Duplicates a layout by its unique identifier **layoutId**. This will create a new layout with the content of the original layout.
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerDuplicateResponse> LayoutsControllerDuplicateAsync(
            string layoutId,

            global::Novu.DuplicateLayoutDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a layout<br/>
        /// Duplicates a layout by its unique identifier **layoutId**. This will create a new layout with the content of the original layout.
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.LayoutsControllerDuplicateResponse>> LayoutsControllerDuplicateAsResponseAsync(
            string layoutId,

            global::Novu.DuplicateLayoutDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a layout<br/>
        /// Duplicates a layout by its unique identifier **layoutId**. This will create a new layout with the content of the original layout.
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="name">
        /// Name of the layout
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this layout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.LayoutsControllerDuplicateResponse> LayoutsControllerDuplicateAsync(
            string layoutId,
            string name,
            bool? isTranslationEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}